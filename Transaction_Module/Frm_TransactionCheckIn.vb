Imports System.Text

Public Class Frm_TransactionCheckIn

    Dim valid As Boolean
    Private Sub Frm_TransactionCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()

        GetLocation()
        cboStatus.SelectedIndex = 0
        cboReturnedBy.SelectedIndex = 0
        reset()
    End Sub

    Function UpdateTable()
        dgv.Columns.Clear()
        dgv.Columns.Add("Id", "Id")
        dgv.Columns.Add("Description", "Description")
        dgv.Columns.Add("Manufacturer", "Manufacturer")
        dgv.Columns.Add("Asset Type", "Asset Type")
        dgv.Columns.Add("Model", "Model")
        dgv.Columns.Add("Serial Number", "Serial Number")
        dgv.Columns.Add("Condition", "Condition")
        dgv.Columns.Add("Status", "Status")
        dgv.Columns.Add("Inv. Location", "Inv. Location")
        dgv.Columns.Add("Date of Acquisition", "Date of Acquisition")
        dgv.Columns.Add("Vendor", "Vendor")
        dgv.Columns.Add("Value At Acquisition", "Value At Acquisition")
        dgv.Columns.Add("Invoice", "Invoice")

        For Each item As Asset In assetList
            With item
                dgv.Rows.Add(.Id, .Description, .Manufacturer, .Asset_type, .Model, .Serial_number, .Condition, .Status, .Inventory_location, .Date_of_acquisition, .Vendor, .Value_At_Acquisition, .Invoice)
            End With
        Next
    End Function

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If dgv.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows(i).Selected Then
                    For item As Integer = 0 To assetList.Count - 1

                        If assetList(item).Id = dgv.Item(0, i).Value Then
                            assetList.Remove(assetList(item))
                        End If
                    Next

                End If
            Next
            MessageBox.Show("Record removed successful !", "Information")
        Else
            MessageBox.Show("No Record Selected !", "Error")
        End If


        UpdateTable()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim rs = From u In db.Users
                 Where u.Id.Equals(txtStaffID.Text.Trim)
        Try
            Try
                picStaffProfile.Image = GetImage(rs.First.Image.ToArray)
            Catch ex As Exception

            End Try

            lblName.Text = rs.First.Name
            lblContact.Text = rs.First.Contact_number
            lblEmail.Text = rs.First.Email_address
            valid = True

        Catch ex As Exception
            valid = False
            MessageBox.Show("Invalid User Id !", "Input Error")
        End Try
        Console.WriteLine(valid)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Frm_CheckedOut_Item_List.ShowDialog()
    End Sub

    Private Sub Frm_TransactionCheckIn_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        UpdateTable()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click

        If cboReturnedBy.SelectedIndex = 1 Then
            If txt3rdDesc.Text = "" Then
                MessageBox.Show("Third Party Description is Empty !", "Error")
            Else
                valid = True
            End If
        Else
            BtnSearch_Click(Nothing, Nothing)
        End If

        Dim count As Integer = 0
        Dim msg As New StringBuilder()
        msg.AppendLine("Are you sure to Check In :")
        For Each item In assetList
            msg.AppendLine(count & ". " & item.Id & vbTab & item.Description)
        Next
        msg.AppendLine(vbNewLine & "for " & txtStaffID.Text & "  " & lblName.Text)


        If valid = True And assetList.Count <> 0 Then
            Dim result As DialogResult = MessageBox.Show(msg.ToString, "Information", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                For Each item In assetList



                    Dim t As Transaction = db.Transactions.FirstOrDefault(Function(o) o.Id = item.TransactionId)
                    t.Check_In_By = If(cboReturnedBy.SelectedIndex = 0, txtStaffID.Text, txt3rdDesc.Text)
                    t.Check_In_Type = If(cboReturnedBy.SelectedIndex = 0, "Local", "Third Party")
                    t.Status = "In"
                    t.Actual_Return_Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")


                    Dim a As Asset = db.Assets.FirstOrDefault(Function(o) o.Id = item.Id)
                    a.Status = "In storage"
                    a.TransactionId = ""
                    a.Condition = item.Condition
                    a.Inventory_location = item.Inventory_location


                    db.SubmitChanges()
                    createActionHistory("UpdateT", currentUser.Id, t.Id)
                Next
            End If
            MessageBox.Show("Assets Check In Successfully !", "Information")
            reset()
        ElseIf assetList.Count = 0 Then
            MessageBox.Show("No Asset To Check In !", "Error")
        End If
        UpdateTable()
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        If dgv.SelectedRows.Count > 0 Then
            Dim i As Integer
            i = dgv.CurrentRow.Index
            cboCondition.SelectedItem = dgv.Item(6, i).Value
            cboStatus.SelectedItem = dgv.Item(7, i).Value
            cboLocation.SelectedItem = dgv.Item(8, i).Value
            lblAssetId.Text = dgv.Item(0, i).Value
            lblDesc.Text = dgv.Item(1, i).Value
            lblModel.Text = dgv.Item(4, i).Value
            For Each a In db.Assets
                If a.Id.Equals(dgv.Item(0, i).Value) Then
                    picAssetProfile.Image = GetImage(a.Image.ToArray)
                End If
            Next
        End If
    End Sub

    Private Sub BtnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        If dgv.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows(i).Selected Then
                    For item As Integer = 0 To assetList.Count - 1
                        'if found then update the item
                        If assetList(item).Id = dgv.Item(0, i).Value Then
                            assetList(item).Condition = cboCondition.SelectedItem.ToString
                            assetList(item).Inventory_location = cboLocation.SelectedItem.ToString
                        End If
                    Next
                End If
            Next
        Else
            MessageBox.Show("No Record Selected !", "Error")
        End If


        UpdateTable()
        Reload()
    End Sub

    Private Sub CboReturnedBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReturnedBy.SelectedIndexChanged
        Select Case cboReturnedBy.SelectedItem
            Case "Local"
                tbc.TabPages(1).Enabled = True
                tbc.TabPages(2).Enabled = False

            Case "Third Party"
                tbc.TabPages(1).Enabled = False
                tbc.TabPages(2).Enabled = True
        End Select
    End Sub

    Private Sub Frm_TransactionCheckIn_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        assetList.Clear()
    End Sub
    Sub reset()
        txtStaffID.Text = ""
        txt3rdDesc.Text = ""
        picAssetProfile.Image = Nothing
        picStaffProfile.Image = Nothing
        lblAssetId.Text = ""
        lblContact.Text = ""
        lblDesc.Text = ""
        lblEmail.Text = ""
        lblModel.Text = ""
        lblName.Text = ""
        cboCondition.SelectedIndex = 0
        cboLocation.SelectedIndex = 0

    End Sub
    Function Reload()

    End Function
End Class