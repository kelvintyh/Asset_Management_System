Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.NetworkInformation

Module Module1

    Dim db As New AMSDBDataContext()
    ' For FrmAssetAddOthers
    Public action_type As String
    Public cbo_selection As String
    Public currentUser As New User

    'for initialize database
    Public asset_List As New List(Of Asset)
    Public manufacturer_List As New List(Of Manufacturer)
    Public assetType_List As New List(Of AssetType)
    Public location_List As New List(Of InventoryLocation)
    Public Transaction_List As New List(Of Transaction)
    Public user_list As New List(Of User)
    Public login_history As New List(Of LoginHistory)

    Public Function GetBinary(ByVal image As Image, ByVal format As ImageFormat) As Byte()
        Dim ms As New System.IO.MemoryStream
        If image IsNot Nothing Then
            If format Is Nothing Then
                format = image.RawFormat
            End If
            image.Save(ms, format)
            Return ms.ToArray()
        Else
            Return Nothing
        End If
    End Function

    Public Function GetImage(ByVal byteArray As Byte()) As Image
        Dim ms As New System.IO.MemoryStream
        ms = New MemoryStream(byteArray)
        Dim image As Image = Image.FromStream(ms)
        Return image
    End Function

    Public Function GetNextId(table As String) As String

        If table.Equals("Asset") Then
            Dim rs = From a In db.Assets
                     Order By a.Id Descending

            ' If the table is empty
            If rs.Count = 0 Then
                Return "A100001"
            Else
                Dim newid As Integer = Integer.Parse(rs.First.Id.Substring(2, 5))
                Return (newid + 1).ToString("A100000")
            End If

        ElseIf table.Equals("AssetType") Then

            Dim rs = From a In db.AssetTypes
                     Order By a.Id Descending

            ' If the table is empty
            If rs.Count = 0 Then
                Return "AT100001"
            Else
                Dim newid As Integer = Integer.Parse(rs.First.Id.Substring(2, 5))
                Return (newid + 1).ToString("AT100000")
            End If

        ElseIf table.Equals("Manufacturer") Then

            Dim rs = From a In db.Manufacturers
                     Order By a.Id Descending

            ' If the table is empty
            If rs.Count = 0 Then
                Return "M100001"
            Else
                Dim newid As Integer = Integer.Parse(rs.First.Id.Substring(2, 5))
                Return (newid + 1).ToString("M100000")
            End If
        ElseIf table.Equals("Location") Then

            Dim rs = From a In db.InventoryLocations
                     Order By a.Id Descending

            ' If the table is empty
            If rs.Count = 0 Then
                Return "L100001"
            Else
                Dim newid As Integer = Integer.Parse(rs.First.Id.Substring(2, 5))
                Return (newid + 1).ToString("L100000")
            End If

        End If

        If table.Equals("Warranty") Then
            Dim rs = From w In db.Warranties
                     Order By w.Warranty_Id Descending

            'If the Then table Is Empty
            If rs.Count = 0 Then
                Return "W100001"
            Else
                Dim newid As Integer = Integer.Parse(rs.First.Warranty_Id.Substring(2, 5))
                Return (newid + 1).ToString("W100000")
            End If
        End If

        If table.Equals("Transaction") Then

                Dim rs = From a In db.Transactions
                         Order By a.Id Descending

                ' If the table is empty
                If rs.Count = 0 Then
                    Return "T100001"
                Else
                    Dim newid As Integer = Integer.Parse(rs.First.Id.Substring(2, 5))
                    Return (newid + 1).ToString("T100000")
                End If

            ElseIf table.Equals("ActionHistory") Then

                Dim rs = From a In db.ActionHistories
                     Order By a.Id Descending

            ' If the table is empty
            If rs.Count = 0 Then
                Return "AH100001"
            Else
                Dim newid As Integer = Integer.Parse(rs.First.Id.Substring(3, 5))
                Return (newid + 1).ToString("AH100000")
            End If
        End If

    End Function

    Public Function GetManu()

        'store the selection of user first
        Dim a As String = If(IsNothing(FrmAssetUpdate.cboManu.SelectedItem), "", FrmAssetUpdate.cboManu.SelectedItem.ToString)
        Dim b As String = If(IsNothing(FrmAssetAdd.cboManu.SelectedItem), "", FrmAssetAdd.cboManu.SelectedItem.ToString)

        'clear the combo box to avoid redundancy
        FrmAssetUpdate.cboManu.Items.Clear()
        FrmAssetAdd.cboManu.Items.Clear()

        're insert the item into combo box
        For Each m In db.Manufacturers
            FrmAssetUpdate.cboManu.Items.Add(m.Name)
            FrmAssetAdd.cboManu.Items.Add(m.Name)
        Next

        'put the selection back
        FrmAssetUpdate.cboManu.SelectedItem = a
        FrmAssetAdd.cboManu.SelectedItem = b



    End Function

    Public Function GetLocation()

        Dim a As String = If(IsNothing(FrmAssetUpdate.cboLocation.SelectedItem), "", FrmAssetUpdate.cboLocation.SelectedItem.ToString)
        Dim b As String = If(IsNothing(FrmAssetAdd.cboLocation.SelectedItem), "", FrmAssetAdd.cboLocation.SelectedItem.ToString)

        FrmAssetUpdate.cboLocation.Items.Clear()
        FrmAssetAdd.cboLocation.Items.Clear()
        Frm_TransactionCheckIn.cboLocation.Items.Clear()

        For Each m In db.InventoryLocations
            FrmAssetUpdate.cboLocation.Items.Add(m.Name_)
            FrmAssetAdd.cboLocation.Items.Add(m.Name_)
            Frm_TransactionCheckIn.cboLocation.Items.Add(m.Name_)
        Next

        FrmAssetUpdate.cboLocation.SelectedItem = a
        FrmAssetAdd.cboLocation.SelectedItem = b

    End Function

    Public Function GetAssetType()
        Dim a As String = If(IsNothing(FrmAssetUpdate.cboType.SelectedItem), "", FrmAssetUpdate.cboType.SelectedItem.ToString)
        Dim b As String = If(IsNothing(FrmAssetAdd.cboType.SelectedItem), "", FrmAssetAdd.cboType.SelectedItem.ToString)

        FrmAssetUpdate.cboType.Items.Clear()
        FrmAssetAdd.cboType.Items.Clear()

        For Each m In db.AssetTypes
            FrmAssetUpdate.cboType.Items.Add(m.Description)
            FrmAssetAdd.cboType.Items.Add(m.Description)
        Next

        FrmAssetUpdate.cboType.SelectedItem = a
        FrmAssetAdd.cboType.SelectedItem = b

    End Function

    Public Function createActionHistory(ByVal actionType As String, ByVal staffID As String, ByVal id As String) As String
        Dim desc As String
        Dim type As String
        Dim deviceName As String 'get device name
        Dim macAddress As String 'get mac address
        Dim ipAddress As String 'get ip address

        If actionType.Equals("CreateA") Then
            desc = "Asset " + id
            type = "Create"
        ElseIf actionType.Equals("UpdateA") Then
            desc = "Asset " + id
            type = "Update"
        ElseIf actionType.Equals("DeleteA") Then
            desc = "Asset " + id
            type = "Delete"
        ElseIf actionType.Equals("CreateT") Then
            desc = "Transaction " + id
            type = "Create"
        ElseIf actionType.Equals("UpdateT") Then
            desc = "Transaction " + id
            type = "Update"
        ElseIf actionType.Equals("DeleteT") Then
            desc = "Transaction " + id
            type = "Delete"
        ElseIf actionType.Equals("CreateW") Then
            desc = "Warranty " + id
            type = "Create"
        ElseIf actionType.Equals("UpdateW") Then
            desc = "Warranty " + id
            type = "Update"
        ElseIf actionType.Equals("DeleteW") Then
            desc = "Warranty " + id
            type = "Delete"
        ElseIf actionType.Equals("CreateU") Then
            desc = "User " + id
            type = "Create"
        ElseIf actionType.Equals("UpdateU") Then
            desc = "User " + id
            type = "Update"
        ElseIf actionType.Equals("Recovery") Then
            desc = "Password Recovery"
            type = "Update"
        ElseIf actionType.Equals("DeleteU") Then
            desc = "User " + id
            type = "Delete"
        ElseIf actionType.Equals("Recovery") Then
            desc = "Password Recovery"
            type = "Update"
        End If

        deviceName = System.Environment.MachineName
        ipAddress = System.Net.Dns.GetHostByName(deviceName).AddressList(0).ToString()
        macAddress = getMacAddress()

        Dim a As New ActionHistory()
        a.Id = GetNextId("ActionHistory")
        a.Type = type
        a.Description = desc
        a.Date = Date.Now.ToShortDateString()
        a.UserId = staffID
        a.Device_Name = deviceName
        a.MAC_Address = macAddress
        a.IP_Address = ipAddress

        db.ActionHistories.InsertOnSubmit(a)
        db.SubmitChanges()
    End Function

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function

    Public Function ResizeImage(ByVal InputImage As Image) As Image
        ' Get the scale factor.
        Dim scale_factor As Single = Single.Parse(2)

        ' Get the source bitmap.
        Dim bm_source As New Bitmap(InputImage)

        ' Make a bitmap for the result.
        Dim bm_dest As New Bitmap(
        CInt(bm_source.Width / scale_factor),
        CInt(bm_source.Height / scale_factor))

        ' Make a Graphics object for the result Bitmap.
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

        ' Copy the source image into the destination bitmap.
        gr_dest.DrawImage(bm_source, 0, 0,
        bm_dest.Width + 1,
        bm_dest.Height + 1)

        ' Display the result.
        ' Console.WriteLine("resized")
        'Console.WriteLine(bm_dest.Size)
        Return bm_dest
    End Function

    Function initiateData()
        Dim db As New AMSDBDataContext()
        Dim d As DateTime = DateTime.Now
        'Initiate the List with 10 records
        asset_List.Add(New Asset("A100001", "Smartphone", "Xiaomi", "Electronic", "Xiaomi Redmi 8A", "SDE3484DCSFCS4", "New", "In storage", "UnitA-101", GetBinary(My.Resources.Xiaomi_Redmi_8A__2GB___32GB__Global_Versionr, Nothing), d, "Xiaomi Official Store Global", 329, "13485-001", "", ""))
        asset_List.Add(New Asset("A100002", "Laptop", "HP", "Electronic", "Pavilion x360", "HMH8NUDA7AXS7A8C", "New", "In storage", "UnitA-101", GetBinary(My.Resources.HP_Pavilion_x360_Laptop___14_dh0041tx, Nothing), d, "HP Online Store", 3199, "13485-002", "", ""))
        asset_List.Add(New Asset("A100003", "Printer", "HP", "Electronic", "Deskjet 2529 Ink Advantage All in One Printer K7W98A", "S87FS76QWB89RT", "New", "In storage", "UnitA-101", GetBinary(My.Resources.HP_DeskJet_Ink_Advantage_Ultra_2529_500x500, Nothing), d, "all_it.os", 275, "13485-003", "", ""))
        asset_List.Add(New Asset("A100004", "Speaker", "Logitech", "Electronic", "Logitech Z623 Speaker System (980-000403)", "23JDSVID2SDSD", "New", "In storage", "UnitA-101", GetBinary(My.Resources.Logitech_Z623_Speaker_System__980_000403_, Nothing), d, "logitech.os", 449.88, "13485-004", "", ""))
        asset_List.Add(New Asset("A100005", "Projector", "BenQ", "Electronic", "BenQ SVGA Projector 3600lm MS550", "8WEIUH2I21EFNK", "New", "In storage", "UnitA-101", GetBinary(My.Resources.BenQ_SVGA_Projector_3600lm_MS550, Nothing), d, "all_it.os", 1119, "13485-005", "", ""))
        asset_List.Add(New Asset("A100006", "Rack", "Y23E", "Furniture", "2 Bar Garment Rack - Grey", "3IDNWEUI23N3J2", "New", "In storage", "UnitB-101", GetBinary(My.Resources.Y23E_2_Bar_Garment_Rack___Grey, Nothing), d, "courts.os", 60, "13485-006", "", ""))
        asset_List.Add(New Asset("A100007", "Rack", "PLASTIC Master", "Furniture", "3 Tier Multipurpose Rack", "2IEUN23BUSD", "New", "In storage", "UnitB-101", GetBinary(My.Resources._3_Tier_Multipurpose_Rack, Nothing), d, "plasticmaster", 40, "13485-007", "", ""))
        asset_List.Add(New Asset("A100008", "Chair", "Odoso", "Furniture", "Odoso Ajustable Office Chair", "FIUH4UI430212DG", "New", "In storage", "UnitB-101", GetBinary(My.Resources.ODOSO_Adjustable_Swivel_Med_Back_Mesh_Mix___match_Office_Chai, Nothing), d, "sokano", 69.9, "13485-008", "", ""))
        asset_List.Add(New Asset("A100009", "Table", "Ay Office System", "Furniture", "AY Office System L Shape Office Table with J Metal Leg", "2E23NFIB024JFOF", "New", "In storage", "UnitB-101", GetBinary(My.Resources.AY_Office_System_L_Shape_Office_Table_with_J_Metal_Leg, Nothing), d, "ayofficesystem", 675, "13485-009", "", ""))
        asset_List.Add(New Asset("A100010", "Sofa", "ATOM", "Furniture", "2 Seater Atom Foldable Sofa Bed", "09DNSFU2GEU3D2J", "New", "In storage", "UnitB-101", GetBinary(My.Resources._2_Seater_Atom_Foldable_Sofa_Bed, Nothing), d, "myfurniturelab", 199, "13485-010", "", ""))

        assetType_List.Add(New AssetType("AT100001", "Electronic"))
        assetType_List.Add(New AssetType("AT100002", "Furniture"))
        assetType_List.Add(New AssetType("AT100003", "Automotive"))
        assetType_List.Add(New AssetType("AT100004", "Sports"))
        assetType_List.Add(New AssetType("AT100005", "Outdoor"))

        manufacturer_List.Add(New Manufacturer("M100001", "Xiaomi"))
        manufacturer_List.Add(New Manufacturer("M100002", "HP"))
        manufacturer_List.Add(New Manufacturer("M100003", "Logitech"))
        manufacturer_List.Add(New Manufacturer("M100004", "BenQ"))
        manufacturer_List.Add(New Manufacturer("M100005", "Y23E"))
        manufacturer_List.Add(New Manufacturer("M100006", "Plastic Master"))
        manufacturer_List.Add(New Manufacturer("M100007", "Odoso"))
        manufacturer_List.Add(New Manufacturer("M100008", "Ay Office System"))
        manufacturer_List.Add(New Manufacturer("M100009", "ATOM"))


        location_List.Add(New InventoryLocation("L100001", "UnitA-101"))
        location_List.Add(New InventoryLocation("L100002", "UnitB-101"))
        location_List.Add(New InventoryLocation("L100003", "UnitC-101"))
        location_List.Add(New InventoryLocation("L100004", "UnitD-101"))
        location_List.Add(New InventoryLocation("L100005", "UnitE-101"))

        Transaction_List.Add(New Transaction("T100001", "Checked out", "2020-04-27 21:56:49", "A100001", "AD0001", "AD0001", "Local", "Local", "2020-04-27", "2020-04-27", "", "", "", "", "In"))
        Transaction_List.Add(New Transaction("T100002", "Checked out", "2020-04-27 22:00:01", "A100001", "", "AD0001", "Third Party", "Local", "2020-04-27", "2020-04-27", "Jaren Yeap", "012-5453257", "jarenyp123@gmail.com", "", "In"))
        Transaction_List.Add(New Transaction("T100003", "Checked out", "2020-04-28 13:17:56", "A100002", "AD0001", "AD0001", "Local", "Local", "2020-04-28", "2020-04-29", "", "", "", "", "In"))
        Transaction_List.Add(New Transaction("T100004", "Checked out", "2020-04-28 13:58:03", "A100002", "AD0001", "AD0001", "Local", "Local", "2020-04-28", "2020-04-30", "", "", "", "", "In"))
        Transaction_List.Add(New Transaction("T100005", "Checked out", "2020-04-28 14:02:30", "A100002", "AD0001", "S0001", "Local", "Local", "2020-04-28", "2020-04-28", "", "", "", "", "In"))
        Transaction_List.Add(New Transaction("T100006", "Checked out", "2020-04-28 14:32:06", "A100003", "S0001", "S0001", "Local", "Local", "2020-04-28", "2020-04-28", "", "", "", "", "Out"))
        Transaction_List.Add(New Transaction("T100007", "Checked out", "2020-04-28 14:38:18", "A100002", "S0001", "S0001", "Local", "Local", "2020-04-28", "2020-04-28", "", "", "", "", "In"))
        Transaction_List.Add(New Transaction("T100008", "Checked out", "2020-04-28 14:43:11", "A100002", "AD0001", "S0001", "Local", "Local", "2020-04-28", "2020-04-28", "", "", "", "", "In"))
        Transaction_List.Add(New Transaction("T100009", "Checked out", "2020-04-28 14:47:23", "A100001", "S0001", "S0001", "Local", "Local", "2020-04-28", "2020-04-28", "", "", "", "", "In"))
        Transaction_List.Add(New Transaction("T100010", "Checked out", "2020-04-28 14:47:23", "A100001", "S0001", "S0001", "Local", "Local", "2020-04-28", "2020-04-28", "", "", "", "", "In"))

        user_list.Add(New User("AD0001", "Gregg Chan", "Gregg", "12345678", "Male", "012-3456789", "chan@gmail.com", GetBinary(My.Resources.login, Nothing), "Admin"))
        user_list.Add(New User("AD0002", "Kelvin Tham", "Kelvin", "12345678", "Male", "011-3456789", "kelvin@gmail.com", GetBinary(My.Resources.login, Nothing), "Admin"))
        user_list.Add(New User("S0003", "Brian Ooi", "Brian", "12345678", "Male", "016-3456789", "brian@gmail.com", GetBinary(My.Resources.login, Nothing), "Staff"))
        user_list.Add(New User("S0004", "Jeremy Yong", "Jeremy", "12345678", "Male", "012-2242245", "jeremy@gmail.com", GetBinary(My.Resources.login, Nothing), "Staff"))
        user_list.Add(New User("S0005", "Benz Fong", "Benz", "12345678", "Male", "012-1212454", "benz@gmail.com", GetBinary(My.Resources.login, Nothing), "Staff"))
        user_list.Add(New User("S0006", "Jacky Chan", "Jacky", "12345678", "Male", "016-3476854", "jacky@gmail.com", GetBinary(My.Resources.login, Nothing), "Staff"))
        user_list.Add(New User("S0007", "Harley Cheah", "Harley", "12345678", "Male", "012-4368984", "harley@gmail.com", GetBinary(My.Resources.login, Nothing), "Staff"))
        user_list.Add(New User("S0008", "Jaren Yeap", "Jaren", "12345678", "Male", "012-9875699", "jaren@gmail.com", GetBinary(My.Resources.login, Nothing), "Staff"))
        user_list.Add(New User("S0009", "Joseph Yeak", "Joseph", "12345678", "Male", "012-9874322", "joseph@gmail.com", GetBinary(My.Resources.login, Nothing), "Staff"))
        user_list.Add(New User("S0010", "Jun Yan", "JY", "12345678", "Male", "018-2867444", "koh@gmail.com", GetBinary(My.Resources.login, Nothing), "Staff"))

        login_history.Add(New LoginHistory("L0001", "AD0001", "Gregg", "Admin", "2020-04-27 19:42:31"))
        login_history.Add(New LoginHistory("L0002", "AD0001", "Gregg", "Admin", "2020-04-27 19:43:33"))
        login_history.Add(New LoginHistory("L0003", "AD0001", "Gregg", "Admin", "2020-04-27 19:44:35"))
        login_history.Add(New LoginHistory("L0004", "AD0001", "Gregg", "Admin", "2020-04-27 19:45:36"))
        login_history.Add(New LoginHistory("L0005", "AD0001", "Gregg", "Admin", "2020-04-27 20:46:35"))
        login_history.Add(New LoginHistory("L0006", "AD0001", "Gregg", "Admin", "2020-04-27 20:48:31"))
        login_history.Add(New LoginHistory("L0007", "AD0001", "Gregg", "Admin", "2020-04-27 22:50:30"))
        login_history.Add(New LoginHistory("L0008", "AD0001", "Gregg", "Admin", "2020-04-27 23:10:40"))
        login_history.Add(New LoginHistory("L0009", "AD0001", "Gregg", "Admin", "2020-04-27 23:30:50"))
        login_history.Add(New LoginHistory("L0010", "AD0001", "Gregg", "Admin", "2020-04-27 23:35:55"))
        'Load the item in list into database
        Try
            For Each i In asset_List
                db.Assets.InsertOnSubmit(i)
                db.SubmitChanges()
            Next

            For Each i In assetType_List
                db.AssetTypes.InsertOnSubmit(i)
                db.SubmitChanges()
            Next

            For Each i In manufacturer_List
                db.Manufacturers.InsertOnSubmit(i)
                db.SubmitChanges()
            Next

            For Each i In location_List
                db.InventoryLocations.InsertOnSubmit(i)
                db.SubmitChanges()
            Next

            For Each i In Transaction_List
                db.Transactions.InsertOnSubmit(i)
                db.SubmitChanges()
            Next

            For Each i In user_list
                db.Users.InsertOnSubmit(i)
                db.SubmitChanges()
            Next

            For Each i In login_history
                db.LoginHistories.InsertOnSubmit(i)
                db.SubmitChanges()
            Next
        Catch ex As Exception

        End Try

    End Function

End Module
