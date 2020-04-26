Public Class Frm_CheckedIn_Item_List

    Dim db As New AMSDBDataContext()
    Private Sub Frm_CheckedIn_Item_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs = From a In db.Assets
                 Where a.Status.Equals("In Storage")
        dgv.DataSource = rs
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If dgv.SelectedRows.Count > 0 Then
            For Each row In dgv.SelectedRows

            Next
        End If

    End Sub
End Class