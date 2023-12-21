
Imports System.Data.OleDb



Public Class Donate


    Dim SqlPath As String
    Dim command As String
    Dim Conn As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbCommand
    Dim DataADP As OleDbDataAdapter
    Dim DataTbl As DataTable


    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form2.Show()
    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SqlPath = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ekam\Documents\Visual Studio 2010\Projects\WindowsApplication1\BloodBank.accdb"
        Conn.ConnectionString = SqlPath
        Conn.Open()
        command = " insert into Donate ([Name1],[BloodGroup]) values ('" & TextBox1.Text & "','" & ComboBox1.Text & "')"
        cmd = New OleDbCommand(command, Conn)
        cmd.Parameters.Add(New OleDbParameter("Name1", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(ComboBox1.Text, String)))
        MsgBox("Save")
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Conn.Close()
        SqlPath = "Select * from Donate "
        DataADP = New OleDbDataAdapter(SqlPath, Conn)
        DataTbl = New DataTable
        DataADP.Fill(DataTbl)
        DataGridView1.DataSource = DataTbl
        Conn.Close()
    End Sub

    Private Sub Donate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class