<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim Kode_barangLabel As System.Windows.Forms.Label
        Dim Nama_barangLabel As System.Windows.Forms.Label
        Dim Jumlah_barangLabel As System.Windows.Forms.Label
        Dim Harga_barangLabel As System.Windows.Forms.Label
        Dim Sisa_barangLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.InventarisDataSet = New Aplikasi_Inventaris_Barang.inventarisDataSet()
        Me.TbinventarisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbinventarisTableAdapter = New Aplikasi_Inventaris_Barang.inventarisDataSetTableAdapters.tbinventarisTableAdapter()
        Me.TableAdapterManager = New Aplikasi_Inventaris_Barang.inventarisDataSetTableAdapters.TableAdapterManager()
        Me.btdetele = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.btadd = New System.Windows.Forms.Button()
        Me.btbottom = New System.Windows.Forms.Button()
        Me.Kode_barangTextBox = New System.Windows.Forms.TextBox()
        Me.TbinventarisBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarisDataSet1 = New Aplikasi_Inventaris_Barang.inventarisDataSet1()
        Me.Nama_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Jumlah_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Sisa_barangTextBox = New System.Windows.Forms.TextBox()
        Me.TbinventarisDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbinventarisTableAdapter1 = New Aplikasi_Inventaris_Barang.inventarisDataSet1TableAdapters.tbinventarisTableAdapter()
        Me.TableAdapterManager1 = New Aplikasi_Inventaris_Barang.inventarisDataSet1TableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Kode_barangLabel = New System.Windows.Forms.Label()
        Nama_barangLabel = New System.Windows.Forms.Label()
        Jumlah_barangLabel = New System.Windows.Forms.Label()
        Harga_barangLabel = New System.Windows.Forms.Label()
        Sisa_barangLabel = New System.Windows.Forms.Label()
        CType(Me.InventarisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbinventarisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbinventarisBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarisDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbinventarisDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kode_barangLabel
        '
        Kode_barangLabel.AutoSize = True
        Kode_barangLabel.Location = New System.Drawing.Point(155, 15)
        Kode_barangLabel.Name = "Kode_barangLabel"
        Kode_barangLabel.Size = New System.Drawing.Size(70, 13)
        Kode_barangLabel.TabIndex = 21
        Kode_barangLabel.Text = "kode barang:"
        '
        'Nama_barangLabel
        '
        Nama_barangLabel.AutoSize = True
        Nama_barangLabel.Location = New System.Drawing.Point(155, 41)
        Nama_barangLabel.Name = "Nama_barangLabel"
        Nama_barangLabel.Size = New System.Drawing.Size(72, 13)
        Nama_barangLabel.TabIndex = 23
        Nama_barangLabel.Text = "nama barang:"
        '
        'Jumlah_barangLabel
        '
        Jumlah_barangLabel.AutoSize = True
        Jumlah_barangLabel.Location = New System.Drawing.Point(155, 67)
        Jumlah_barangLabel.Name = "Jumlah_barangLabel"
        Jumlah_barangLabel.Size = New System.Drawing.Size(76, 13)
        Jumlah_barangLabel.TabIndex = 25
        Jumlah_barangLabel.Text = "jumlah barang:"
        '
        'Harga_barangLabel
        '
        Harga_barangLabel.AutoSize = True
        Harga_barangLabel.Location = New System.Drawing.Point(155, 93)
        Harga_barangLabel.Name = "Harga_barangLabel"
        Harga_barangLabel.Size = New System.Drawing.Size(73, 13)
        Harga_barangLabel.TabIndex = 27
        Harga_barangLabel.Text = "harga barang:"
        '
        'Sisa_barangLabel
        '
        Sisa_barangLabel.AutoSize = True
        Sisa_barangLabel.Location = New System.Drawing.Point(155, 119)
        Sisa_barangLabel.Name = "Sisa_barangLabel"
        Sisa_barangLabel.Size = New System.Drawing.Size(64, 13)
        Sisa_barangLabel.TabIndex = 29
        Sisa_barangLabel.Text = "sisa barang:"
        '
        'InventarisDataSet
        '
        Me.InventarisDataSet.DataSetName = "inventarisDataSet"
        Me.InventarisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbinventarisBindingSource
        '
        Me.TbinventarisBindingSource.DataMember = "tbinventaris"
        Me.TbinventarisBindingSource.DataSource = Me.InventarisDataSet
        '
        'TbinventarisTableAdapter
        '
        Me.TbinventarisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbinventarisTableAdapter = Me.TbinventarisTableAdapter
        Me.TableAdapterManager.UpdateOrder = Aplikasi_Inventaris_Barang.inventarisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btdetele
        '
        Me.btdetele.Location = New System.Drawing.Point(12, 99)
        Me.btdetele.Name = "btdetele"
        Me.btdetele.Size = New System.Drawing.Size(75, 23)
        Me.btdetele.TabIndex = 19
        Me.btdetele.Text = "Delete"
        Me.btdetele.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(12, 70)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 23)
        Me.btedit.TabIndex = 18
        Me.btedit.Text = "Edit"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'btadd
        '
        Me.btadd.Location = New System.Drawing.Point(12, 12)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(75, 23)
        Me.btadd.TabIndex = 17
        Me.btadd.Text = "Add"
        Me.btadd.UseVisualStyleBackColor = True
        '
        'btbottom
        '
        Me.btbottom.Location = New System.Drawing.Point(12, 41)
        Me.btbottom.Name = "btbottom"
        Me.btbottom.Size = New System.Drawing.Size(75, 23)
        Me.btbottom.TabIndex = 21
        Me.btbottom.Text = "Update"
        Me.btbottom.UseVisualStyleBackColor = True
        '
        'Kode_barangTextBox
        '
        Me.Kode_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinventarisBindingSource1, "kode_barang", True))
        Me.Kode_barangTextBox.Location = New System.Drawing.Point(237, 12)
        Me.Kode_barangTextBox.Name = "Kode_barangTextBox"
        Me.Kode_barangTextBox.Size = New System.Drawing.Size(113, 20)
        Me.Kode_barangTextBox.TabIndex = 22
        '
        'TbinventarisBindingSource1
        '
        Me.TbinventarisBindingSource1.DataMember = "tbinventaris"
        Me.TbinventarisBindingSource1.DataSource = Me.InventarisDataSet1
        '
        'InventarisDataSet1
        '
        Me.InventarisDataSet1.DataSetName = "inventarisDataSet1"
        Me.InventarisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nama_barangTextBox
        '
        Me.Nama_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinventarisBindingSource1, "nama_barang", True))
        Me.Nama_barangTextBox.Location = New System.Drawing.Point(237, 38)
        Me.Nama_barangTextBox.Name = "Nama_barangTextBox"
        Me.Nama_barangTextBox.Size = New System.Drawing.Size(224, 20)
        Me.Nama_barangTextBox.TabIndex = 24
        '
        'Jumlah_barangTextBox
        '
        Me.Jumlah_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinventarisBindingSource1, "jumlah_barang", True))
        Me.Jumlah_barangTextBox.Location = New System.Drawing.Point(237, 64)
        Me.Jumlah_barangTextBox.Name = "Jumlah_barangTextBox"
        Me.Jumlah_barangTextBox.Size = New System.Drawing.Size(25, 20)
        Me.Jumlah_barangTextBox.TabIndex = 26
        '
        'Harga_barangTextBox
        '
        Me.Harga_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinventarisBindingSource1, "harga_barang", True))
        Me.Harga_barangTextBox.Location = New System.Drawing.Point(237, 90)
        Me.Harga_barangTextBox.Name = "Harga_barangTextBox"
        Me.Harga_barangTextBox.Size = New System.Drawing.Size(142, 20)
        Me.Harga_barangTextBox.TabIndex = 28
        '
        'Sisa_barangTextBox
        '
        Me.Sisa_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbinventarisBindingSource1, "sisa_barang", True))
        Me.Sisa_barangTextBox.Location = New System.Drawing.Point(237, 116)
        Me.Sisa_barangTextBox.Name = "Sisa_barangTextBox"
        Me.Sisa_barangTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Sisa_barangTextBox.TabIndex = 30
        '
        'TbinventarisDataGridView
        '
        Me.TbinventarisDataGridView.AutoGenerateColumns = False
        Me.TbinventarisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbinventarisDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TbinventarisDataGridView.DataSource = Me.TbinventarisBindingSource1
        Me.TbinventarisDataGridView.Location = New System.Drawing.Point(12, 204)
        Me.TbinventarisDataGridView.Name = "TbinventarisDataGridView"
        Me.TbinventarisDataGridView.Size = New System.Drawing.Size(775, 233)
        Me.TbinventarisDataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "kode_barang"
        Me.DataGridViewTextBoxColumn1.HeaderText = "kode_barang"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_barang"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "jumlah_barang"
        Me.DataGridViewTextBoxColumn3.HeaderText = "jumlah_barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "harga_barang"
        Me.DataGridViewTextBoxColumn4.HeaderText = "harga_barang"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sisa_barang"
        Me.DataGridViewTextBoxColumn5.HeaderText = "sisa_barang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(237, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Search"
        '
        'TbinventarisTableAdapter1
        '
        Me.TbinventarisTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbinventarisTableAdapter = Me.TbinventarisTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Aplikasi_Inventaris_Barang.inventarisDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Kode", "Nama"})
        Me.ComboBox1.Location = New System.Drawing.Point(237, 143)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(467, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 449)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TbinventarisDataGridView)
        Me.Controls.Add(Kode_barangLabel)
        Me.Controls.Add(Me.Kode_barangTextBox)
        Me.Controls.Add(Nama_barangLabel)
        Me.Controls.Add(Me.Nama_barangTextBox)
        Me.Controls.Add(Jumlah_barangLabel)
        Me.Controls.Add(Me.Jumlah_barangTextBox)
        Me.Controls.Add(Harga_barangLabel)
        Me.Controls.Add(Me.Harga_barangTextBox)
        Me.Controls.Add(Sisa_barangLabel)
        Me.Controls.Add(Me.Sisa_barangTextBox)
        Me.Controls.Add(Me.btbottom)
        Me.Controls.Add(Me.btdetele)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.btadd)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        CType(Me.InventarisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbinventarisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbinventarisBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarisDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbinventarisDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InventarisDataSet As Aplikasi_Inventaris_Barang.inventarisDataSet
    Friend WithEvents TbinventarisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbinventarisTableAdapter As Aplikasi_Inventaris_Barang.inventarisDataSetTableAdapters.tbinventarisTableAdapter
    Friend WithEvents TableAdapterManager As Aplikasi_Inventaris_Barang.inventarisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btdetele As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents btadd As System.Windows.Forms.Button
    Friend WithEvents btbottom As System.Windows.Forms.Button
    Friend WithEvents InventarisDataSet1 As Aplikasi_Inventaris_Barang.inventarisDataSet1
    Friend WithEvents TbinventarisBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TbinventarisTableAdapter1 As Aplikasi_Inventaris_Barang.inventarisDataSet1TableAdapters.tbinventarisTableAdapter
    Friend WithEvents TableAdapterManager1 As Aplikasi_Inventaris_Barang.inventarisDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Kode_barangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_barangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jumlah_barangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harga_barangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sisa_barangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TbinventarisDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
