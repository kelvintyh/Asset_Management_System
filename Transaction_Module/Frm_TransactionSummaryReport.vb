Imports System.IO
Imports System.Text
Public Class Frm_TransactionSummaryReport


    Dim db As New AMSDBDataContext()
    Private Sub Doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        '(1) Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        '(2) Prepare header and sub-Header
        Dim header As String = "Asset Summary Report " & vbNewLine & dtpStart.Value.Date.Date & "To" & dtpEnd.Value.Date.Date
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by " & currentUser.Name & ", " & currentUser.Id, DateTime.Now
            )

        '(3) Prepare body
        Dim body As New StringBuilder()

        body.AppendLine("No   Asset ID     Asset Name   Acq. Date")
        body.AppendLine("--   ----------   ----------   ----------")

        'Dim rs = From a In db.Assets
        'Order By a.Asset_type

        Dim cnt As Integer = 0
        For Each a In db.Assets
            If a.Date_of_acquisition.Value.Date >= dtpStart.Value.Date And a.Date_of_acquisition.Value.Date <= dtpEnd.Value.Date Then
                cnt += 1
                body.AppendFormat("{0,2}   {1,10}   {2,-10}   {3, -10}" & vbNewLine, cnt, a.Id, a.Description, a.Date_of_acquisition.Value.Date.ToString("dd/mm/yyyy"))
            End If

        Next

        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        '(4) Print
        With e.Graphics
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        dlgPreview.Document = doc
        ' doc.PrinterSettings.PrintToFile
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        '(2) Prepare header and sub-Header
        Dim header As String = "Transaction Summary Report " & vbNewLine & dtpStart.Value.Date.Date & "To" & dtpEnd.Value.Date.Date
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by " & currentUser.Name & ", " & currentUser.Id, DateTime.Now
            )


        'Initialize the saveFileDialog
        With dlgSaveFile
            .InitialDirectory = Application.StartupPath
            .FileName = "Transaction Summary Report.txt"
            .Filter = "Text File | *.txt"
        End With

        'Open the SaveFileDialog
        Dim result As DialogResult = dlgSaveFile.ShowDialog(Me)

        'If a file is selected
        If result = DialogResult.OK Then
            Dim path As String = dlgSaveFile.FileName

            'write items to the file
            ' Open the file.
            Dim swReport As New StreamWriter(dlgSaveFile.FileName)
            swReport.WriteLine(header & vbNewLine & subHeader)
            swReport.WriteLine("No   Transaction ID   Transaction Date       ")
            swReport.WriteLine("--   --------------   --------------------   ----------")

            ' Save the items in the file.
            Dim cnt As Integer = 0
            For Each a In db.Assets
                If a.Date_of_acquisition.Value.Date >= dtpStart.Value.Date And a.Date_of_acquisition.Value.Date <= dtpEnd.Value.Date Then
                    cnt += 1
                    swReport.WriteLine("{0,2}   {1,10}   {2,-10}   {3, -10}" & vbNewLine, cnt, a.Id, a.Description, a.Date_of_acquisition.Value.Date.ToString("dd/mm/yyyy"))
                End If
            Next
            ' Close the file.
            swReport.Close()

        End If


    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub FrmAssetSummaryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
