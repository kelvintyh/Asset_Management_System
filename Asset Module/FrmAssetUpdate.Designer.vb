<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssetUpdate
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpDateOfAcquisition = New System.Windows.Forms.DateTimePicker()
        Me.dtpDueReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblWarrantyExp = New System.Windows.Forms.Label()
        Me.lblWarrantyId = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtInvoice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.picCOT = New System.Windows.Forms.PictureBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboManu = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpLocal = New System.Windows.Forms.GroupBox()
        Me.grpThirdParty = New System.Windows.Forms.GroupBox()
        Me.txt3rdEmail = New System.Windows.Forms.TextBox()
        Me.txt3rdContact = New System.Windows.Forms.TextBox()
        Me.txt3rdDesc = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picAsset = New System.Windows.Forms.PictureBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnType = New System.Windows.Forms.Button()
        Me.btnManu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picCOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.grpLocal.SuspendLayout()
        Me.grpThirdParty.SuspendLayout()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Vendor : "
        '
        'dtpDateOfAcquisition
        '
        Me.dtpDateOfAcquisition.Location = New System.Drawing.Point(175, 46)
        Me.dtpDateOfAcquisition.Name = "dtpDateOfAcquisition"
        Me.dtpDateOfAcquisition.Size = New System.Drawing.Size(261, 22)
        Me.dtpDateOfAcquisition.TabIndex = 0
        '
        'dtpDueReturnDate
        '
        Me.dtpDueReturnDate.Location = New System.Drawing.Point(796, 111)
        Me.dtpDueReturnDate.Name = "dtpDueReturnDate"
        Me.dtpDueReturnDate.Size = New System.Drawing.Size(257, 22)
        Me.dtpDueReturnDate.TabIndex = 24
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(673, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Due Return Date : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(673, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Check out to : "
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.FormattingEnabled = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblWarrantyExp)
        Me.GroupBox2.Controls.Add(Me.lblWarrantyId)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtVendor)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.txtInvoice)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.dtpDateOfAcquisition)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 314)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'lblWarrantyExp
        '
        Me.lblWarrantyExp.Location = New System.Drawing.Point(175, 262)
        Me.lblWarrantyExp.Name = "lblWarrantyExp"
        Me.lblWarrantyExp.Size = New System.Drawing.Size(200, 23)
        Me.lblWarrantyExp.TabIndex = 18
        '
        'lblWarrantyId
        '
        Me.lblWarrantyId.Location = New System.Drawing.Point(175, 220)
        Me.lblWarrantyId.Name = "lblWarrantyId"
        Me.lblWarrantyId.Size = New System.Drawing.Size(200, 23)
        Me.lblWarrantyId.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(22, 226)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 17)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Warranty Id : "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 17)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Warranty expires on : "
        '
        'txtVendor
        '
        Me.txtVendor.Location = New System.Drawing.Point(175, 96)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(200, 22)
        Me.txtVendor.TabIndex = 11
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(201, 140)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(174, 22)
        Me.txtPrice.TabIndex = 10
        '
        'txtInvoice
        '
        Me.txtInvoice.Location = New System.Drawing.Point(175, 181)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(200, 22)
        Me.txtInvoice.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 181)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 17)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Invoice /Reference : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 140)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(184, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Value at acquisition :     RM "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Date of acquisition : "
        '
        'picCOT
        '
        Me.picCOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCOT.Location = New System.Drawing.Point(24, 21)
        Me.picCOT.Name = "picCOT"
        Me.picCOT.Size = New System.Drawing.Size(136, 181)
        Me.picCOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCOT.TabIndex = 3
        Me.picCOT.TabStop = False
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"In storage", "Checked out", "Loaned out", "Out of repair"})
        Me.cboStatus.Location = New System.Drawing.Point(746, 45)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(187, 24)
        Me.cboStatus.TabIndex = 16
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
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
        'lblId
        '
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblId.Location = New System.Drawing.Point(424, 47)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(187, 27)
        Me.lblId.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Asset_Management_System.My.Resources.Resources.Save_64px
        Me.btnSave.Location = New System.Drawing.Point(991, 633)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 50)
        Me.btnSave.TabIndex = 4
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboManu
        '
        Me.cboManu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboManu.FormattingEnabled = True
        Me.cboManu.Location = New System.Drawing.Point(424, 165)
        Me.cboManu.Name = "cboManu"
        Me.cboManu.Size = New System.Drawing.Size(187, 24)
        Me.cboManu.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1148, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Purchase info."
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpLocal
        '
        Me.grpLocal.Controls.Add(Me.grpThirdParty)
        Me.grpLocal.Controls.Add(Me.lblContact)
        Me.grpLocal.Controls.Add(Me.lblName)
        Me.grpLocal.Controls.Add(Me.txtId)
        Me.grpLocal.Controls.Add(Me.picCOT)
        Me.grpLocal.Controls.Add(Me.Label13)
        Me.grpLocal.Controls.Add(Me.Label12)
        Me.grpLocal.Controls.Add(Me.Label11)
        Me.grpLocal.Location = New System.Drawing.Point(676, 206)
        Me.grpLocal.Name = "grpLocal"
        Me.grpLocal.Size = New System.Drawing.Size(427, 232)
        Me.grpLocal.TabIndex = 11
        Me.grpLocal.TabStop = False
        Me.grpLocal.Text = "Local"
        '
        'grpThirdParty
        '
        Me.grpThirdParty.Controls.Add(Me.txt3rdEmail)
        Me.grpThirdParty.Controls.Add(Me.txt3rdContact)
        Me.grpThirdParty.Controls.Add(Me.txt3rdDesc)
        Me.grpThirdParty.Controls.Add(Me.Label23)
        Me.grpThirdParty.Controls.Add(Me.Label22)
        Me.grpThirdParty.Controls.Add(Me.Label21)
        Me.grpThirdParty.Location = New System.Drawing.Point(0, 0)
        Me.grpThirdParty.Name = "grpThirdParty"
        Me.grpThirdParty.Size = New System.Drawing.Size(427, 232)
        Me.grpThirdParty.TabIndex = 6
        Me.grpThirdParty.TabStop = False
        Me.grpThirdParty.Text = "Third Party"
        '
        'txt3rdEmail
        '
        Me.txt3rdEmail.Location = New System.Drawing.Point(32, 180)
        Me.txt3rdEmail.Name = "txt3rdEmail"
        Me.txt3rdEmail.Size = New System.Drawing.Size(251, 22)
        Me.txt3rdEmail.TabIndex = 5
        '
        'txt3rdContact
        '
        Me.txt3rdContact.Location = New System.Drawing.Point(32, 113)
        Me.txt3rdContact.Name = "txt3rdContact"
        Me.txt3rdContact.Size = New System.Drawing.Size(251, 22)
        Me.txt3rdContact.TabIndex = 4
        '
        'txt3rdDesc
        '
        Me.txt3rdDesc.Location = New System.Drawing.Point(32, 53)
        Me.txt3rdDesc.Name = "txt3rdDesc"
        Me.txt3rdDesc.Size = New System.Drawing.Size(251, 22)
        Me.txt3rdDesc.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(29, 160)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 17)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Third Party Email : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(29, 93)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(142, 17)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Third Party Contact : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(29, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(165, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Third Party Description : "
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
        Me.Label8.Location = New System.Drawing.Point(673, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Status : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBack
        '
        Me.btnBack.Image = Global.Asset_Management_System.My.Resources.Resources.Undo_48px
        Me.btnBack.Location = New System.Drawing.Point(1094, 633)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(70, 50)
        Me.btnBack.TabIndex = 5
        Me.btnBack.UseVisualStyleBackColor = True
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
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnLocation)
        Me.TabPage1.Controls.Add(Me.btnType)
        Me.TabPage1.Controls.Add(Me.btnManu)
        Me.TabPage1.Controls.Add(Me.dtpDueReturnDate)
        Me.TabPage1.Controls.Add(Me.btnBrowse)
        Me.TabPage1.Controls.Add(Me.txtSerial)
        Me.TabPage1.Controls.Add(Me.txtModel)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cboLocation)
        Me.TabPage1.Controls.Add(Me.cboCondition)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.cboType)
        Me.TabPage1.Controls.Add(Me.txtDesc)
        Me.TabPage1.Controls.Add(Me.cboManu)
        Me.TabPage1.Controls.Add(Me.lblId)
        Me.TabPage1.Controls.Add(Me.grpLocal)
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
        'btnLocation
        '
        Me.btnLocation.Image = Global.Asset_Management_System.My.Resources.Resources.Pencil_15px
        Me.btnLocation.Location = New System.Drawing.Point(617, 450)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(35, 35)
        Me.btnLocation.TabIndex = 28
        Me.btnLocation.Tag = "Location"
        Me.btnLocation.UseVisualStyleBackColor = True
        '
        'btnType
        '
        Me.btnType.Image = Global.Asset_Management_System.My.Resources.Resources.Pencil_15px
        Me.btnType.Location = New System.Drawing.Point(617, 219)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(35, 35)
        Me.btnType.TabIndex = 26
        Me.btnType.Tag = "Type"
        Me.btnType.UseVisualStyleBackColor = True
        '
        'btnManu
        '
        Me.btnManu.Image = Global.Asset_Management_System.My.Resources.Resources.Pencil_15px
        Me.btnManu.Location = New System.Drawing.Point(617, 159)
        Me.btnManu.Name = "btnManu"
        Me.btnManu.Size = New System.Drawing.Size(35, 35)
        Me.btnManu.TabIndex = 25
        Me.btnManu.Tag = "Manu"
        Me.btnManu.UseVisualStyleBackColor = True
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1156, 615)
        Me.TabControl1.TabIndex = 3
        '
        'FrmAssetUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 700)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmAssetUpdate"
        Me.Text = "FrmAssetUpdate"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picCOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.grpLocal.ResumeLayout(False)
        Me.grpLocal.PerformLayout()
        Me.grpThirdParty.ResumeLayout(False)
        Me.grpThirdParty.PerformLayout()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents dtpDateOfAcquisition As DateTimePicker
    Friend WithEvents dtpDueReturnDate As DateTimePicker
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents cboCondition As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtInvoice As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents picCOT As PictureBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cboManu As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents grpLocal As GroupBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picAsset As PictureBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnManu As Button
    Friend WithEvents btnLocation As Button
    Friend WithEvents btnType As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtVendor As TextBox
    Friend WithEvents grpThirdParty As GroupBox
    Friend WithEvents txt3rdEmail As TextBox
    Friend WithEvents txt3rdContact As TextBox
    Friend WithEvents txt3rdDesc As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblWarrantyExp As Label
    Friend WithEvents lblWarrantyId As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
End Class
