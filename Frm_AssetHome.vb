
Imports System.Data.Linq
Imports System.IO

Public Class Frm_AssetHome

    'declaration
    Dim db As New AMSDBDataContext()

    Private Sub Frm_AssetHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    End If
                Next
                dtpDateOfAcquisition.Value = dgv.Item(10, i).Value
            Catch ex As Exception
                'handle empty date 
                dtpDateOfAcquisition.CustomFormat = " "
                dtpDateOfAcquisition.Format = DateTimePickerFormat.Custom
            End Try
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

    Private Sub AssetSummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssetSummaryReportToolStripMenuItem.Click
        FrmAssetSummaryReport.ShowDialog()
    End Sub

    Private Sub LoginHistorySummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginHistorySummaryReportToolStripMenuItem.Click
        Frm_Date.ShowDialog()

    End Sub
End Class

