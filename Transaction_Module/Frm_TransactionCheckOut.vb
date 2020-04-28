Imports System.ComponentModel
Imports System.Text

Public Class Frm_TransactionCheckOut

    Dim valid As Boolean
    Private Sub Frm_TransactionCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'default selected 
        cboTransactionType.SelectedItem = "Checked out"
        cboCheckOutTo.SelectedIndex = 0
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Frm_CheckedIn_Item_List.ShowDialog()
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


    Private Sub BtnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click



        If cboCheckOutTo.SelectedIndex = 1 Then

            Dim err As New StringBuilder()
            Console.WriteLine("hahaha")

            Dim desc = txt3rdDesc.Text.Trim
            Dim contact = txt3rdContact.Text.Trim
            Dim email = txt3rdEmail.Text.Trim


            If desc = "" Then
                err.AppendLine("-Third Party Description empty")
            End If

            If contact = "" Then
                err.AppendLine("-Third Party Contact empty")
            End If

            If email = "" Then
                err.AppendLine("-Third Party Email empty")
            End If

            If assetList.Count = 0 Then
                err.AppendLine("-No Asset To Check Out")
            End If



            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error")
                Return
            Else
                valid = True
            End If


        Else
            BtnSearch_Click(Nothing, Nothing)

        End If

        Dim count As Integer = 0
        Dim msg As New StringBuilder()
        msg.AppendLine("Are you sure to Check out :")
        For Each item In assetList
            msg.AppendLine(count & ". " & item.Id & vbTab & item.Description)
        Next
        msg.AppendLine(vbNewLine & "to " & txtStaffID.Text & "  " & lblName.Text)
        If valid = True And assetList.Count <> 0 Then
            Dim result As DialogResult = MessageBox.Show(msg.ToString, "Information", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                For Each item In assetList


                    Dim t As New Transaction()
                    t.Id = GetNextId("Transaction")
                    t.Transaction_Type = cboTransactionType.SelectedItem.ToString
                    t.Transaction_Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    t.Asset_Id = item.Id
                    t.Check_Out_To = If(txtStaffID.Text <> "", txtStaffID.Text, "")
                    t.Check_Out_Type = If(cboCheckOutTo.SelectedIndex = 0, "Local", "Third Party")
                    t.Return_Due_Date = dtp.Value.Date
                    t.Third_Party_Description = txt3rdDesc.Text
                    t.Third_Party_Contact = txt3rdContact.Text
                    t.Third_Party_Email = txt3rdEmail.Text
                    t.Status = "Out"
                    t.Notes = If(t.Transaction_Type = "Check out", txtNotes.Text, txt3thNotes.Text)
                    db.Transactions.InsertOnSubmit(t)


                    Dim a As Asset = db.Assets.FirstOrDefault(Function(o) o.Id = item.Id)
                    a.Status = t.Transaction_Type
                    a.TransactionId = t.Id


                    db.SubmitChanges()
                    createActionHistory("CreateT", currentUser.Id, t.Id)
                Next
            End If
            MessageBox.Show("Assets Check Out Successfully !", "Information")
        Else
            MessageBox.Show("No Asset To Check Out !", "Error")
        End If
        UpdateTable()
        Reload()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        Dim rs = From u In db.Users
                 Where u.Id.Equals(txtStaffID.Text.Trim)
        Try
            Try
                picProfile.Image = GetImage(rs.First.Image.ToArray)
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


    Private Sub Frm_TransactionCheckOut_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        UpdateTable()
    End Sub

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

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CboCheckOutTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCheckOutTo.SelectedIndexChanged
        Select Case cboCheckOutTo.SelectedItem
            Case "Local"
                tbc.TabPages(0).Enabled = True
                tbc.TabPages(1).Enabled = False
                txt3rdDesc.Text = ""
                txt3rdContact.Text = ""
                txt3rdEmail.Text = ""
                txt3thNotes.Text = ""
            Case "Third Party"
                tbc.TabPages(0).Enabled = False
                tbc.TabPages(1).Enabled = True
                txtStaffID.Text = ""
                picProfile.Image = Nothing
                lblContact.Text = ""
                lblEmail.Text = ""
                lblName.Text = ""
        End Select
    End Sub

    Private Sub Frm_TransactionCheckOut_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        assetList.Clear()
    End Sub

    Function Reload()


    End Function
End Class