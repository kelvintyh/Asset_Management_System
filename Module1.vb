Imports System.Drawing.Imaging
Imports System.IO

Module Module1

    Dim ms As New System.IO.MemoryStream
    Dim db As New AMSDBDataContext()


    Public Function GetBinary(ByVal image As Image, ByVal format As ImageFormat) As Byte()
        If image IsNot Nothing Then
            If format Is Nothing Then
                format = image.RawFormat 'use image original format
            End If
            image.Save(ms, format)
            Return ms.ToArray()
        Else
            Return Nothing
        End If


    End Function

    Public Function GetImage(ByVal byteArray As Byte()) As Image
        ms = New MemoryStream(byteArray)
        Dim image As Image = Image.FromStream(ms)
        Return image
    End Function

    Public Function GetNextId(table As String) As String

        If table.Equals("Asset") Then
            Dim rs = From a In db.Assets
                     Order By a.Id Descending

            ' If the table is empty
            If rs.Count = 0 Then
                Return "A100001"
            Else
                Dim newid As Integer = Integer.Parse(rs.First.Id.Substring(2, 5))
                Return (newid + 1).ToString("A100000")
            End If
        End If
    End Function



End Module
