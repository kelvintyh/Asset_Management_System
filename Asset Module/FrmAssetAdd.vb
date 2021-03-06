﻿
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
        Dim binaryArray As Byte() = GetBinary(picAsset.Image, Nothing)


        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        'General Info
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
            db.Assets.InsertOnSubmit(a)
            db.SubmitChanges()
            MessageBox.Show("New Asset Record Added Successful !", "Information")
            Frm_AssetHome.UpdateTable()

            createActionHistory("CreateA", "U10001", a.Id)
            Me.Close()
        End If


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

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub



End Class