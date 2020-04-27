Imports System.Text
Public Class Frm_WarrantyUpdate


    Dim db As New AMSDBDataContext()
    Dim t As Integer = 0

    Private Sub ResetForm()
        tbName.Text = ""
        cboxType.SelectedItem = Nothing
        cboxStatus.SelectedItem = Nothing
        StartDate.ResetText()
        EndDate.ResetText()
        tbName.Focus()
        errReg.Clear()

    End Sub

    Private Sub Frm_WarrantyAdd_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim i = Frm_WarrantyHome.dgv.CurrentRow.Index

        For Each w In db.Warranties
            If w.Warranty_Id = Frm_WarrantyHome.dgv.Item(0, i).Value Then
                ItemID.Text = w.Warranty_Id
                tbName.Text = w.Warranty_Name
                cboxStatus.Text = w.Warranty_Status
                cboxType.Text = w.Warranty_Type
                StartDate.Value = w.Warranty_Start
                EndDate.Value = w.Warranty_End
            End If
        Next
    End Sub

    Private Sub WarrantyUpdateName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbName.Validating
        Dim name As String = tbName.Text.Trim

        If name = "" Then
            errReg.SetError(tbName, "Please enter a [Name]")
            e.Cancel = True
        Else
            errReg.SetError(tbName, Nothing)
        End If

    End Sub

    Private Sub WarrantyUpdateType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboxType.Validating
        Dim type As String = cboxType.Text.Trim

        If cboxType.Enabled = False Then
            errReg.SetError(cboxType, Nothing)
        ElseIf type = "" Then
            errReg.SetError(cboxType, "Please choose an [Option]")
            e.Cancel = True

        Else
            errReg.SetError(cboxType, Nothing)
        End If

    End Sub

    Private Sub WarrantyUpdateStatus_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboxStatus.Validating

        Dim status As String = cboxStatus.Text.Trim

        If status = "" Then
            errReg.SetError(cboxStatus, "Please choose an [Option]")
            e.Cancel = True
        Else
            errReg.SetError(cboxStatus, Nothing)
        End If

    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim w As Warranty = db.Warranties.FirstOrDefault(Function(o) o.Warranty_Id = ItemID.Text)
        Dim id As String = ItemID.Text
        Dim name As String = tbName.Text
        Dim type As String = cboxType.Text
        Dim status As String = cboxStatus.Text
        Dim startDate As String = Me.StartDate.Value
        Dim endDate As String = Me.EndDate.Value

        If cboxType.Enabled = False Then
            type = "Pending"
        End If

        w.Warranty_Id = id
        w.Warranty_Name = name
        w.Warranty_Type = type
        w.Warranty_Status = status
        w.Warranty_Start = startDate
        w.Warranty_End = endDate


        Dim r = MessageBox.Show("Are you sure to Update the record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If r = DialogResult.Yes Then
            db.SubmitChanges()
            MessageBox.Show("Record Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Frm_WarrantyHome.UpdateTable()
            createActionHistory("UpdateW", currentUser.Id, w.Warranty_Id)
            ResetForm()
            Me.Close()
        End If

    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Dim q = MessageBox.Show("Are you sure to Cancel Update?", "Cancel Update?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If q = DialogResult.Yes Then
            ResetForm()
            Me.Close()
        Else

        End If

    End Sub

    Private Sub cboxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxType.SelectedIndexChanged

        t = cboxType.SelectedIndex
        If t = 0 Then
            EndDate.Value = StartDate.Value.AddMonths(1)
        ElseIf t = 1 Then
            EndDate.Value = StartDate.Value.AddMonths(3)
        ElseIf t = 2 Then
            EndDate.Value = StartDate.Value.AddMonths(6)
        ElseIf t = 3 Then
            EndDate.Value = StartDate.Value.AddMonths(12)

        End If

        errReg.SetError(cboxType, Nothing)
    End Sub

    Private Sub cboxStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxStatus.SelectedIndexChanged

        If cboxStatus.SelectedItem = "Pending" Or Nothing Then
            cboxType.Enabled = False
            StartDate.ResetText()
            EndDate.ResetText()
            cboxType.SelectedItem = Nothing
            errReg.SetError(cboxType, Nothing)
        ElseIf cboxStatus.SelectedItem = "Active" Then

            cboxType.Enabled = True
        End If

    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        errReg.SetError(tbName, Nothing)
    End Sub
End Class