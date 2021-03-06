﻿Imports System.Text

Public Class FrmAssetAddOthers

    Dim db As New AMSDBDataContext()

    Private Sub FrmAssetAddOthers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This form tried to combine create and update function 
        'for three table which are AssetType, Manufacturer and Location 
        'in one single form using the global variable = action_type 
        'action_type = 1.AssetType 2.Manufacturer 3.Location 


        lblId.Text = GetNextId(action_type) 'Get the lastest ID 
        UpdateTable() ' Update the table from database

        'show the dialog box for user guideline
        ShowUserGuideline()


        'Get the selected item from the previous combo and put here
        For i As Integer = 0 To dgv.Rows.Count - 2

            Console.WriteLine("haha")
            If dgv.Item(1, i).Value.ToString = cbo_selection Then
                dgv.Rows(i).Selected = True
                lblId.Text = dgv.Item(0, i).Value.ToString
                txtName.Text = dgv.Item(1, i).Value.ToString

                Console.WriteLine("haha")
                'Set the button mode
                If txtName.Text = "" Then
                    btnSave.Text = "&Add"
                Else
                    btnSave.Text = "&Save"
                End If

            End If
        Next


    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        If dgv.Item(0, dgv.CurrentRow.Index).Value = Nothing Then

            'if empty record selected, change the button to add mode
            btnSave.Text = "&Add"
            'generate new id
            lblId.Text = GetNextId(action_type)
            'clear txtname
            txtName.Text = ""
        Else
            Dim i As Integer = dgv.CurrentRow.Index
            lblId.Text = dgv.Item(0, i).Value
            txtName.Text = dgv.Item(1, i).Value

            'if any record selected, change the button to save mode
            btnSave.Text = "&Save"
        End If

    End Sub

    Public Function UpdateTable()

        Dim db As New AMSDBDataContext()

        'Update table based on variable action_type 
        If action_type = "AssetType" Then
            dgv.DataSource = db.AssetTypes

        ElseIf action_type = "Manufacturer" Then
            dgv.DataSource = db.Manufacturers

        ElseIf action_type = "Location" Then
            dgv.DataSource = db.InventoryLocations

        End If
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        'General Info
        Dim id As String = lblId.Text
        Dim name As String = txtName.Text.Trim

        '(3) Validate empty input
        If name = "" Then
            err.AppendLine("-Name empty")
        End If

        'Check if there is input error, if no error then update database
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
        Else

            '(A) Add new record 
            If btnSave.Text = "&Add" Then
                Console.WriteLine("hahah" + id)
                If action_type = "AssetType" Then
                    Dim data As New AssetType()
                    data.Id = id
                    data.Description = name
                    db.AssetTypes.InsertOnSubmit(data)
                    MessageBox.Show("Create New Asset Type Successful", "Information")

                ElseIf action_type = "Manufacturer" Then
                    Dim data As New Manufacturer()
                    data.Id = id
                    data.Name = name
                    db.Manufacturers.InsertOnSubmit(data)
                    MessageBox.Show("Create New Manufacturer Successful", "Information")

                ElseIf action_type = "Location" Then
                    Dim data As New InventoryLocation()
                    data.Id = id
                    data.Name_ = name
                    db.InventoryLocations.InsertOnSubmit(data)
                    MessageBox.Show("Create New Inventory Location Successful", "Information")
                End If
                '(A.1)Update the database
                db.SubmitChanges()

                '(A.2)Update new Id
                lblId.Text = GetNextId(action_type)


                '(B) Modify current record

            ElseIf btnSave.Text = "&Save" Then

                If Not lblId.Text = "" Then
                    'Confirmation massage
                    Dim result As DialogResult = MessageBox.Show("Are you sure to modify current record?", "", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then
                        If action_type = "AssetType" Then
                            Dim data As AssetType = db.AssetTypes.FirstOrDefault(Function(o) o.Id = id)
                            data.Description = name
                            MessageBox.Show("Update record " + id + " Successful", "Information")


                        ElseIf action_type = "Manufacturer" Then
                            Dim data As Manufacturer = db.Manufacturers.FirstOrDefault(Function(o) o.Id = id)
                            data.Name = name
                            MessageBox.Show("Update record " + id + " Successful", "Information")

                        ElseIf action_type = "Location" Then
                            Dim data As InventoryLocation = db.InventoryLocations.FirstOrDefault(Function(o) o.Id = id)
                            data.Name_ = name
                            MessageBox.Show("Update record " + id + " Successful", "Information")
                        End If
                        '(B.1)Update the database
                        db.SubmitChanges()
                    End If
                End If

            End If
        End If
        '(4) Update the table...
        UpdateTable()
        txtName.Text = ""

        '(5)Update combo box
        GetManu()
        GetLocation()
        GetAssetType()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick

        'To remove record from database
        Dim result As DialogResult = MessageBox.Show("Are you sure to delete selected record?", "", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            If action_type = "AssetType" Then
                Dim data As AssetType = db.AssetTypes.FirstOrDefault(Function(o) o.Id = dgv.Item(0, dgv.CurrentRow.Index).Value.ToString)
                db.AssetTypes.DeleteOnSubmit(data)

            ElseIf action_type = "Manufacturer" Then
                Dim data As Manufacturer = db.Manufacturers.FirstOrDefault(Function(o) o.Id = dgv.Item(0, dgv.CurrentRow.Index).Value.ToString)
                db.Manufacturers.DeleteOnSubmit(data)

            ElseIf action_type = "Location" Then
                Dim data As InventoryLocation = db.InventoryLocations.FirstOrDefault(Function(o) o.Id = dgv.Item(0, dgv.CurrentRow.Index).Value.ToString)
                db.InventoryLocations.DeleteOnSubmit(data)
            End If
            MessageBox.Show("Record Removed Successful !", "Information")
        End If
        db.SubmitChanges()

        'Update table...
        UpdateTable()
        Dgv_CellClick(Nothing, Nothing)
        txtName.Text = ""

        'Update combo box
        GetManu()
        GetLocation()
        GetAssetType()



    End Sub

    Function ShowUserGuideline()
        Dim msg As New StringBuilder()
        msg.AppendLine("-----------------User Guideline-----------------" & vbNewLine)
        msg.AppendLine("            1. TO ADD NEW RECORD")
        msg.AppendLine("-1.1.Click on empty rows or column in the table")
        msg.AppendLine("-1.2.Save button change to Add button")
        msg.AppendLine("-1.3.Insert Description or Name in the textbox")
        msg.AppendLine("-1.4.Click the Add button to add new record")
        msg.AppendLine("-1.5.System will prompt appropriate message" & vbNewLine)
        msg.AppendLine("            2. TO REMOVE A RECORD")
        msg.AppendLine("-2.1.Double Click the desire record in the table")
        msg.AppendLine("-2.2.System will prompt confirmation message" & vbNewLine)
        msg.AppendLine("            3. TO MODIFY A RECORD")
        msg.AppendLine("-3.1.Click on the desire row")
        msg.AppendLine("-3.1.Add button change to Save button")
        msg.AppendLine("-3.3.Modify Description or Name in the textbox")
        msg.AppendLine("-3.4.Click the Save button to save the record")
        msg.AppendLine("-3.5.System will prompt appropriate message" & vbNewLine)

        MessageBox.Show(msg.ToString(), "User Guideline")
    End Function

    Private Sub MnuHelpUserGuideline_Click(sender As Object, e As EventArgs) Handles mnuHelpUserGuideline.Click
        ShowUserGuideline()
    End Sub

    Private Sub FrmAssetAddOthers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtName.Text = ""
    End Sub
End Class