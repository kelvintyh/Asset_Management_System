Imports System.IO
Imports System.Text.RegularExpressions

Public Class Profile

    Dim db As New AMSDBDataContext()

    Sub edit()
        btnSave.Text = "&Save"
        txtName.Enabled = True
        txtUser.Enabled = True
        txtPass.Enabled = True
        txtConfPass.Enabled = True
        cboGen.Enabled = True
        mskCont.Enabled = True
        txtEmail.Enabled = True
        btnBrowse.Enabled = True
    End Sub

    Sub save()
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim name As String = txtName.Text
        Dim username As String = txtUser.Text
        Dim pass As String = txtPass.Text
        Dim gender As String = cboGen.SelectedItem
        Dim contact As String = mskCont.Text
        Dim email As String = txtEmail.Text

        Dim ms As New MemoryStream
        PicBox1.Image.Save(ms, PicBox1.Image.RawFormat)

        Dim u As User = db.Users.FirstOrDefault(Function(o) o.Id = txtID.Text)
        u.Name = name
        u.Username = username
        u.Password = pass
        u.Gender = gender
        u.Contact_number = contact
        u.Email_address = email
        u.Image = ms.ToArray

        Dim r = MessageBox.Show("Are you sure to Update the profile?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If r = DialogResult.Yes Then
            db.SubmitChanges()
            btnSave.Text = "&Edit"
            txtName.Enabled = False
            txtUser.Enabled = False
            txtPass.Enabled = False
            txtConfPass.Enabled = False
            cboGen.Enabled = False
            mskCont.Enabled = False
            txtEmail.Enabled = False
            btnBrowse.Enabled = False
            MessageBox.Show("Record Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            createActionHistory("UpdateU", currentUser.Id, u.Id)
        End If
    End Sub

    Private Sub Profile_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim i = currentUser

        If i.Role.Equals("Staff") Then
            txtID.Text = i.Id
            txtName.Text = i.Name
            txtUser.Text = i.Username
            cboGen.Text = i.Gender
            mskCont.Text = i.Contact_number
            txtEmail.Text = i.Email_address
            PicBox1.Image = GetImage(i.Image.ToArray)
            txtRole.Text = i.Role

            txtName.Enabled = False
            txtUser.Enabled = False
            txtPass.Enabled = False
            txtConfPass.Enabled = False
            cboGen.Enabled = False
            mskCont.Enabled = False
            txtEmail.Enabled = False
            btnBrowse.Enabled = False
        Else
            Dim a = ProfileList.dgv.CurrentRow.Index
            For Each w In db.Users
                If w.Id = ProfileList.dgv.Item(0, a).Value Then
                    txtID.Text = w.Id
                    txtName.Text = w.Name
                    txtUser.Text = w.Username
                    cboGen.Text = w.Gender
                    mskCont.Text = w.Contact_number
                    txtEmail.Text = w.Email_address
                    PicBox1.Image = GetImage(w.Image.ToArray)
                    txtRole.Text = w.Role

                    txtName.Enabled = False
                    txtUser.Enabled = False
                    txtPass.Enabled = False
                    txtConfPass.Enabled = False
                    cboGen.Enabled = False
                    mskCont.Enabled = False
                    txtEmail.Enabled = False
                    btnBrowse.Enabled = False
                End If
            Next
        End If
    End Sub

    Private Sub TxtUser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUser.Validating

        If txtUser.Text = "" Then
            err.SetError(txtUser, "Please enter your username")
            e.Cancel = True
        Else
            err.SetError(txtUser, Nothing)
        End If
    End Sub

    Private Sub MskCont_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskCont.Validating

        If mskCont.Text = "" Then
            err.SetError(mskCont, "Please enter your contact no")
            e.Cancel = True
        ElseIf mskCont.MaskCompleted <> True Then
            err.SetError(mskCont, "Please enter your complete contact no")
            e.Cancel = True
        Else
            err.SetError(mskCont, Nothing)
        End If
    End Sub

    Private Sub TxtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"


        If txtEmail.Text = "" Then
            err.SetError(txtEmail, "Please enter your email")
            e.Cancel = True
        ElseIf Regex.IsMatch(txtEmail.Text, pattern) Then
            err.SetError(txtEmail, Nothing)
        Else
            err.SetError(txtEmail, "Email format wrong")
            e.Cancel = True
        End If
    End Sub

    Private Sub TxtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Dim pattern As String = "^[a-z]*$"

        If txtName.Text = "" Then
            err.SetError(txtName, "Please enter your name")
            e.Cancel = True
        ElseIf Regex.IsMatch(txtName.Text, pattern, RegexOptions.IgnoreCase) Then
            err.SetError(txtName, Nothing)
        Else
            err.SetError(txtName, "Please enter a valid name")
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG,)|*.jpg;*.png"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text.Equals("&Edit") Then
            edit()
        ElseIf btnSave.Text.Equals("&Save") Then
            If txtPass.Text = "" Then
                err.SetError(txtPass, "Please enter your password")
            ElseIf txtPass.TextLength < 8 Then
                err.SetError(txtPass, "Password must at least 8 characters")
            ElseIf txtConfPass.Text = "" Then
                err.SetError(txtConfPass, "Please enter your password")
            ElseIf txtConfPass.Text <> txtPass.Text Then
                err.SetError(txtConfPass, "Password is not match")
            Else
                err.SetError(txtPass, Nothing)
                err.SetError(txtConfPass, Nothing)
                save()
            End If
        End If
    End Sub
End Class