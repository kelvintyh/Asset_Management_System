Public Class Transaction

    Public Sub New(id As String, type As String, tdate As DateTime, assetId As String, cot As String, cib As String, coty As String, city As String, rdd As Date, ard As Date, rddesc As String, rdcontact As String, rdemail As String, note As String, status As String)
        Me.Id = id
        Me.Transaction_Type = type
        Me.Transaction_Date = tdate
        Me.Asset_Id = assetId
        Me.Check_Out_To = cot
        Me.Check_In_By = cib
        Me.Check_In_Type = coty
        Me.Check_Out_Type = city
        Me.Return_Due_Date = rdd
        Me.Actual_Return_Date = ard
        Me.Third_Party_Description = rddesc
        Me.Third_Party_Contact = rdcontact
        Me.Third_Party_Email = rdemail
        Me.Notes = note
        Me.Status = status
    End Sub
End Class
