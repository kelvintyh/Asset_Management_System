Imports System.IO
Imports System.Text.RegularExpressions

Public Class Frm_Register

    Dim db As New AMSDBDataContext()

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim name As String = txtName.Text
        Dim username As String = txtUser.Text
        Dim pass As String = txtPass.Text
        Dim role As String = cboRole.SelectedItem
        Dim id1 As String = txtID.Text
        Dim gender As String = cboGen.SelectedItem
        Dim contact As String = mskCont.Text
        Dim email As String = txtEmail.Text

        Dim ms As New MemoryStream
        PicBox1.Image.Save(ms, PicBox1.Image.RawFormat)

        Dim u As New User()
        u.Id = id1
        u.Name = name
        u.Username = username
        u.Password = pass
        u.Gender = gender
        u.Contact_number = contact
        u.Email_address = email
        u.Image = ms.ToArray
        u.Role = role


        db.Users.InsertOnSubmit(u)
        db.SubmitChanges()
        createActionHistory("CreateU", currentUser.Id, u.Id)

        MessageBox.Show("Record Added", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ResetForm()
        Dim id2 As String = (From a In db.Users
                             Select a.Id).Max

        Dim digit As Integer = 0I

        id2 = id2.Substring(3)
        Int32.TryParse(id2, digit)
        digit = digit + 1
        txtID.Text = "AD" + digit.ToString("D4")

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG,)|*.jpg;*.png"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicBox1.Image = Image.FromFile(opf.FileName)
        End If

        If opf.FileName = "" Then
            btnRegister.Enabled = False
        Else
            btnRegister.Enabled = True
        End If
    End Sub

    Private Sub TxtUser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUser.Validating

        If txtUser.Text = "" Then
            err.SetError(txtUser, "Please enter your username")
            e.Cancel = True
        ElseIf IsDuplicateId(txtUser.Text) Then
            err.SetError(txtUser, "This username has been taken")
            e.Cancel = True

        Else
            err.SetError(txtUser, Nothing)
        End If

    End Sub

    Private Function IsDuplicateId(username As String) As Boolean

        Dim isD = db.Users.Any(Function(o) o.Username = username)

        If isD Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Function IsDuplicateCont(contact As String) As Boolean

        Dim isD = db.Users.Any(Function(o) o.Contact_number = contact)

        If isD Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function IsDuplicateEmail(email As String) As Boolean

        Dim isD = db.Users.Any(Function(o) o.Email_address = email)

        If isD Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub TxtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"


        If txtEmail.Text = "" Then
            err.SetError(txtEmail, "Please enter your email")
            e.Cancel = True
        ElseIf IsDuplicateEmail(txtEmail.Text) Then
            err.SetError(txtEmail, "This email has been registered by others")
            e.Cancel = True
        ElseIf Regex.IsMatch(txtEmail.Text, pattern) Then
            err.SetError(txtEmail, Nothing)
        Else
            err.SetError(txtEmail, "Email format wrong")
            e.Cancel = True
        End If
    End Sub

    Private Sub MaskedTextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskCont.Validating

        If mskCont.Text = "" Then
            err.SetError(mskCont, "Please enter your contact no")
            e.Cancel = True
        ElseIf IsDuplicateCont(mskCont.Text) Then
            err.SetError(mskCont, "This contact number has been registered by others.")
            e.Cancel = True
        ElseIf mskCont.MaskCompleted <> True Then
            err.SetError(mskCont, "Please enter your complete contact no")
            e.Cancel = True
        Else
            err.SetError(mskCont, Nothing)

        End If
    End Sub

    Private Sub CboRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRole.SelectedIndexChanged

        Dim id1 As String = (From a In db.Users
                             Select a.Id).Max

        Dim digit As Integer = 0I

        If cboRole.SelectedItem = "Admin" Then
            Dim rs = From u In db.Users
                     Where u.Role = "Admin"
                     Order By u.Id Descending

            If rs.Count = 0 Then
                txtID.Text = "AD0001"
            Else
                id1 = id1.Substring(3)
                Int32.TryParse(id1, digit)
                digit = digit + 1
                txtID.Text = "AD" + digit.ToString("D4")
            End If
        End If


        If cboRole.SelectedItem = "Staff" Then
            Dim rs1 = From u In db.Users
                      Where u.Role = "Admin"
                      Order By u.Id Descending

            If rs1.Count = 0 Then
                txtID.Text = "S0001"
            Else
                id1 = id1.Substring(3)
                Int32.TryParse(id1, digit)
                digit = digit + 1
                txtID.Text = "S" + digit.ToString("D4")
            End If

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

    Private Sub Frm_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.SelectedIndex = 0
        cboGen.SelectedIndex = 0
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dispose()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        txtName.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        txtConfPass.Text = ""
        txtEmail.Text = ""
        mskCont.Text = ""
        cboGen.SelectedIndex = 0
        opf.FileName = ""
        cboRole.SelectedIndex = 0
        PicBox1.Image = Nothing
    End Sub

    Private Sub TxtConfPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtConfPass.Validating
        If txtConfPass.Text = "" Then
            err.SetError(txtConfPass, "Please enter your password")
            e.Cancel = True
        ElseIf txtConfPass.Text <> txtPass.Text Then
            err.SetError(txtConfPass, "Please re-enter your password")
            e.Cancel = True
        Else
            err.SetError(txtConfPass, Nothing)
        End If
    End Sub

    Private Sub TxtPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPass.Validating

        If txtPass.Text = "" Then
            err.SetError(txtPass, "Please enter your password")
            e.Cancel = True
        ElseIf txtPass.TextLength < 8 Then
            err.SetError(txtPass, "Password must at least 8 characters")
            e.Cancel = True
        Else
            err.SetError(txtPass, Nothing)
        End If
    End Sub

    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles backB.Click
        Me.Close()
        Frm_AssetHome.Visible = True

    End Sub
End Class