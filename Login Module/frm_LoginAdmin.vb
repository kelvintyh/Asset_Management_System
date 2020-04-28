
Imports System.Globalization

Public Class frm_LoginAdmin

    Dim db As New AMSDBDataContext()
    Public uid As String = ""
    Public count As Integer = 0I

    Private Sub LblReg_Click(sender As Object, e As EventArgs) Handles lblReg.Click
        Frm_Register.ShowDialog()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim digit As Integer = 0I
        Dim Lid As String = ""

        Dim DateT As DateTime = Convert.ToDateTime(DateTime.Now).ToString("dd.MMM,yyyy HH:mm:ss")

        Dim rs = From ll In db.LoginHistories
                 Order By ll.Id Descending

        If rs.Count = 0 Then
            Lid = "L0001"
        Else
            Dim id1 As String = (From a In db.LoginHistories
                                 Select a.Id).Max

            id1 = id1.Substring(3)
            Int32.TryParse(id1, digit)
            digit = digit + 1
            Lid = "L" + digit.ToString("D4")


        End If
        Dim id2 As String = txtID.Text
        Dim pass As String = txtPass.Text


        Dim u As User = db.Users.FirstOrDefault(Function(o) o.Id = id2)

        If u Is Nothing Then
            MessageBox.Show("Invalid User Login", "Validating User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim l As New LoginHistory()
            l.Id = Lid
            l.UserId = id2
            l.Name = u.Name
            l.Role = u.Role
            l.DateTime = DateT

            uid = id2


            If u.Password <> pass Then
                MessageBox.Show("Your login ID or password is wrong.Please enter again.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf u.Id <> id2 Then
                MessageBox.Show("Your login ID or password is wrong.Please enter again.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                'Add to variable currentUser for current logged user
                currentUser = u
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            db.LoginHistories.InsertOnSubmit(l)
            db.SubmitChanges()

            Frm_AssetHome.ShowDialog()
            Dispose()
        End If

        End If
    End Sub

    Private Sub LblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        count = 1
        Frm_PassRecovery.ShowDialog()
    End Sub

    Private Sub TxtID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtID.Validating
        If txtID.Text = "" Then
            err.SetError(txtID, "Please enter your ID")
            e.Cancel = True

        ElseIf txtID.Text.StartsWith("AD") Then
            err.SetError(txtID, Nothing)

        Else
            err.SetError(txtID, "Please enter a valid login ID(Admin ID)")
            e.Cancel = True
        End If
    End Sub



    Private Sub TxtPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPass.Validating
        If txtPass.Text = "" Then
            err.SetError(txtPass, "Please enter your password")
            e.Cancel = True
        Else
            err.SetError(txtPass, Nothing)
        End If
    End Sub

    Private Sub ChkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles backB.Click
        Me.Close()
        Frm_RoleChoose.Visible = True

    End Sub

    Private Sub Frm_LoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_RoleChoose.Visible = False
    End Sub

End Class