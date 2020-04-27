Partial Public Class Asset
    Public Function Clone() As Asset
        Return DirectCast(Me.MemberwiseClone(), Asset)
    End Function
End Class
