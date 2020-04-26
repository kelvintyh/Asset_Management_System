<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WarrantyAdd
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
        Me.components = New System.ComponentModel.Container()
        Me.gBoxWR = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.cboxRegStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btRegister = New System.Windows.Forms.Button()
        Me.RegEndDate = New System.Windows.Forms.DateTimePicker()
        Me.RegStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cboxRegType = New System.Windows.Forms.ComboBox()
        Me.tbRegName = New System.Windows.Forms.TextBox()
        Me.ItemRegID = New System.Windows.Forms.Label()
        Me.lbRegEndDate = New System.Windows.Forms.Label()
        Me.lbRegStartDate = New System.Windows.Forms.Label()
        Me.lbRegType = New System.Windows.Forms.Label()
        Me.lbRegName = New System.Windows.Forms.Label()
        Me.lbRegId = New System.Windows.Forms.Label()
        Me.errReg = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gBoxWR.SuspendLayout()
        CType(Me.errReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gBoxWR
        '
        Me.gBoxWR.Controls.Add(Me.TextBox2)
        Me.gBoxWR.Controls.Add(Me.TextBox1)
        Me.gBoxWR.Controls.Add(Me.btCancel)
        Me.gBoxWR.Controls.Add(Me.cboxRegStatus)
        Me.gBoxWR.Controls.Add(Me.Label1)
        Me.gBoxWR.Controls.Add(Me.btRegister)
        Me.gBoxWR.Controls.Add(Me.RegEndDate)
        Me.gBoxWR.Controls.Add(Me.RegStartDate)
        Me.gBoxWR.Controls.Add(Me.cboxRegType)
        Me.gBoxWR.Controls.Add(Me.tbRegName)
        Me.gBoxWR.Controls.Add(Me.ItemRegID)
        Me.gBoxWR.Controls.Add(Me.lbRegEndDate)
        Me.gBoxWR.Controls.Add(Me.lbRegStartDate)
        Me.gBoxWR.Controls.Add(Me.lbRegType)
        Me.gBoxWR.Controls.Add(Me.lbRegName)
        Me.gBoxWR.Controls.Add(Me.lbRegId)
        Me.gBoxWR.Location = New System.Drawing.Point(20, 25)
        Me.gBoxWR.Name = "gBoxWR"
        Me.gBoxWR.Size = New System.Drawing.Size(616, 318)
        Me.gBoxWR.TabIndex = 1
        Me.gBoxWR.TabStop = False
        Me.gBoxWR.Text = "Warranty Registration"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(554, 167)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(21, 11)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(262, 167)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(20, 12)
        Me.TextBox1.TabIndex = 14
        '
        'btCancel
        '
        Me.btCancel.CausesValidation = False
        Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btCancel.Location = New System.Drawing.Point(481, 256)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(98, 31)
        Me.btCancel.TabIndex = 13
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'cboxRegStatus
        '
        Me.cboxRegStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxRegStatus.FormattingEnabled = True
        Me.cboxRegStatus.Items.AddRange(New Object() {"Active", "Pending"})
        Me.cboxRegStatus.Location = New System.Drawing.Point(131, 100)
        Me.cboxRegStatus.Name = "cboxRegStatus"
        Me.cboxRegStatus.Size = New System.Drawing.Size(153, 24)
        Me.cboxRegStatus.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Status       :"
        '
        'btRegister
        '
        Me.btRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btRegister.Location = New System.Drawing.Point(367, 256)
        Me.btRegister.Name = "btRegister"
        Me.btRegister.Size = New System.Drawing.Size(98, 31)
        Me.btRegister.TabIndex = 10
        Me.btRegister.Text = "&Register"
        Me.btRegister.UseVisualStyleBackColor = True
        '
        'RegEndDate
        '
        Me.RegEndDate.Enabled = False
        Me.RegEndDate.Location = New System.Drawing.Point(426, 162)
        Me.RegEndDate.MinDate = New Date(1999, 4, 10, 0, 0, 0, 0)
        Me.RegEndDate.Name = "RegEndDate"
        Me.RegEndDate.Size = New System.Drawing.Size(153, 22)
        Me.RegEndDate.TabIndex = 9
        Me.RegEndDate.Value = New Date(2020, 4, 26, 16, 20, 14, 0)
        '
        'RegStartDate
        '
        Me.RegStartDate.Enabled = False
        Me.RegStartDate.Location = New System.Drawing.Point(131, 162)
        Me.RegStartDate.Name = "RegStartDate"
        Me.RegStartDate.Size = New System.Drawing.Size(153, 22)
        Me.RegStartDate.TabIndex = 8
        '
        'cboxRegType
        '
        Me.cboxRegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxRegType.FormattingEnabled = True
        Me.cboxRegType.Items.AddRange(New Object() {"Bronze     (1 month)", "Silver       (3 month)", "Gold         (6 month)", "Platinum (12 month)"})
        Me.cboxRegType.Location = New System.Drawing.Point(426, 100)
        Me.cboxRegType.Name = "cboxRegType"
        Me.cboxRegType.Size = New System.Drawing.Size(153, 24)
        Me.cboxRegType.TabIndex = 7
        '
        'tbRegName
        '
        Me.tbRegName.Location = New System.Drawing.Point(426, 42)
        Me.tbRegName.Multiline = True
        Me.tbRegName.Name = "tbRegName"
        Me.tbRegName.Size = New System.Drawing.Size(153, 27)
        Me.tbRegName.TabIndex = 6
        '
        'ItemRegID
        '
        Me.ItemRegID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemRegID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ItemRegID.Location = New System.Drawing.Point(131, 42)
        Me.ItemRegID.Name = "ItemRegID"
        Me.ItemRegID.Size = New System.Drawing.Size(153, 27)
        Me.ItemRegID.TabIndex = 5
        '
        'lbRegEndDate
        '
        Me.lbRegEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRegEndDate.Location = New System.Drawing.Point(320, 162)
        Me.lbRegEndDate.Name = "lbRegEndDate"
        Me.lbRegEndDate.Size = New System.Drawing.Size(121, 27)
        Me.lbRegEndDate.TabIndex = 4
        Me.lbRegEndDate.Text = "End Date :"
        '
        'lbRegStartDate
        '
        Me.lbRegStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRegStartDate.Location = New System.Drawing.Point(25, 162)
        Me.lbRegStartDate.Name = "lbRegStartDate"
        Me.lbRegStartDate.Size = New System.Drawing.Size(121, 27)
        Me.lbRegStartDate.TabIndex = 3
        Me.lbRegStartDate.Text = "Start Date :"
        '
        'lbRegType
        '
        Me.lbRegType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRegType.Location = New System.Drawing.Point(320, 100)
        Me.lbRegType.Name = "lbRegType"
        Me.lbRegType.Size = New System.Drawing.Size(121, 27)
        Me.lbRegType.TabIndex = 2
        Me.lbRegType.Text = "Type        :"
        '
        'lbRegName
        '
        Me.lbRegName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRegName.Location = New System.Drawing.Point(320, 42)
        Me.lbRegName.Name = "lbRegName"
        Me.lbRegName.Size = New System.Drawing.Size(121, 27)
        Me.lbRegName.TabIndex = 1
        Me.lbRegName.Text = "Name      :"
        '
        'lbRegId
        '
        Me.lbRegId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRegId.Location = New System.Drawing.Point(25, 42)
        Me.lbRegId.Name = "lbRegId"
        Me.lbRegId.Size = New System.Drawing.Size(121, 27)
        Me.lbRegId.TabIndex = 0
        Me.lbRegId.Text = "ID             :"
        '
        'errReg
        '
        Me.errReg.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errReg.ContainerControl = Me
        '
        'Frm_WarrantyAdd
        '
        Me.AcceptButton = Me.btRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btCancel
        Me.ClientSize = New System.Drawing.Size(657, 367)
        Me.Controls.Add(Me.gBoxWR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Frm_WarrantyAdd"
        Me.Text = "Warranty Registration"
        Me.gBoxWR.ResumeLayout(False)
        Me.gBoxWR.PerformLayout()
        CType(Me.errReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gBoxWR As GroupBox
    Friend WithEvents cboxRegStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btRegister As Button
    Friend WithEvents RegEndDate As DateTimePicker
    Friend WithEvents RegStartDate As DateTimePicker
    Friend WithEvents cboxRegType As ComboBox
    Friend WithEvents tbRegName As TextBox
    Friend WithEvents ItemRegID As Label
    Friend WithEvents lbRegEndDate As Label
    Friend WithEvents lbRegStartDate As Label
    Friend WithEvents lbRegType As Label
    Friend WithEvents lbRegName As Label
    Friend WithEvents lbRegId As Label
    Friend WithEvents errReg As ErrorProvider
    Friend WithEvents btCancel As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
