Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.NetworkInformation

Module Module1

    Dim db As New AMSDBDataContext()
    ' For FrmAssetAddOthers
    Public action_type As String
    Public cbo_selection As String
    Public currentUser As New User

    Public Function GetBinary(ByVal image As Image, ByVal format As ImageFormat) As Byte()
        Dim ms As New System.IO.MemoryStream
        If image IsNot Nothing Then
            If format Is Nothing Then
                format = image.RawFormat 'use image original format
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

End Module
