Imports System.Text

Public Class Frm_WarrantyHome
    Dim db As New AMSDBDataContext()

    Private Sub Frm_Warranty_load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTable()
        SearchItem()
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click

        If dgv.SelectedRows.Count > 0 Then



            Dim q = MessageBox.Show("Are you sure to Delete this Data?", "Delete Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If q = DialogResult.Yes Then
                Dim db As New AMSDBDataContext()
                Dim w As Warranty = db.Warranties.FirstOrDefault(Function(o) o.Warranty_Id = dgv.Item(0, dgv.CurrentRow.Index).Value.ToString)
                db.Warranties.DeleteOnSubmit(w)
                db.SubmitChanges()
                UpdateTable()
                SearchItem()
                MessageBox.Show("Data deleted successfully", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                createActionHistory("DeleteW", currentUser.Id, w.Warranty_Id)

            End If
        Else
            MessageBox.Show("Please select a record to proceed !", "Information")
        End If
    End Sub

    Public Function UpdateTable()

        Dim db As New AMSDBDataContext()
        dgv.DataSource = db.Warranties
    End Function

    Public Sub SearchItem()
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

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        If dgv.SelectedRows.Count > 0 Then
            Frm_WarrantyUpdate.ShowDialog()

        Else
            MessageBox.Show("Please select a record to proceed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 16)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontFooter As New Font("Calibri", 12)

        Dim header As String = "Warranty"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMM-yyyy hh:mm:ss tt}" & vbNewLine, DateTime.Now)
        Dim footer As Integer = 0

        Dim body As New StringBuilder()
        body.AppendLine("Item ID       Name                Type                      Start Date     End Date      Status   ")
        body.AppendLine("=======       ==============      ======================    ==========     ==========    =======  ")

        Dim cnt As Integer = 0
        For Each a In dgv.SelectedRows
            Dim id As String = dgv.SelectedRows(cnt).Cells(0).Value
            Dim name As String = dgv.SelectedRows(cnt).Cells(1).Value
            Dim type As String = dgv.SelectedRows(cnt).Cells(2).Value
            Dim sdate As String = dgv.SelectedRows(cnt).Cells(3).Value
            Dim edate As String = dgv.SelectedRows(cnt).Cells(4).Value
            Dim status As String = dgv.SelectedRows(cnt).Cells(5).Value
            cnt += 1

            body.AppendFormat("{0,-13} {1,-19} {2,-25} {3,-14} {4,-13} {5,-15}" & vbNewLine, id, name, type, sdate, edate, status)
        Next a

        body.AppendLine()
        body.AppendLine()
        body.AppendFormat("{0,0} record(s)", cnt)


        With e.Graphics
            .DrawImage(My.Resources.logo, 20, 20, 120, 120)
            .DrawString(header, fontHeader, Brushes.DarkBlue, 150, 30)
            .DrawString(subHeader, fontSubHeader, Brushes.CornflowerBlue, 150, 70)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 20, 180)
            .DrawString("PAGE " & footer + 1, fontFooter, Brushes.Black, 700, 1100)
        End With
    End Sub

    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        If dgv.SelectedRows.Count > 0 Then
            PrintDialog.Document = PrintDocument
            PrintDialog.ShowDialog()
        Else
            MessageBox.Show("No data selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class