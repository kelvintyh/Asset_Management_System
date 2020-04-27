<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TransactionCheckOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt3thNotes = New System.Windows.Forms.TextBox()
        Me.txt3rdEmail = New System.Windows.Forms.TextBox()
        Me.txt3rdContact = New System.Windows.Forms.TextBox()
        Me.txt3rdDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTransactionType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCheckOutTo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(28, 300)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(194, 20)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Items To Check Out : "
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(24, 324)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(953, 347)
        Me.dgv.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtNotes)
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.lblEmail)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.lblContact)
        Me.TabPage2.Controls.Add(Me.lblName)
        Me.TabPage2.Controls.Add(Me.txtStaffID)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.picProfile)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(626, 247)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check Out To Local"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(195, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Notes : "
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(316, 165)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(270, 72)
        Me.txtNotes.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(511, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(313, 137)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(192, 17)
        Me.lblEmail.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(195, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 17)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Email address : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(195, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Contact : "
        '
        'lblContact
        '
        Me.lblContact.Location = New System.Drawing.Point(313, 100)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(192, 17)
        Me.lblContact.TabIndex = 10
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(313, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(192, 17)
        Me.lblName.TabIndex = 9
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(316, 27)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(189, 22)
        Me.txtStaffID.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Name : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Staff ID : "
        '
        'picProfile
        '
        Me.picProfile.Location = New System.Drawing.Point(33, 22)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(134, 180)
        Me.picProfile.TabIndex = 12
        Me.picProfile.TabStop = False
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.TabPage2)
        Me.tbc.Controls.Add(Me.TabPage1)
        Me.tbc.Location = New System.Drawing.Point(22, 12)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(634, 276)
        Me.tbc.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt3thNotes)
        Me.TabPage1.Controls.Add(Me.txt3rdEmail)
        Me.TabPage1.Controls.Add(Me.txt3rdContact)
        Me.TabPage1.Controls.Add(Me.txt3rdDesc)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(626, 247)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Check Out To Third Party"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Notes :"
        '
        'txt3thNotes
        '
        Me.txt3thNotes.Location = New System.Drawing.Point(184, 148)
        Me.txt3thNotes.Multiline = True
        Me.txt3thNotes.Name = "txt3thNotes"
        Me.txt3thNotes.Size = New System.Drawing.Size(304, 62)
        Me.txt3thNotes.TabIndex = 6
        '
        'txt3rdEmail
        '
        Me.txt3rdEmail.Location = New System.Drawing.Point(184, 107)
        Me.txt3rdEmail.Name = "txt3rdEmail"
        Me.txt3rdEmail.Size = New System.Drawing.Size(304, 22)
        Me.txt3rdEmail.TabIndex = 5
        '
        'txt3rdContact
        '
        Me.txt3rdContact.Location = New System.Drawing.Point(184, 65)
        Me.txt3rdContact.Name = "txt3rdContact"
        Me.txt3rdContact.Size = New System.Drawing.Size(304, 22)
        Me.txt3rdContact.TabIndex = 4
        '
        'txt3rdDesc
        '
        Me.txt3rdDesc.Location = New System.Drawing.Point(184, 20)
        Me.txt3rdDesc.Name = "txt3rdDesc"
        Me.txt3rdDesc.Size = New System.Drawing.Size(304, 22)
        Me.txt3rdDesc.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Third Party Email : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Third Party Contact : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Third Party Description : "
        '
        'cboTransactionType
        '
        Me.cboTransactionType.FormattingEnabled = True
        Me.cboTransactionType.Items.AddRange(New Object() {"Out of repair", "Loaned out", "Checked out"})
        Me.cboTransactionType.Location = New System.Drawing.Point(22, 143)
        Me.cboTransactionType.Name = "cboTransactionType"
        Me.cboTransactionType.Size = New System.Drawing.Size(143, 24)
        Me.cboTransactionType.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Transaction Type : "
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(22, 213)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(276, 22)
        Me.dtp.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCheckOutTo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboTransactionType)
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(671, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 272)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cboCheckOutTo
        '
        Me.cboCheckOutTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCheckOutTo.FormattingEnabled = True
        Me.cboCheckOutTo.Items.AddRange(New Object() {"Local", "Third Party"})
        Me.cboCheckOutTo.Location = New System.Drawing.Point(22, 63)
        Me.cboCheckOutTo.Name = "cboCheckOutTo"
        Me.cboCheckOutTo.Size = New System.Drawing.Size(143, 24)
        Me.cboCheckOutTo.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Check Out To : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Return Date : "
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.Asset_Management_System.My.Resources.Resources.Delete_40px
        Me.btnRemove.Location = New System.Drawing.Point(664, 680)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(50, 50)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Asset_Management_System.My.Resources.Resources.Back_40px
        Me.btnCancel.Location = New System.Drawing.Point(927, 680)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 50)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Image = Global.Asset_Management_System.My.Resources.Resources.Save_40px
        Me.btnCheckOut.Location = New System.Drawing.Point(845, 680)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(50, 50)
        Me.btnCheckOut.TabIndex = 12
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Asset_Management_System.My.Resources.Resources.Plus_Math_40px
        Me.btnAdd.Location = New System.Drawing.Point(756, 680)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 50)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Frm_TransactionCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 736)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Frm_TransactionCheckOut"
        Me.Text = "Frm_TransactionCheckOut"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents tbc As TabControl
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboTransactionType As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt3rdDesc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt3rdEmail As TextBox
    Friend WithEvents txt3rdContact As TextBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt3thNotes As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents cboCheckOutTo As ComboBox
    Friend WithEvents Label11 As Label
End Class
