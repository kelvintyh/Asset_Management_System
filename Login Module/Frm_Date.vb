Imports System.Text

Public Class Frm_Date

    Dim db As New AMSDBDataContext()
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub Doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim fontHeader As New Font("Georgia", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Georgia", 12)
        Dim fontBody As New Font("Consola", 10)
        Dim fontFooter As New Font("Georgia", 12)

        Dim u As User = db.Users.FirstOrDefault(Function(o) o.Id = frm_LoginAdmin.uid)


        Dim month As String = MCalendar.SelectionRange.Start.ToShortDateString


        Dim subHeader As String = String.Format("Based on" & " " & month & vbNewLine & "Generated on {0:dd-MMMM-yyyy hh:mm:ss}" & vbNewLine & "Prepared by" & " " & u.Name, DateTime.Now)

        Dim header As String = "Login History Summary Report"
        Dim footer As Integer = 0

        Dim body As New StringBuilder()

        body.AppendLine("No      ID            UserID          Name             Role           Login Time")
        body.AppendLine("---       ---             --------           --------            -------           ----------------")

        Dim cnt As Integer = 0I

        For Each l In db.LoginHistories
            If l.DateTime.Value.Date = month Then
                cnt += 1
                body.AppendFormat("{0,2}  {1,11}  {2,10}       {3,-5}  {4,15}         {5,15}" & vbNewLine,
                                      cnt, l.Id, l.UserId, l.Name, l.Role, String.Format("{0:dd-MMMM-yyyy hh:mm:ss}", l.DateTime))
            End If


        Next

        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.jupiter_asset_management, 0, 0, 100, 100)
            .DrawString(header, fontHeader, Brushes.Black, 150, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 150, 40)
            .DrawString(body.ToString, fontBody, Brushes.Black, 0, 120)
            .DrawString("PAGE " & footer + 1, fontFooter, Brushes.Black, 700, 1100)
        End With
    End Sub
End Class