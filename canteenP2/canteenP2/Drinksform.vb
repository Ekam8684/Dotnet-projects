
Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand
Public Class Drinksform
    Dim conn As OleDbConnection
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim reader As DataRelation
    Dim sql As String
    Dim a As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        conn.Open()
        sql = "select * from Cart  "
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Private Sub Drinksform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection
        
    End Sub
    Private Sub AddToCartBtnDR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDR1.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Thums Up',50," & ComboBox1.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox1.SelectedItem > 0 Then
            MessageBox.Show(Label1.Text & " :- " & ComboBox1.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnD2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDR2.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Mazza',50," & ComboBox2.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox2.SelectedItem > 0 Then
            MessageBox.Show(Label2.Text & " :- " & ComboBox2.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnDR3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDR3.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Sprite',50," & ComboBox3.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox3.SelectedItem > 0 Then
            MessageBox.Show(Label2.Text & " :- " & ComboBox3.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDR4.Click

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Coca Cola',50," & ComboBox4.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox4.SelectedItem > 0 Then
            MessageBox.Show(Label4.Text & " :- " & ComboBox4.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CartForm.Show()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class