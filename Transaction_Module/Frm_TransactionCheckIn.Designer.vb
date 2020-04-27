<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TransactionCheckIn
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboReturnedBy = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblAssetId = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.picAssetProfile = New System.Windows.Forms.PictureBox()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picStaffProfile = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt3rdDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picAssetProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.picStaffProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(25, 312)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(953, 347)
        Me.dgv.TabIndex = 2
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.TabPage1)
        Me.tbc.Controls.Add(Me.TabPage2)
        Me.tbc.Controls.Add(Me.TabPage3)
        Me.tbc.Location = New System.Drawing.Point(25, 23)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(957, 258)
        Me.tbc.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboReturnedBy)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnApply)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.lblModel)
        Me.TabPage1.Controls.Add(Me.lblDesc)
        Me.TabPage1.Controls.Add(Me.lblAssetId)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.picAssetProfile)
        Me.TabPage1.Controls.Add(Me.cboCondition)
        Me.TabPage1.Controls.Add(Me.cboLocation)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(949, 229)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Assets To Check In"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboReturnedBy
        '
        Me.cboReturnedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReturnedBy.FormattingEnabled = True
        Me.cboReturnedBy.Items.AddRange(New Object() {"Local", "Third Party"})
        Me.cboReturnedBy.Location = New System.Drawing.Point(702, 49)
        Me.cboReturnedBy.Name = "cboReturnedBy"
        Me.cboReturnedBy.Size = New System.Drawing.Size(165, 24)
        Me.cboReturnedBy.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(699, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Return By :"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(151, 168)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(121, 26)
        Me.btnApply.TabIndex = 28
        Me.btnApply.Text = "Apply changes"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(342, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 17)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Current Selected Item : "
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(581, 133)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 26
        '
        'lblDesc
        '
        Me.lblDesc.Location = New System.Drawing.Point(581, 94)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(100, 23)
        Me.lblDesc.TabIndex = 25
        '
        'lblAssetId
        '
        Me.lblAssetId.Location = New System.Drawing.Point(581, 46)
        Me.lblAssetId.Name = "lblAssetId"
        Me.lblAssetId.Size = New System.Drawing.Size(100, 23)
        Me.lblAssetId.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(484, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Model : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(484, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Description : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(484, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Asset ID : "
        '
        'picAssetProfile
        '
        Me.picAssetProfile.Location = New System.Drawing.Point(342, 52)
        Me.picAssetProfile.Name = "picAssetProfile"
        Me.picAssetProfile.Size = New System.Drawing.Size(112, 153)
        Me.picAssetProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAssetProfile.TabIndex = 20
        Me.picAssetProfile.TabStop = False
        '
        'cboCondition
        '
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Items.AddRange(New Object() {"New", "Good", "Fair", "Poor"})
        Me.cboCondition.Location = New System.Drawing.Point(151, 129)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(121, 24)
        Me.cboCondition.TabIndex = 19
        '
        'cboLocation
        '
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(151, 90)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(121, 24)
        Me.cboLocation.TabIndex = 18
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"In storage"})
        Me.cboStatus.Location = New System.Drawing.Point(151, 52)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 24)
        Me.cboStatus.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Set Condition to : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Set location to : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Set Status to : "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.lblEmail)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.lblContact)
        Me.TabPage2.Controls.Add(Me.lblName)
        Me.TabPage2.Controls.Add(Me.txtStaffID)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.picStaffProfile)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(949, 229)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Returned By Local"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(511, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(313, 145)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(192, 17)
        Me.lblEmail.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(195, 145)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 17)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Email address : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(195, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Contact : "
        '
        'lblContact
        '
        Me.lblContact.Location = New System.Drawing.Point(313, 108)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(192, 17)
        Me.lblContact.TabIndex = 10
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(313, 72)
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
        Me.Label5.Location = New System.Drawing.Point(195, 72)
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
        'picStaffProfile
        '
        Me.picStaffProfile.Location = New System.Drawing.Point(33, 22)
        Me.picStaffProfile.Name = "picStaffProfile"
        Me.picStaffProfile.Size = New System.Drawing.Size(134, 180)
        Me.picStaffProfile.TabIndex = 12
        Me.picStaffProfile.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt3rdDesc)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(949, 229)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Returned By Third Party"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt3rdDesc
        '
        Me.txt3rdDesc.Location = New System.Drawing.Point(192, 49)
        Me.txt3rdDesc.Name = "txt3rdDesc"
        Me.txt3rdDesc.Size = New System.Drawing.Size(250, 22)
        Me.txt3rdDesc.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Third Party Description : "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(29, 288)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(173, 20)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Items To Check In :"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Asset_Management_System.My.Resources.Resources.Back_40px
        Me.btnCancel.Location = New System.Drawing.Point(928, 668)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 50)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Image = Global.Asset_Management_System.My.Resources.Resources.Save_40px
        Me.btnCheckIn.Location = New System.Drawing.Point(846, 668)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(50, 50)
        Me.btnCheckIn.TabIndex = 6
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Asset_Management_System.My.Resources.Resources.Plus_Math_40px
        Me.btnAdd.Location = New System.Drawing.Point(757, 668)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 50)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.Asset_Management_System.My.Resources.Resources.Delete_40px
        Me.btnRemove.Location = New System.Drawing.Point(668, 668)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(50, 50)
        Me.btnRemove.TabIndex = 15
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Frm_TransactionCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 724)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Frm_TransactionCheckIn"
        Me.Text = "Check In Form"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picAssetProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.picStaffProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents tbc As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblAssetId As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents picAssetProfile As PictureBox
    Friend WithEvents cboCondition As ComboBox
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents picStaffProfile As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents cboReturnedBy As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents txt3rdDesc As TextBox
End Class
