Imports System.Data.OleDb

Module ModuleConfig
    Public CONN As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public DR As OleDbDataReader
    Public DT As DataTable
    Public LokasiData As String

    Public Sub Koneksi()
        LokasiData = "Provider = Microsoft.JET.OLEDB.4.0; Data Source=|DataDirectory|\dblogin.mdb;"
        CONN = New OleDbConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()

        End If
    End Sub
End Module
