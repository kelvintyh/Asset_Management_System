Public Class LoginHistory

    Public Sub New(id As String, userid As String, name As String, role As String, dat As DateTime)
        Me.Id = id
        Me.UserId = userid
        Me.Name = name
        Me.Role = role
        Me.DateTime = dat
    End Sub
End Class
