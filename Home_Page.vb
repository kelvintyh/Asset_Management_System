Imports System.Text

Public Class Home_Page



    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Frm_Date.ShowDialog()
        Dispose()
    End Sub
End Class