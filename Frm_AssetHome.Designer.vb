<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AssetHome
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvTransactionLog = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvBooking = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvTransactionLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 700)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dgv
        '
        Me.dgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(7, 148)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(444, 461)
        Me.dgv.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(7, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 105)
        Me.Panel1.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtSearch.Location = New System.Drawing.Point(13, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(243, 22)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "Search"
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
        Me.GroupBox2.Location = New System.Drawing.Point(475, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(820, 350)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(808, 323)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
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
        Me.TabPage1.Size = New System.Drawing.Size(800, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General info."
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.lblStatus.Location = New System.Drawing.Point(657, 30)
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
        Me.Label11.Location = New System.Drawing.Point(533, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Checked Out To : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(533, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Return Due Date : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(533, 30)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(800, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Purchase info."
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TabControl2)
        Me.GroupBox3.Location = New System.Drawing.Point(475, 362)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Size = New System.Drawing.Size(820, 350)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(6, 18)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(804, 329)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvTransactionLog)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(796, 300)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Transactions log"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvTransactionLog
        '
        Me.dgvTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionLog.Location = New System.Drawing.Point(7, 7)
        Me.dgvTransactionLog.Name = "dgvTransactionLog"
        Me.dgvTransactionLog.RowHeadersWidth = 51
        Me.dgvTransactionLog.RowTemplate.Height = 24
        Me.dgvTransactionLog.Size = New System.Drawing.Size(783, 287)
        Me.dgvTransactionLog.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvBooking)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(796, 300)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Booking"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvBooking
        '
        Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooking.Location = New System.Drawing.Point(6, 7)
        Me.dgvBooking.Name = "dgvBooking"
        Me.dgvBooking.RowHeadersWidth = 51
        Me.dgvBooking.RowTemplate.Height = 24
        Me.dgvBooking.Size = New System.Drawing.Size(780, 280)
        Me.dgvBooking.TabIndex = 0
        '
        'Frm_AssetHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 753)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_AssetHome"
        Me.Text = "Asset"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvTransactionLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
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
    Friend WithEvents dgvTransactionLog As DataGridView
    Friend WithEvents dgvBooking As DataGridView
End Class
