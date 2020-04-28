<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_AssetHome
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        Me.picCOT = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCOT = New System.Windows.Forms.Label()
        Me.lblRDD = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblManu = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.lblWarrantyExpDate = New System.Windows.Forms.Label()
        Me.lblWarrantyId = New System.Windows.Forms.Label()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpDateOfAcquisition = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvTransactionLog = New System.Windows.Forms.DataGridView()
        Me.msp = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileGenerateReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReportASR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransactionSummaryReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewWarranty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewActionHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpLocal.SuspendLayout()
        Me.grpThirdParty.SuspendLayout()
        CType(Me.picCOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvTransactionLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msp.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnCheckOut)
        Me.GroupBox1.Controls.Add(Me.btnCheckIn)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 720)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.Location = New System.Drawing.Point(166, 19)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(130, 50)
        Me.btnCheckOut.TabIndex = 7
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckIn.Location = New System.Drawing.Point(7, 19)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(130, 50)
        Me.btnCheckIn.TabIndex = 6
        Me.btnCheckIn.Text = "Check In"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(7, 158)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(444, 461)
        Me.dgv.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Location = New System.Drawing.Point(7, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 105)
        Me.Panel1.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Asset_Management_System.My.Resources.Resources.Delete_25px
        Me.btnDelete.Location = New System.Drawing.Point(401, 636)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(50, 44)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Asset_Management_System.My.Resources.Resources.Pencil_25px
        Me.btnEdit.Location = New System.Drawing.Point(345, 636)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(50, 44)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Asset_Management_System.My.Resources.Resources.Plus_Math_25px
        Me.btnAdd.Location = New System.Drawing.Point(289, 636)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 44)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(475, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(936, 406)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(924, 379)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.grpLocal)
        Me.TabPage1.Controls.Add(Me.lblType)
        Me.TabPage1.Controls.Add(Me.lblId)
        Me.TabPage1.Controls.Add(Me.lblCOT)
        Me.TabPage1.Controls.Add(Me.lblRDD)
        Me.TabPage1.Controls.Add(Me.lblStatus)
        Me.TabPage1.Controls.Add(Me.lblLocation)
        Me.TabPage1.Controls.Add(Me.lblCondition)
        Me.TabPage1.Controls.Add(Me.lblSerial)
        Me.TabPage1.Controls.Add(Me.lblModel)
        Me.TabPage1.Controls.Add(Me.lblManu)
        Me.TabPage1.Controls.Add(Me.lblDesc)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
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
        Me.TabPage1.Size = New System.Drawing.Size(916, 350)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General info."
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(532, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(278, 22)
        Me.DateTimePicker1.TabIndex = 24
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
        Me.grpLocal.Controls.Add(Me.Label14)
        Me.grpLocal.Location = New System.Drawing.Point(532, 130)
        Me.grpLocal.Name = "grpLocal"
        Me.grpLocal.Size = New System.Drawing.Size(357, 204)
        Me.grpLocal.TabIndex = 23
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
        Me.grpThirdParty.Size = New System.Drawing.Size(357, 204)
        Me.grpThirdParty.TabIndex = 6
        Me.grpThirdParty.TabStop = False
        Me.grpThirdParty.Text = "Third Party"
        '
        'txt3rdEmail
        '
        Me.txt3rdEmail.Location = New System.Drawing.Point(32, 160)
        Me.txt3rdEmail.Name = "txt3rdEmail"
        Me.txt3rdEmail.Size = New System.Drawing.Size(251, 22)
        Me.txt3rdEmail.TabIndex = 5
        '
        'txt3rdContact
        '
        Me.txt3rdContact.Location = New System.Drawing.Point(32, 105)
        Me.txt3rdContact.Name = "txt3rdContact"
        Me.txt3rdContact.Size = New System.Drawing.Size(251, 22)
        Me.txt3rdContact.TabIndex = 4
        '
        'txt3rdDesc
        '
        Me.txt3rdDesc.Location = New System.Drawing.Point(32, 51)
        Me.txt3rdDesc.Name = "txt3rdDesc"
        Me.txt3rdDesc.Size = New System.Drawing.Size(251, 22)
        Me.txt3rdDesc.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(29, 140)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 17)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Third Party Email : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(29, 85)
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
        Me.lblContact.Location = New System.Drawing.Point(146, 165)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(205, 23)
        Me.lblContact.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(146, 108)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(205, 23)
        Me.lblName.TabIndex = 5
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(146, 50)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(205, 22)
        Me.txtId.TabIndex = 4
        '
        'picCOT
        '
        Me.picCOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCOT.Location = New System.Drawing.Point(24, 30)
        Me.picCOT.Name = "picCOT"
        Me.picCOT.Size = New System.Drawing.Size(113, 158)
        Me.picCOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCOT.TabIndex = 3
        Me.picCOT.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(143, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Contact : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(143, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Name : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(143, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ID : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(126, 227)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(100, 23)
        Me.lblType.TabIndex = 22
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(126, 183)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(100, 23)
        Me.lblId.TabIndex = 21
        '
        'lblCOT
        '
        Me.lblCOT.Location = New System.Drawing.Point(657, 112)
        Me.lblCOT.Name = "lblCOT"
        Me.lblCOT.Size = New System.Drawing.Size(100, 23)
        Me.lblCOT.TabIndex = 20
        '
        'lblRDD
        '
        Me.lblRDD.Location = New System.Drawing.Point(657, 67)
        Me.lblRDD.Name = "lblRDD"
        Me.lblRDD.Size = New System.Drawing.Size(100, 23)
        Me.lblRDD.TabIndex = 19
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(380, 227)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 23)
        Me.lblStatus.TabIndex = 18
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(380, 204)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(100, 23)
        Me.lblLocation.TabIndex = 17
        '
        'lblCondition
        '
        Me.lblCondition.Location = New System.Drawing.Point(380, 171)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(100, 23)
        Me.lblCondition.TabIndex = 16
        '
        'lblSerial
        '
        Me.lblSerial.Location = New System.Drawing.Point(380, 136)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(100, 23)
        Me.lblSerial.TabIndex = 15
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(380, 101)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 14
        '
        'lblManu
        '
        Me.lblManu.Location = New System.Drawing.Point(380, 67)
        Me.lblManu.Name = "lblManu"
        Me.lblManu.Size = New System.Drawing.Size(100, 23)
        Me.lblManu.TabIndex = 13
        '
        'lblDesc
        '
        Me.lblDesc.Location = New System.Drawing.Point(380, 30)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(100, 23)
        Me.lblDesc.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(533, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Checked Out To : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(529, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Return Due Date : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(262, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Status : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(262, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Inv. Location : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(262, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Condition : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Serial Number : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Model : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(262, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Manufacturer : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Asset Type : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picAsset
        '
        Me.picAsset.Location = New System.Drawing.Point(29, 28)
        Me.picAsset.Name = "picAsset"
        Me.picAsset.Size = New System.Drawing.Size(192, 152)
        Me.picAsset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsset.TabIndex = 0
        Me.picAsset.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblWarrantyExpDate)
        Me.TabPage2.Controls.Add(Me.lblWarrantyId)
        Me.TabPage2.Controls.Add(Me.lblInvoice)
        Me.TabPage2.Controls.Add(Me.lblPrice)
        Me.TabPage2.Controls.Add(Me.lblVendor)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.lbl21)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.dtpDateOfAcquisition)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(916, 350)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Purchase info."
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblWarrantyExpDate
        '
        Me.lblWarrantyExpDate.Location = New System.Drawing.Point(641, 79)
        Me.lblWarrantyExpDate.Name = "lblWarrantyExpDate"
        Me.lblWarrantyExpDate.Size = New System.Drawing.Size(137, 17)
        Me.lblWarrantyExpDate.TabIndex = 25
        '
        'lblWarrantyId
        '
        Me.lblWarrantyId.Location = New System.Drawing.Point(602, 38)
        Me.lblWarrantyId.Name = "lblWarrantyId"
        Me.lblWarrantyId.Size = New System.Drawing.Size(129, 17)
        Me.lblWarrantyId.TabIndex = 24
        '
        'lblInvoice
        '
        Me.lblInvoice.Location = New System.Drawing.Point(205, 173)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(203, 17)
        Me.lblInvoice.TabIndex = 23
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(205, 132)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(203, 17)
        Me.lblPrice.TabIndex = 22
        '
        'lblVendor
        '
        Me.lblVendor.Location = New System.Drawing.Point(205, 83)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(203, 17)
        Me.lblVendor.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(488, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 17)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Warranty Id : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(55, 173)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 17)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Invoice /Reference : "
        '
        'lbl21
        '
        Me.lbl21.AutoSize = True
        Me.lbl21.Location = New System.Drawing.Point(488, 79)
        Me.lbl21.Name = "lbl21"
        Me.lbl21.Size = New System.Drawing.Size(147, 17)
        Me.lbl21.TabIndex = 18
        Me.lbl21.Text = "Warranty expires on : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(55, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(143, 17)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Value at acquisition : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(55, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 17)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Date of acquisition : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(55, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Vendor : "
        '
        'dtpDateOfAcquisition
        '
        Me.dtpDateOfAcquisition.Enabled = False
        Me.dtpDateOfAcquisition.Location = New System.Drawing.Point(208, 38)
        Me.dtpDateOfAcquisition.Name = "dtpDateOfAcquisition"
        Me.dtpDateOfAcquisition.Size = New System.Drawing.Size(261, 22)
        Me.dtpDateOfAcquisition.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TabControl2)
        Me.GroupBox3.Location = New System.Drawing.Point(475, 442)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Size = New System.Drawing.Size(936, 311)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(10, 18)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(920, 276)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvTransactionLog)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(912, 247)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Transactions log"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvTransactionLog
        '
        Me.dgvTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionLog.Location = New System.Drawing.Point(6, 7)
        Me.dgvTransactionLog.Name = "dgvTransactionLog"
        Me.dgvTransactionLog.ReadOnly = True
        Me.dgvTransactionLog.RowHeadersWidth = 51
        Me.dgvTransactionLog.RowTemplate.Height = 24
        Me.dgvTransactionLog.Size = New System.Drawing.Size(900, 234)
        Me.dgvTransactionLog.TabIndex = 0
        '
        'msp
        '
        Me.msp.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView})
        Me.msp.Location = New System.Drawing.Point(0, 0)
        Me.msp.Name = "msp"
        Me.msp.Size = New System.Drawing.Size(1428, 28)
        Me.msp.TabIndex = 1
        Me.msp.Text = "msp"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileGenerateReport})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "File"
        '
        'mnuFileGenerateReport
        '
        Me.mnuFileGenerateReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReportASR, Me.mnuTransactionSummaryReport})
        Me.mnuFileGenerateReport.Name = "mnuFileGenerateReport"
        Me.mnuFileGenerateReport.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileGenerateReport.Text = "Generate Report"
        '
        'mnuFileReportASR
        '
        Me.mnuFileReportASR.Name = "mnuFileReportASR"
        Me.mnuFileReportASR.Size = New System.Drawing.Size(282, 26)
        Me.mnuFileReportASR.Text = "Asset Summary Report"
        '
        'mnuTransactionSummaryReport
        '
        Me.mnuTransactionSummaryReport.Name = "mnuTransactionSummaryReport"
        Me.mnuTransactionSummaryReport.Size = New System.Drawing.Size(282, 26)
        Me.mnuTransactionSummaryReport.Text = "Transaction Summary Report"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewWarranty, Me.mnuViewActionHistory})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(55, 24)
        Me.mnuView.Text = "View"
        '
        'mnuViewWarranty
        '
        Me.mnuViewWarranty.Name = "mnuViewWarranty"
        Me.mnuViewWarranty.Size = New System.Drawing.Size(186, 26)
        Me.mnuViewWarranty.Text = "Warranty"
        '
        'mnuViewActionHistory
        '
        Me.mnuViewActionHistory.Name = "mnuViewActionHistory"
        Me.mnuViewActionHistory.Size = New System.Drawing.Size(186, 26)
        Me.mnuViewActionHistory.Text = "Action History"
        '
        'Frm_AssetHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 794)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.msp)
        Me.MainMenuStrip = Me.msp
        Me.Name = "Frm_AssetHome"
        Me.Text = "Asset"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpLocal.ResumeLayout(False)
        Me.grpLocal.PerformLayout()
        Me.grpThirdParty.ResumeLayout(False)
        Me.grpThirdParty.PerformLayout()
        CType(Me.picCOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvTransactionLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msp.ResumeLayout(False)
        Me.msp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblType As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblCOT As Label
    Friend WithEvents lblRDD As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblCondition As Label
    Friend WithEvents lblSerial As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblManu As Label
    Friend WithEvents lblDesc As Label
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
    Friend WithEvents lblWarrantyExpDate As Label
    Friend WithEvents lblWarrantyId As Label
    Friend WithEvents lblInvoice As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblVendor As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpDateOfAcquisition As DateTimePicker
    Friend WithEvents msp As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileGenerateReport As ToolStripMenuItem
    Friend WithEvents mnuFileReportASR As ToolStripMenuItem
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuViewWarranty As ToolStripMenuItem
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvTransactionLog As DataGridView
    Friend WithEvents grpThirdParty As GroupBox
    Friend WithEvents txt3rdEmail As TextBox
    Friend WithEvents txt3rdContact As TextBox
    Friend WithEvents txt3rdDesc As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents grpLocal As GroupBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents picCOT As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents mnuViewActionHistory As ToolStripMenuItem
    Friend WithEvents mnuTransactionSummaryReport As ToolStripMenuItem
End Class
