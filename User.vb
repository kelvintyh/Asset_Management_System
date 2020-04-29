Public Class User

    Public Sub New(id As String, name As String, username As String, password As String, gender As String, cont As String, email As String, profile As Byte(), role As String)
        Me.Id = id
        Me.Name = name
        Me.Username = username
        Me.Password = password
        Me.Gender = gender
        Me.Contact_number = cont
        Me.Email_address = email
        Me.Image = profile
        Me.Role = role
    End Sub
End Class
