Imports System.Text

Public Class Frm_WarrantyAdd
    Dim db As New AMSDBDataContext()
    Dim t As Integer = 0

    Private Sub ResetForm()
        tbRegName.Text = ""
        cboxRegType.SelectedItem = Nothing
        cboxRegStatus.SelectedItem = Nothing
        RegStartDate.ResetText()
        RegEndDate.ResetText()
        tbRegName.Focus()
        errReg.Clear()

    End Sub

    Private Sub Frm_WarrantyAdd_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()
        ItemRegID.Text = GetNextId("Warranty")

    End Sub

    Private Sub WarrantyRegistrationName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbRegName.Validating
        Dim name As String = tbRegName.Text.Trim

        If name = "" Then
            errReg.SetError(tbRegName, "Please enter a [Name]")
            e.Cancel = True
        Else
            errReg.SetError(tbRegName, Nothing)
        End If

    End Sub

    Private Sub WarrantyRegistrationType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboxRegType.Validating
        Dim type As String = cboxRegType.Text.Trim

        If cboxRegType.Enabled = False Then
            errReg.SetError(cboxRegType, Nothing)
        ElseIf type = "" Then
            errReg.SetError(cboxRegType, "Please choose an [Option]")
            e.Cancel = True

        Else
            errReg.SetError(cboxRegType, Nothing)
        End If

    End Sub

    Private Sub WarrantyRegistrationStatus_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboxRegStatus.Validating

        Dim status As String = cboxRegStatus.Text.Trim

        If status = "" Then
            errReg.SetError(cboxRegStatus, "Please choose an [Option]")
            e.Cancel = True
        Else
            errReg.SetError(cboxRegStatus, Nothing)
        End If

    End Sub

    Private Sub btRegister_Click(sender As Object, e As EventArgs) Handles btRegister.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim w As New Warranty()
        Dim id As String = ItemRegID.Text
        Dim name As String = tbRegName.Text
        Dim type As String = cboxRegType.Text
        Dim status As String = cboxRegStatus.Text
        Dim startDate As String = RegStartDate.Value
        Dim endDate As String = RegEndDate.Value

        If cboxRegType.Enabled = False Then
            type = "Pending"
        End If

        w.Warranty_Id = id
        w.Warranty_Name = name
        w.Warranty_Type = type
        w.Warranty_Status = status
        w.Warranty_Start = startDate
        w.Warranty_End = endDate

        db.Warranties.InsertOnSubmit(w)
        db.SubmitChanges()
        MessageBox.Show("Record Registered Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Frm_WarrantyHome.UpdateTable()
        createActionHistory("CreateW", currentUser.Id, w.Warranty_Id)
        ResetForm()
        Me.Close()

    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Dim q = MessageBox.Show("Are you sure to Cancel Registration?", "Cancel Registration?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If q = DialogResult.Yes Then
            ResetForm()
            Me.Close()
        Else

        End If

    End Sub

    Private Sub cboxRegType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxRegType.SelectedIndexChanged

        t = cboxRegType.SelectedIndex
        If t = 0 Then
            RegEndDate.Value = RegStartDate.Value.AddMonths(1)
        ElseIf t = 1 Then
            RegEndDate.Value = RegStartDate.Value.AddMonths(3)
        ElseIf t = 2 Then
            RegEndDate.Value = RegStartDate.Value.AddMonths(6)
        ElseIf t = 3 Then
            RegEndDate.Value = RegStartDate.Value.AddMonths(12)

        End If

        errReg.SetError(cboxRegType, Nothing)
    End Sub

    Private Sub cboxRegStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxRegStatus.SelectedIndexChanged

        If cboxRegStatus.SelectedItem = "Pending" Or Nothing Then
            cboxRegType.Enabled = False
            RegStartDate.ResetText()
            RegEndDate.ResetText()
            cboxRegType.SelectedItem = Nothing
            errReg.SetError(cboxRegType, Nothing)
        ElseIf cboxRegStatus.SelectedItem = "Active" Then

            cboxRegType.Enabled = True
        End If

    End Sub

    Private Sub tbRegName_TextChanged(sender As Object, e As EventArgs) Handles tbRegName.TextChanged
        errReg.SetError(tbRegName, Nothing)
    End Sub
End Class