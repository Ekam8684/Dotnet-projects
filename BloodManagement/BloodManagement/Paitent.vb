Imports System.Data.OleDb


Public Class Paitent

    Dim SqlPath As String
    Dim command As String
    Dim Conn As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbCommand
    Dim DataADP As OleDbDataAdapter
    Dim DataTbl As DataTable
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form2.Show()

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Donate.Show()

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()

    End Sub
   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SqlPath = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ekam\Documents\Visual Studio 2010\Projects\WindowsApplication1\BloodBank.accdb"
        Conn.ConnectionString = SqlPath
        Conn.Open()
        command = " insert into Donors ([Name1],[Age],[Phone],[Gender],[BloodGroup],[Address]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "')"
        cmd = New OleDbCommand(command, Conn)
        cmd.Parameters.Add(New OleDbParameter("Name1", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Age", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("BloodGroup", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(TextBox4.Text, String)))
        MsgBox("Save")
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Conn.Close()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        SqlPath = "Select * from Donors "
        DataADP = New OleDbDataAdapter(SqlPath, Conn)
        DataTbl = New DataTable
        DataADP.Fill(DataTbl)
        DataGridView1.DataSource = DataTbl
        Conn.Close()
    End Sub
End Class