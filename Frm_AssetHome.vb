
Imports System.Data.Linq
Imports System.IO

Public Class Frm_AssetHome

    'declaration
    Dim db As New AMSDBDataContext()

    Private Sub Frm_AssetHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTable()
        dgv.ClearSelection()
        UpdateInfo()

    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        UpdateInfo()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim a As Asset = db.Assets.FirstOrDefault(Function(o) o.Id = dgv.Item(0, dgv.CurrentRow.Index).Value.ToString)
        db.Assets.DeleteOnSubmit(a)
        db.SubmitChanges()
        UpdateTable()
        UpdateInfo()
        MessageBox.Show("Asset Record Removed Successful !", "Information")
    End Sub

    Public Function UpdateTable()
        Dim db As New AMSDBDataContext()
        dgv.DataSource = db.Assets
        Return Nothing
    End Function

    Public Function UpdateInfo()
        If dgv.SelectedRows.Count > 0 Then
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
            For Each a In db.Assets
                If a.Id.Equals(dgv.Item(0, i).Value) Then
                    picAsset.Image = GetImage(a.Image.ToArray)
                End If
            Next
        Else
            lblId.Text = ""
            lblDesc.Text = ""
            lblManu.Text = ""
            lblType.Text = ""
            lblModel.Text = ""
            lblSerial.Text = ""
            lblCondition.Text = ""
            lblStatus.Text = ""
            lblLocation.Text = ""
            picAsset.Image = Nothing
        End If
        Return Nothing
    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmAssetAdd.ShowDialog()
    End Sub
End Class

