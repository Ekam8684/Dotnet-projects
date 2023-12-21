
Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand

Public Class Dessertformvb

    Dim conn As OleDbConnection
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim reader As DataRelation
    Dim sql As String
    Dim a As Integer

    Private Sub Dessertformvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection
    End Sub
    Private Sub AddToCartBtnDE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDE1.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Choco pancake',300," & ComboBox1.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox1.SelectedItem > 0 Then
            MessageBox.Show(Label1.Text & " :- " & ComboBox1.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnDE2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDE2.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"

        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Molten cake',450," & ComboBox2.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox2.SelectedItem > 0 Then
            MessageBox.Show(Label4.Text & " :- " & ComboBox2.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnDE3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDE3.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Donuts',350," & ComboBox3.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox3.SelectedItem > 0 Then
            MessageBox.Show(Label7.Text & " :- " & ComboBox3.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnDE4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDE4.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Vanilla ice cream',450," & ComboBox5.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox5.SelectedItem > 0 Then
            MessageBox.Show(Label13.Text & " :- " & ComboBox5.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnDE5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDE5.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Fruit  Cake',450," & ComboBox4.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox4.SelectedItem > 0 Then
            MessageBox.Show(Label10.Text & " :- " & ComboBox4.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnDE6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnDE6.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Strawberry macaron',150," & ComboBox6.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox6.SelectedItem > 0 Then
            MessageBox.Show(Label16.Text & " :- " & ComboBox6.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        conn.Open()
        sql = "select * from Cart  "
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CartForm.Show()

    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()

    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()

    End Sub

End Class