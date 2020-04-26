Imports System.Data.Linq
Imports System.IO
Imports System.Text

Public Class UserDetails

    Dim db As New AMSDBDataContext()

    Private Sub UserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboType.SelectedIndex = 0
        UpdateTable()
    End Sub

    Public Function UpdateTable()
        Dim id As String = txtSearch.Text
        Dim type As String = cboType.Text

        Dim rs = From o In db.ActionHistories
                 Where o.UserId.Contains(id) And
                     (type = "Type" Or o.Type.StartsWith(type))
                 Order By o.Date Descending
                 Select New With
                     {
                     .ID = o.Id,
                     o.Date,
                     o.Type,
                     o.Description,
                     .User_ID = o.UserId,
                     o.Device_Name,
                     o.MAC_Address,
                     o.IP_Address
                     }
        dgv.DataSource = rs
        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Function

    Private Sub CboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        UpdateTable()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        txtSearch.Text.ToUpper()
        UpdateTable()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgv.SelectedRows.Count > 0 Then
            ppd.Document = doc
            ppd.ShowDialog()
        Else
            MessageBox.Show("No data selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 16)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontFooter As New Font("Calibri", 12)

        Dim header As String = "Action History"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMM-yyyy hh:mm:ss tt}" & vbNewLine & "For Admin Use Only", DateTime.Now)
        Dim footer As Integer = 0

        Dim body As New StringBuilder()
        body.AppendLine("ID      Date       Type    Description User ID  Device Name  MAC Address          IP Address")
        body.AppendLine("--      ----       ----    ----------- -------  -----------  -----------          ----------")

        Dim cnt As Integer = 0
        For Each a In dgv.SelectedRows
            Dim id As String = dgv.SelectedRows(cnt).Cells(0).Value
            Dim date1 As String = dgv.SelectedRows(cnt).Cells(1).Value
            Dim type As String = dgv.SelectedRows(cnt).Cells(2).Value
            Dim des As String = dgv.SelectedRows(cnt).Cells(3).Value
            Dim userId As String = dgv.SelectedRows(cnt).Cells(4).Value
            Dim device As String = dgv.SelectedRows(cnt).Cells(5).Value
            Dim mac As String = dgv.SelectedRows(cnt).Cells(6).Value
            Dim ip As String = dgv.SelectedRows(cnt).Cells(7).Value
            cnt += 1

            body.AppendFormat("{0,-6} {1,-10} {2,-7} {3,-11} {4,-8} {5,-12} {6,-20} {7,-11}" & vbNewLine, id, date1, type, des, userId, device, mac, ip)
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
End Class