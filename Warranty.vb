Public Class Warranty
    Public Sub New(id As String, name As String, type As String, StartDate As DateTime, EndDate As DateTime, status As String)
        Me.Warranty_Id = id
        Me.Warranty_Name = name
        Me.Warranty_Type = type
        Me.Warranty_Start = StartDate
        Me.Warranty_End = EndDate
        Me.Warranty_Status = status
    End Sub
End Class
