<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WarrantyUpdate
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
        Me.cboxStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.cboxType = New System.Windows.Forms.ComboBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.ItemID = New System.Windows.Forms.Label()
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
        Me.gBoxWR.Controls.Add(Me.cboxStatus)
        Me.gBoxWR.Controls.Add(Me.Label1)
        Me.gBoxWR.Controls.Add(Me.btUpdate)
        Me.gBoxWR.Controls.Add(Me.EndDate)
        Me.gBoxWR.Controls.Add(Me.StartDate)
        Me.gBoxWR.Controls.Add(Me.cboxType)
        Me.gBoxWR.Controls.Add(Me.tbName)
        Me.gBoxWR.Controls.Add(Me.ItemID)
        Me.gBoxWR.Controls.Add(Me.lbRegEndDate)
        Me.gBoxWR.Controls.Add(Me.lbRegStartDate)
        Me.gBoxWR.Controls.Add(Me.lbRegType)
        Me.gBoxWR.Controls.Add(Me.lbRegName)
        Me.gBoxWR.Controls.Add(Me.lbRegId)
        Me.gBoxWR.Location = New System.Drawing.Point(22, 23)
        Me.gBoxWR.Name = "gBoxWR"
        Me.gBoxWR.Size = New System.Drawing.Size(616, 318)
        Me.gBoxWR.TabIndex = 2
        Me.gBoxWR.TabStop = False
        Me.gBoxWR.Text = "Update Information"
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
        'cboxStatus
        '
        Me.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxStatus.FormattingEnabled = True
        Me.cboxStatus.Items.AddRange(New Object() {"Active", "Pending"})
        Me.cboxStatus.Location = New System.Drawing.Point(131, 100)
        Me.cboxStatus.Name = "cboxStatus"
        Me.cboxStatus.Size = New System.Drawing.Size(153, 24)
        Me.cboxStatus.TabIndex = 12
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
        'btUpdate
        '
        Me.btUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btUpdate.Location = New System.Drawing.Point(367, 256)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(98, 31)
        Me.btUpdate.TabIndex = 10
        Me.btUpdate.Text = "&Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'EndDate
        '
        Me.EndDate.Enabled = False
        Me.EndDate.Location = New System.Drawing.Point(426, 162)
        Me.EndDate.MinDate = New Date(1999, 4, 10, 0, 0, 0, 0)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(153, 22)
        Me.EndDate.TabIndex = 9
        Me.EndDate.Value = New Date(2020, 4, 26, 16, 20, 14, 0)
        '
        'StartDate
        '
        Me.StartDate.Enabled = False
        Me.StartDate.Location = New System.Drawing.Point(131, 162)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(153, 22)
        Me.StartDate.TabIndex = 8
        '
        'cboxType
        '
        Me.cboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxType.FormattingEnabled = True
        Me.cboxType.Items.AddRange(New Object() {"Bronze     (1 month)", "Silver       (3 month)", "Gold         (6 month)", "Platinum (12 month)"})
        Me.cboxType.Location = New System.Drawing.Point(426, 100)
        Me.cboxType.Name = "cboxType"
        Me.cboxType.Size = New System.Drawing.Size(153, 24)
        Me.cboxType.TabIndex = 7
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(426, 42)
        Me.tbName.Multiline = True
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(153, 27)
        Me.tbName.TabIndex = 6
        '
        'ItemID
        '
        Me.ItemID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ItemID.Location = New System.Drawing.Point(131, 42)
        Me.ItemID.Name = "ItemID"
        Me.ItemID.Size = New System.Drawing.Size(153, 27)
        Me.ItemID.TabIndex = 5
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
        'Frm_WarrantyUpdate
        '
        Me.AcceptButton = Me.btUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btCancel
        Me.ClientSize = New System.Drawing.Size(666, 367)
        Me.Controls.Add(Me.gBoxWR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Frm_WarrantyUpdate"
        Me.Text = "Warranty Update"
        Me.gBoxWR.ResumeLayout(False)
        Me.gBoxWR.PerformLayout()
        CType(Me.errReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gBoxWR As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btCancel As Button
    Friend WithEvents cboxStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btUpdate As Button
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents cboxType As ComboBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents ItemID As Label
    Friend WithEvents lbRegEndDate As Label
    Friend WithEvents lbRegStartDate As Label
    Friend WithEvents lbRegType As Label
    Friend WithEvents lbRegName As Label
    Friend WithEvents lbRegId As Label
    Friend WithEvents errReg As ErrorProvider
End Class
