Imports System.Text
Public Class Frm_WarrantyHome
    Dim db As New AMSDBDataContext()

    Private Sub Frm_Warranty_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        UpdateTable()

    End Sub

    Public Function UpdateTable()

        Dim db As New AMSDBDataContext()
        dgv.DataSource = db.Warranties
    End Function

    Private Sub SearchItem()
        Dim name As String = tbSearch.Text.Trim
        Dim id As String = tbSearch.Text.Trim

        Dim rs = From w In db.Warranties
                 Where w.Warranty_Id.Contains(id) Or
                     w.Warranty_Name.Contains(name) Or
                     tbSearch.Text = "Search with ID or Name"

        dgv.DataSource = rs

        lbCount.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        SearchItem()
    End Sub

    Private Sub tbSearch_MouseEnter(sender As Object, e As EventArgs) Handles tbSearch.GotFocus
        If tbSearch.Text = "Search with ID or Name" Then
            tbSearch.Text = ""
            tbSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbSearch_MouseLeave(sender As Object, e As EventArgs) Handles tbSearch.LostFocus
        If tbSearch.Text = "" Then
            tbSearch.Text = "Search with ID or Name"
            tbSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Frm_WarrantyAdd.ShowDialog()
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim w As Warranty = db.Warranties.FirstOrDefault(Function(o) o.Warranty_Id = dgv.Item(0, dgv.CurrentRow.Index).Value.ToString)
        Dim q = MessageBox.Show("Are you sure to Delete this Data?", "Delete Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If q = DialogResult.Yes Then
            db.Warranties.DeleteOnSubmit(w)
            db.SubmitChanges()
            UpdateTable()

        Else

        End If
    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        If dgv.SelectedRows.Count > 0 Then
            Frm_WarrantyUpdate.ShowDialog()
        Else
            MessageBox.Show("Please select a record to proceed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class