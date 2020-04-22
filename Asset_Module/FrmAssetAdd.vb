
Imports System.Text

Public Class FrmAssetAdd

    Dim db As New AMSDBDataContext()

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            picAsset.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub FrmAssetAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'get new id
        lblId.Text = GetNextId("Asset")
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim a As New Asset()
        'Get image from picAsset and GetBinary(use original format)
        Dim binaryArray As Byte() = If(IsNothing(GetBinary(picAsset.Image, Nothing)), Nothing, GetBinary(picAsset.Image, Nothing))


        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        a.Id = GetNextId("Asset")
        a.Description = txtDesc.Text.Trim
        a.Model = txtModel.Text.Trim
        a.Serial_number = txtSerial.Text.Trim
        a.Manufacturer = If(IsNothing(cboManu.SelectedItem), "", cboManu.SelectedItem.ToString)
        a.Asset_type = If(IsNothing(cboType.SelectedItem), "", cboType.SelectedItem.ToString)
        a.Condition = If(IsNothing(cboCondition.SelectedItem), "", cboCondition.SelectedItem.ToString)
        a.Status = If(IsNothing(cboStatus.SelectedItem), "", cboStatus.SelectedItem.ToString)
        a.Inventory_location = If(IsNothing(cboLocation.SelectedItem), "", cboLocation.SelectedItem.ToString)
        a.Image = binaryArray

        '(3) Validate empty input
        If a.Description = "" Then
            err.AppendLine("-Description empty")
        End If

        If a.Model = "" Then
            err.AppendLine("-Model empty")
        End If

        If a.Serial_number = "" Then
            err.AppendLine("-Serial Number empty")
        End If

        If a.Manufacturer = "" Then
            err.AppendLine("-Manufacturer empty")
        End If
        If a.Asset_type = "" Then
            err.AppendLine("-Asset Type empty")
        End If
        If a.Condition = "" Then
            err.AppendLine("-Condtion empty")
        End If
        If a.Status = "" Then
            err.AppendLine("-Status empty")
        End If
        If a.Inventory_location = "" Then
            err.AppendLine("-Inventory Location empty")
        End If
        Console.WriteLine(a.Image.Length)
        If a.Image.Length = 0 Then
            err.AppendLine("-Image empty")
        End If

        'Check if there is input error, if no error then update database
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
        Else
            db.Assets.InsertOnSubmit(a)
            db.SubmitChanges()
            MessageBox.Show("New Asset Record Added Successful !", "Information")
            Frm_AssetHome.UpdateTable()
            Me.Close()
        End If


    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class