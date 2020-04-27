Public Class Frm_CheckedIn_Item_List

    Dim db As New AMSDBDataContext()
    Private Sub Frm_CheckedIn_Item_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs = From a In db.Assets
                 Where a.Status.Equals("In storage")
        dgv.DataSource = rs
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click


        If dgv.SelectedRows.Count > 0 Then
            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows(i).Selected Then
                    Dim rs = From a In db.Assets
                             Where a.Id.Equals(dgv.Item(0, i).Value)
                    'Redundancy check
                    If Not IsDuplicated(rs.First.Id) Then
                        assetList.Add(rs.First.Clone)
                    End If
                    'Console.WriteLine(assetArray(i).Id)
                End If
            Next
        End If
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Function IsDuplicated(id As String) As Boolean
        For Each item In assetList
            If item.Id = id Then Return True
        Next
        Return False
    End Function
End Class