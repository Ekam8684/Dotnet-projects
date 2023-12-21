
Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand


Public Class Soap

    Dim conn As OleDbConnection
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim reader As DataRelation
    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Soap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection
       
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Database3.accdb"
        conn.Open()
        sql = "select * from Cart "
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        conn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Database3.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Dettol',40," & ComboBox1.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Database3.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Fiama',50," & ComboBox2.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Database3.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Lux',30," & ComboBox3.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        conn.Close()
    End Sub



    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Database3.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Pear Soap',60," & ComboBox4.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Cart.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class