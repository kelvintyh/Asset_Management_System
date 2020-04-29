Public Class ActionHistory

    Public Sub New(id As String, type As String, desc As String, date1 As Date, userId As String, device As String, mac As String, ip As String)
        Me.Id = id
        Me.Type = type
        Me.Description = desc
        Me.Date = date1
        Me.UserId = userId
        Me.Device_Name = device
        Me.MAC_Address = mac
        Me.IP_Address = ip
    End Sub
End Class
