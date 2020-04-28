
Imports System.Data.Linq
Imports System.IO

Public Class Frm_AssetHome

    'declaration
    Dim db As New AMSDBDataContext()

    Private Sub Frm_AssetHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initiateData()
        frm_LoginAdmin.Visible = False
        Frm_LoginStaff.Visible = False
        grpLocal.Visible = False
        grpThirdParty.Visible = False

        'check whether is admin or staff
        If Not currentUser.Role.ToUpper.Equals("ADMIN") Then
            For Each item As ToolStripMenuItem In msp.Items
                If item.Name = "mnuView" Then
                    For Each i As ToolStripMenuItem In item.DropDownItems
                        If i.Name = "mnuViewActionHistory" Then
                            i.Visible = False
                        End If
                    Next
                End If
            Next
        End If
        'fill the combo box
        GetManu()
        GetLocation()
        GetAssetType()
        'fill the dgv
        UpdateTable()
        dgv.ClearSelection()
        UpdateInfo()

    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        UpdateInfo()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgv.SelectedRows.Count > 0 Then


            Dim result As DialogResult = MessageBox.Show("Are you sure to delete selected record?", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Dim a As Asset = db.Assets.FirstOrDefault(Function(o) o.Id = dgv.Item(0, dgv.CurrentRow.Index).Value.ToString)
                db.Assets.DeleteOnSubmit(a)
                db.SubmitChanges()
                UpdateTable()
                UpdateInfo()
                MessageBox.Show("Asset Record Removed Successful !", "Information")
            End If
        Else
            MessageBox.Show("Please select a record to proceed !", "Information")
        End If

    End Sub

    Public Function UpdateTable()
        Dim db As New AMSDBDataContext()
        dgv.DataSource = db.Assets
    End Function

    Public Function UpdateInfo()

        Dim db As New AMSDBDataContext()
        If dgv.SelectedRows.Count > 0 Then
            'validation
            Try
                Dim i As Integer
                i = dgv.CurrentRow.Index
                lblId.Text = dgv.Item(0, i).Value
                lblDesc.Text = dgv.Item(1, i).Value
                lblManu.Text = dgv.Item(2, i).Value
                lblType.Text = dgv.Item(3, i).Value
                lblModel.Text = dgv.Item(4, i).Value
                lblSerial.Text = dgv.Item(5, i).Value
                lblCondition.Text = dgv.Item(6, i).Value
                lblStatus.Text = dgv.Item(7, i).Value
                lblLocation.Text = dgv.Item(8, i).Value
                lblVendor.Text = dgv.Item(11, i).Value
                lblPrice.Text = Format(dgv.Item(12, i).Value, "RM 0.00")
                lblInvoice.Text = dgv.Item(13, i).Value
                lblWarrantyId.Text = dgv.Item(14, i).Value
                'lblWarrantyExpDate.Text = dgv.Item(16, i).Value
                For Each a In db.Assets
                    If a.Id.Equals(dgv.Item(0, i).Value) Then
                        picAsset.Image = GetImage(a.Image.ToArray)
                    Else
                        'picAsset.Image = My.Resources.Picture_50px
                    End If
                Next
                dtpDateOfAcquisition.Value = dgv.Item(10, i).Value
            Catch ex As Exception
                'handle empty date 
                dtpDateOfAcquisition.CustomFormat = " "
                dtpDateOfAcquisition.Format = DateTimePickerFormat.Custom
            End Try


            Dim rs = From o In db.Transactions
                     Where o.Asset_Id = lblId.Text

            dgvTransactionLog.DataSource = rs

            ''Check out to details
            Dim rs_2 = From o In db.Assets
                       Where o.Id = lblId.Text

            Console.WriteLine(rs_2.Count)
            If rs_2.Count <> 0 Then
                If rs_2.First.TransactionId <> "" Then
                    Dim rs_3 = From o In db.Transactions
                               Where o.Id.Equals(rs_2.First.TransactionId)
                    If rs.First.Check_Out_Type = "Local" Then
                        grpLocal.Visible = True
                        grpThirdParty.Visible = False
                        txtId.Text = rs.First.Check_Out_To
                        Dim rs_4 = From o In db.Users
                                   Where o.Id.Equals(rs.First.Check_Out_To)
                        Try
                            picCOT.Image = GetImage(rs_2.First.Image.ToArray)
                        Catch ex As Exception

                        End Try

                        lblName.Text = rs_4.First.Name
                        lblContact.Text = rs_4.First.Contact_number
                    Else
                        grpThirdParty.Visible = True
                        grpLocal.Visible = False

                        txt3rdDesc.Text = rs.First.Third_Party_Description
                        txt3rdContact.Text = rs.First.Third_Party_Contact
                        txt3rdEmail.Text = rs.First.Third_Party_Email
                    End If
                Else
                    grpLocal.Visible = False
                    grpThirdParty.Visible = False
                End If
            End If


        End If
    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmAssetAdd.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgv.SelectedRows.Count > 0 Then
            FrmAssetUpdate.ShowDialog()
        Else
            MessageBox.Show("Please select a record to proceed !", "Information")
        End If

    End Sub

    Private Sub DtpDateOfAcquisition_ValueChanged(sender As Object, e As EventArgs)
        dtpDateOfAcquisition.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub AssetSummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileReportASR.Click
        FrmAssetSummaryReport.ShowDialog()
    End Sub

    Private Sub BtnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Frm_TransactionCheckIn.ShowDialog()
    End Sub

    Private Sub BtnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Frm_TransactionCheckOut.ShowDialog()
    End Sub

    Private Sub Frm_AssetHome_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateTable()
        UpdateInfo()
    End Sub

    Private Sub MnuViewWarranty_Click(sender As Object, e As EventArgs) Handles mnuViewWarranty.Click
        Frm_WarrantyHome.ShowDialog()
    End Sub

    Private Sub MnuViewActionHistory_Click(sender As Object, e As EventArgs) Handles mnuViewActionHistory.Click
        UserDetails.ShowDialog()
    End Sub

    Private Sub MnuTransactionSummaryReport_Click(sender As Object, e As EventArgs) Handles mnuTransactionSummaryReport.Click
        Frm_TransactionSummaryReport.ShowDialog()
    End Sub
End Class

