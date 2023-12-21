
Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand
Public Class Sandwichform
    Dim conn As OleDbConnection
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim reader As DataRelation
    Dim sql As String
    Dim a As Integer
    Private Sub Sandwichform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn = New OleDbConnection
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        conn.Open()
        sql = "select * from Cart "
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

        DataGridView1.Columns(0).Width = 190
        conn.Close()
    End Sub
    Private Sub AddToCartBtnS1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnS1.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Tandoori Sandwich',140," & ComboBox2.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox2.SelectedItem > 0 Then
            MessageBox.Show(Label2.Text & " :- " & ComboBox2.SelectedItem, " Sandwich ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnS2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnS2.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Chicken sandwich',120," & ComboBox3.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox3.SelectedItem > 0 Then
            MessageBox.Show(Label3.Text & " :- " & ComboBox3.SelectedItem, "Sandwich ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnS3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnS3.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Griled sandwich',350," & ComboBox4.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox4.SelectedItem > 0 Then
            MessageBox.Show(Label10.Text & " :- " & ComboBox4.SelectedItem, "Sandwich ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnS4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnS4.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Veg Chesse Sandwich',450," & ComboBox1.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox1.SelectedItem > 0 Then
            MessageBox.Show(Label1.Text & " :- " & ComboBox1.SelectedItem, "Sandwich ")
        End If
        conn.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        CartForm.Show()

    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class