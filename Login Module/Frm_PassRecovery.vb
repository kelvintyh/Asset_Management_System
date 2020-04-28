Public Class Frm_PassRecovery

    Dim db As New AMSDBDataContext


    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim username As String = txtUser.Text
        Dim pass As String = txtPass.Text

        Dim u As User = db.Users.FirstOrDefault(Function(o) o.Username = username)

        If u Is Nothing Then
            MessageBox.Show("Record not found", "Validating Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUser.Text = ""
            txtPass.Text = ""
            txtPass1.Text = ""
        Else
            u.Password = pass
            db.SubmitChanges()
            createActionHistory("Recovery", currentUser.Id, u.Id)
            MessageBox.Show("Password updated", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUser.Text = ""
            txtPass.Text = ""
            txtPass1.Text = ""
        End If

    End Sub

    Private Sub TextUser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUser.Validating

        If txtUser.Text = "" Then
            err.SetError(txtUser, "Please enter your username")
            e.Cancel = True

        ElseIf IsValidatedId(txtUser.Text) Then
            err.SetError(txtUser, Nothing)
        Else
            err.SetError(txtUser, "Username is wrong")
            e.Cancel = True
        End If

    End Sub

    Private Function IsValidatedId(username As String) As Boolean

        Dim isV = db.Users.Any(Function(o) o.Username = username)

        If isV Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function IsDuplicatedPass(pass As String) As Boolean

        Dim isD = db.Users.Any(Function(o) o.Password = pass)

        If isD Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub TxtPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPass.Validating
        If txtPass.Text = "" Then
            err.SetError(txtPass, "Please enter your password")
            e.Cancel = True

        ElseIf IsDuplicatedPass(txtPass.Text) Then

            err.SetError(txtPass, "You have entered an old password")
            e.Cancel = True
        Else
            err.SetError(txtPass, Nothing)

        End If
    End Sub

    Private Sub TxtPass1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPass1.Validating
        If txtPass1.Text = "" Then
            err.SetError(txtPass1, "Please enter your password")
            e.Cancel = True
        ElseIf txtPass1.Text <> txtPass.Text Then
            err.SetError(txtPass1, "Please re-enter your password")
            e.Cancel = True
        Else
            err.SetError(txtPass1, Nothing)
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dispose()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUser.Text = ""
        txtPass.Text = ""
        txtPass1.Text = ""
    End Sub

    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles backB.Click
        If frm_LoginAdmin.count = 1 Then
            Me.Close()
            frm_LoginAdmin.Show()
        ElseIf frm_LoginAdmin.count = 2 Then
            Me.Close()
            Frm_LoginStaff.Show()
        End If

    End Sub
End Class