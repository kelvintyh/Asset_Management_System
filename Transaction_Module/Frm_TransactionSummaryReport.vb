Imports System.IO
Imports System.Text
Public Class Frm_TransactionSummaryReport


    Dim db As New AMSDBDataContext()
    Private Sub Doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage

        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)


        Dim header As String = "Asset Summary Report " & vbNewLine & dtpStart.Value.Date.Date & "To" & dtpEnd.Value.Date.Date
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by " & currentUser.Name & ", " & currentUser.Id, DateTime.Now
            )


        Dim body As New StringBuilder()

        body.AppendLine("No   Transaction ID   Asset ID      Transaction Date       ")
        body.AppendLine("--   --------------   -----------   ----------------")



        Dim cnt As Integer = 0
        For Each a In db.Transactions
            If a.Transaction_Date.Value.Date >= dtpStart.Value.Date And a.Transaction_Date.Value.Date <= dtpEnd.Value.Date Then
                cnt += 1
                body.AppendFormat("{0,2}   {1,10}   {2,12}   {3, 15}" & vbNewLine, cnt, a.Id, a.Asset_Id, a.Transaction_Date.Value.Date.ToString("dd/mm/yyyy"))
            End If

        Next

        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)


        With e.Graphics
            .DrawImage(GetImage(currentUser.Image.ToArray), 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        dlgPreview.Document = doc

        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        Dim header As String = "Transaction Summary Report " & vbNewLine & dtpStart.Value.Date.Date & "To" & dtpEnd.Value.Date.Date
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by " & currentUser.Name & ", " & currentUser.Id, DateTime.Now
            )



        With dlgSaveFile
            .InitialDirectory = Application.StartupPath
            .FileName = "Transaction Summary Report.txt"
            .Filter = "Text File | *.txt"
        End With


        Dim result As DialogResult = dlgSaveFile.ShowDialog(Me)


        If result = DialogResult.OK Then
            Dim path As String = dlgSaveFile.FileName


            Dim swReport As New StreamWriter(dlgSaveFile.FileName)
            swReport.WriteLine(header & vbNewLine & subHeader)
            swReport.WriteLine("No   Transaction ID   Transaction Date       ")
            swReport.WriteLine("--   --------------   --------------------   ----------")


            Dim cnt As Integer = 0
            For Each a In db.Assets
                If a.Date_of_acquisition.Value.Date >= dtpStart.Value.Date And a.Date_of_acquisition.Value.Date <= dtpEnd.Value.Date Then
                    cnt += 1
                    swReport.WriteLine("{0,2}   {1,10}   {2,-10}   {3, -10}" & vbNewLine, cnt, a.Id, a.Description, a.Date_of_acquisition.Value.Date.ToString("dd/mm/yyyy"))
                End If
            Next

            swReport.Close()

        End If


    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Frm_TransactionSummaryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
