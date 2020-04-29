Public Class Asset
    Private v As String

    Public Sub New(id As String, desc As String, manu As String, type As String, model As String, serial As String, condition As String, status As String, location As String, image As Byte(), doc As DateTime, vendor As String, vaa As Decimal, invoice As String, warrantyId As String, transactionId As String)
        Me.Id = id
        Me.Description = desc
        Me.Manufacturer = manu
        Me.Asset_type = type
        Me.Model = model
        Me.Serial_number = serial
        Me.Condition = condition
        Me.Status = status
        Me.Inventory_location = location
        Me.Image = image
        Me.Date_of_acquisition = doc
        Me.Vendor = vendor
        Me.Value_At_Acquisition = vaa
        Me.Invoice = invoice
        Me.WarrantyId = warrantyId
        Me._TransactionId = transactionId

    End Sub

    Public Function Clone() As Asset
        Return DirectCast(Me.MemberwiseClone(), Asset)
    End Function

End Class
