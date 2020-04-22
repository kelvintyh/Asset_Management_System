<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAssetAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cal = New System.Windows.Forms.MonthCalendar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.cboManu = New System.Windows.Forms.ComboBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.picCOT = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picAsset = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picCOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1156, 615)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnBrowse)
        Me.TabPage1.Controls.Add(Me.txtSerial)
        Me.TabPage1.Controls.Add(Me.txtModel)
        Me.TabPage1.Controls.Add(Me.cal)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cboLocation)
        Me.TabPage1.Controls.Add(Me.cboCondition)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.cboType)
        Me.TabPage1.Controls.Add(Me.txtDesc)
        Me.TabPage1.Controls.Add(Me.cboManu)
        Me.TabPage1.Controls.Add(Me.lblId)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.picAsset)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1148, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General info."
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(169, 331)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(111, 26)
        Me.btnBrowse.TabIndex = 23
        Me.btnBrowse.Text = "Browse Image"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(424, 346)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(187, 22)
        Me.txtSerial.TabIndex = 22
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(424, 286)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(187, 22)
        Me.txtModel.TabIndex = 21
        '
        'cal
        '
        Me.cal.Location = New System.Drawing.Point(680, 86)
        Me.cal.Name = "cal"
        Me.cal.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(677, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Due Return Date : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(677, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Check out to : "
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Unit A-101"})
        Me.cboLocation.Location = New System.Drawing.Point(424, 456)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(187, 24)
        Me.cboLocation.TabIndex = 18
        '
        'cboCondition
        '
        Me.cboCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Items.AddRange(New Object() {"New", "Good", "Fair", "Poor"})
        Me.cboCondition.Location = New System.Drawing.Point(424, 404)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(187, 24)
        Me.cboCondition.TabIndex = 17
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"In Storage", "Checked Out", "Loaned Out", "Out Of Repair"})
        Me.cboStatus.Location = New System.Drawing.Point(424, 509)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(187, 24)
        Me.cboStatus.TabIndex = 16
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Electronic"})
        Me.cboType.Location = New System.Drawing.Point(424, 225)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(187, 24)
        Me.cboType.TabIndex = 15
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(424, 108)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(187, 22)
        Me.txtDesc.TabIndex = 14
        '
        'cboManu
        '
        Me.cboManu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboManu.FormattingEnabled = True
        Me.cboManu.Items.AddRange(New Object() {"HP", "Canon"})
        Me.cboManu.Location = New System.Drawing.Point(424, 165)
        Me.cboManu.Name = "cboManu"
        Me.cboManu.Size = New System.Drawing.Size(187, 24)
        Me.cboManu.TabIndex = 13
        '
        'lblId
        '
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblId.Location = New System.Drawing.Point(424, 47)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(187, 27)
        Me.lblId.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblContact)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.picCOT)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(680, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 232)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'lblContact
        '
        Me.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContact.Location = New System.Drawing.Point(185, 179)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(225, 23)
        Me.lblContact.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(185, 110)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(225, 23)
        Me.lblName.TabIndex = 5
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(185, 41)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(222, 22)
        Me.txtId.TabIndex = 4
        '
        'picCOT
        '
        Me.picCOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCOT.Location = New System.Drawing.Point(28, 21)
        Me.picCOT.Name = "picCOT"
        Me.picCOT.Size = New System.Drawing.Size(136, 181)
        Me.picCOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCOT.TabIndex = 3
        Me.picCOT.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(182, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Contact : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(182, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Name : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(182, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ID : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(266, 459)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Inventory Location : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(351, 516)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Status : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(321, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Condition : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(300, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Serial Number : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(355, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Model : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(321, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Asset Type : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(311, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Manufacturer : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(321, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(371, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picAsset
        '
        Me.picAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAsset.InitialImage = Global.Asset_Management_System.My.Resources.Resources.Picture_96px
        Me.picAsset.Location = New System.Drawing.Point(33, 47)
        Me.picAsset.Name = "picAsset"
        Me.picAsset.Size = New System.Drawing.Size(247, 270)
        Me.picAsset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsset.TabIndex = 0
        Me.picAsset.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1148, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Purchase info."
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Asset_Management_System.My.Resources.Resources.Save_64px
        Me.btnSave.Location = New System.Drawing.Point(992, 634)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 50)
        Me.btnSave.TabIndex = 1
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.Asset_Management_System.My.Resources.Resources.Undo_48px
        Me.btnBack.Location = New System.Drawing.Point(1095, 634)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(70, 50)
        Me.btnBack.TabIndex = 2
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmAssetAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 694)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmAssetAdd"
        Me.Text = "FrmAssetAdd"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picCOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picAsset As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblId As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents picCOT As PictureBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents cboManu As ComboBox
    Friend WithEvents cal As MonthCalendar
    Friend WithEvents Label14 As Label
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents cboCondition As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
