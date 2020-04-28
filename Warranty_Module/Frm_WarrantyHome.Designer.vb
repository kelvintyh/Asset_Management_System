<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_WarrantyHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_WarrantyHome))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.gBoxList = New System.Windows.Forms.GroupBox()
        Me.btPrint = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBoxList.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(28, 74)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(896, 370)
        Me.dgv.TabIndex = 5
        '
        'gBoxList
        '
        Me.gBoxList.Controls.Add(Me.btPrint)
        Me.gBoxList.Controls.Add(Me.btEdit)
        Me.gBoxList.Controls.Add(Me.btDelete)
        Me.gBoxList.Controls.Add(Me.btAdd)
        Me.gBoxList.Controls.Add(Me.lbCount)
        Me.gBoxList.Controls.Add(Me.tbSearch)
        Me.gBoxList.Controls.Add(Me.dgv)
        Me.gBoxList.Location = New System.Drawing.Point(24, 22)
        Me.gBoxList.Name = "gBoxList"
        Me.gBoxList.Size = New System.Drawing.Size(952, 510)
        Me.gBoxList.TabIndex = 6
        Me.gBoxList.TabStop = False
        Me.gBoxList.Text = "Item List"
        '
        'btPrint
        '
        Me.btPrint.Location = New System.Drawing.Point(652, 453)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(72, 42)
        Me.btPrint.TabIndex = 11
        Me.btPrint.Text = "Print"
        Me.btPrint.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Image = Global.Asset_Management_System.My.Resources.Resources.Pencil_25px
        Me.btEdit.Location = New System.Drawing.Point(809, 450)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(50, 44)
        Me.btEdit.TabIndex = 10
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Image = Global.Asset_Management_System.My.Resources.Resources.Delete_25px
        Me.btDelete.Location = New System.Drawing.Point(874, 451)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(50, 44)
        Me.btDelete.TabIndex = 9
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Image = Global.Asset_Management_System.My.Resources.Resources.Plus_Math_25px
        Me.btAdd.Location = New System.Drawing.Point(742, 451)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(50, 44)
        Me.btAdd.TabIndex = 8
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'lbCount
        '
        Me.lbCount.AutoSize = True
        Me.lbCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbCount.Location = New System.Drawing.Point(25, 462)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(61, 18)
        Me.lbCount.TabIndex = 7
        Me.lbCount.Text = "Counter"
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbSearch.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.tbSearch.Location = New System.Drawing.Point(28, 30)
        Me.tbSearch.Multiline = True
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(233, 32)
        Me.tbSearch.TabIndex = 6
        Me.tbSearch.Text = "Search with ID or Name"
        '
        'PrintDocument
        '
        Me.PrintDocument.DocumentName = ".pdf"
        '
        'PrintDialog
        '
        Me.PrintDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintDialog.Enabled = True
        Me.PrintDialog.Icon = CType(resources.GetObject("PrintDialog.Icon"), System.Drawing.Icon)
        Me.PrintDialog.Name = "PrintDialog"
        Me.PrintDialog.Visible = False
        '
        'Frm_WarrantyHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(999, 548)
        Me.Controls.Add(Me.gBoxList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Frm_WarrantyHome"
        Me.Text = "Warranty "
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBoxList.ResumeLayout(False)
        Me.gBoxList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents gBoxList As GroupBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents lbCount As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintDialog As PrintPreviewDialog
    Friend WithEvents btPrint As Button
End Class
