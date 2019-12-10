Public Class FormMenu

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventarisDataSet1.tbinventaris' table. You can move, or remove it, as needed.
        Me.TbinventarisTableAdapter1.Fill(Me.InventarisDataSet1.tbinventaris)
        'TODO: This line of code loads data into the 'InventarisDataSet.tbinventaris' table. You can move, or remove it, as needed.
        Me.TbinventarisTableAdapter.Fill(Me.InventarisDataSet.tbinventaris)
        Kode_barangTextBox.Enabled = False
        Nama_barangTextBox.Enabled = False
        Jumlah_barangTextBox.Enabled = False
        Harga_barangTextBox.Enabled = False
        Sisa_barangTextBox.Enabled = False
    End Sub

    Private Sub btadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btadd.Click
        Kode_barangTextBox.Enabled = True
        Nama_barangTextBox.Enabled = True
        Jumlah_barangTextBox.Enabled = True
        Harga_barangTextBox.Enabled = True
        Sisa_barangTextBox.Enabled = True
        Me.TbinventarisBindingSource1.AddNew()
    End Sub

    Private Sub btfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdetele.Click
        Me.TbinventarisBindingSource1.RemoveCurrent()
    End Sub

    Private Sub btbottom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbottom.Click
        Me.Validate()
        Me.TbinventarisBindingSource1.EndEdit()
        Me.TbinventarisTableAdapter1.Update(Me.InventarisDataSet1)
        TableAdapterManager1.UpdateAll(Me.InventarisDataSet1)
        Kode_barangTextBox.Enabled = False
        Nama_barangTextBox.Enabled = False
        Jumlah_barangTextBox.Enabled = False
        Harga_barangTextBox.Enabled = False
        Sisa_barangTextBox.Enabled = False
    End Sub

    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        Kode_barangTextBox.Enabled = True
        Nama_barangTextBox.Enabled = True
        Jumlah_barangTextBox.Enabled = True
        Harga_barangTextBox.Enabled = True
        Sisa_barangTextBox.Enabled = True
    End Sub

    Private Sub Kode_barangTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kode_barangTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Report.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "Kode" Then
            Me.TbinventarisBindingSource1.Filter = "kode_barang like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox1.Text = "Nama" Then
            Me.TbinventarisBindingSource1.Filter = "nama_barang like '%" & TextBox1.Text & "%'"
        End If
    End Sub
End Class