﻿Imports System.Text

Public Class FrmAssetUpdate

    Dim db As New AMSDBDataContext()

    Private Sub FrmAssetUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each a In db.Assets
            If a.Id = Frm_AssetHome.lblId.Text Then
                picAsset.Image = GetImage(a.Image.ToArray)
                lblId.Text = a.Id
                txtDesc.Text = a.Description
                cboManu.SelectedItem = a.Manufacturer
                cboType.SelectedItem = a.Asset_type
                txtModel.Text = a.Model
                txtSerial.Text = a.Serial_number
                cboCondition.SelectedItem = a.Condition
                cboLocation.SelectedItem = a.Inventory_location
                cboStatus.SelectedItem = a.Status
                txtVendor.Text = a.Vendor
                txtPrice.Text = Format(a.Value_At_Acquisition, "0.00")
                txtInvoice.Text = a.Invoice

                ''Check out to details

            End If
        Next
    End Sub

    Private Sub BtnManu_Click(sender As Object, e As EventArgs) Handles btnManu.Click, btnLocation.Click, btnType.Click
        Dim btn As Button = CType(sender, Button)

        Select Case btn.Tag
            Case "Manu"
                action_type = "Manufacturer"
                cbo_selection = If(IsNothing(cboManu.SelectedItem), "", cboManu.SelectedItem.ToString)
            Case "Type"
                action_type = "AssetType"
                cbo_selection = If(IsNothing(cboType.SelectedItem), "", cboType.SelectedItem.ToString)
            Case "Location"
                action_type = "Location"
                cbo_selection = If(IsNothing(cboLocation.SelectedItem), "", cboLocation.SelectedItem.ToString)
        End Select
        FrmAssetAddOthers.ShowDialog()
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            picAsset.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim a As Asset = db.Assets.FirstOrDefault(Function(o) o.Id = lblId.Text)
        'Get image from picAsset and GetBinary(use original format)
        Dim binaryArray As Byte() = If(IsNothing(GetBinary(picAsset.Image, Nothing)), Nothing, GetBinary(picAsset.Image, Nothing))


        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        'General Info
        a.Description = txtDesc.Text.Trim
        a.Model = txtModel.Text.Trim
        a.Serial_number = txtSerial.Text.Trim
        a.Manufacturer = If(IsNothing(cboManu.SelectedItem), "", cboManu.SelectedItem.ToString)
        a.Asset_type = If(IsNothing(cboType.SelectedItem), "", cboType.SelectedItem.ToString)
        a.Condition = If(IsNothing(cboCondition.SelectedItem), "", cboCondition.SelectedItem.ToString)
        a.Status = If(IsNothing(cboStatus.SelectedItem), "", cboStatus.SelectedItem.ToString)
        a.Inventory_location = If(IsNothing(cboLocation.SelectedItem), "", cboLocation.SelectedItem.ToString)
        a.Image = binaryArray

        'Purchase Info
        a.Date_of_acquisition = dtpDateOfAcquisition.Value.Date
        a.Vendor = txtVendor.Text.Trim
        Dim price As String = txtPrice.Text
        a.Invoice = txtInvoice.Text


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
        If a.Image.Length = 0 Then
            err.AppendLine("-Image empty")
        End If
        If IsNothing(a.Date_of_acquisition) Then
            err.AppendLine("-Date of acquisition empty")
        End If
        If price = "" Then
            err.AppendLine("-Value at acquisition empty")
        Else
            Try
                a.Value_At_Acquisition = Decimal.Parse(price)
            Catch ex As Exception
                err.AppendLine("-Invalid input for value at acquisition")
            End Try
        End If
        If a.Invoice = "" Then
            err.AppendLine("-Invoice empty")
        End If

        'Check If there Is input error, If no error then update database
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure to modify current record?", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                db.SubmitChanges()
                Frm_AssetHome.UpdateTable()
                MessageBox.Show("Update record " + a.Id + " Successful", "Information")
                Me.Close()
            End If
        End If

    End Sub
End Class