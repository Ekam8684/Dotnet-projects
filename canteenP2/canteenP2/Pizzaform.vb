Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand
Imports System.DBNull
Public Class Pizzaform
    Dim conn As OleDbConnection
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim reader As DataRelation
    Dim sql As String
    Dim a As Integer
    
    Private Sub Pizzaform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection
        
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        conn.Open()
        sql = "select * from Cart"
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Private Sub AddToCartBtnP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    AddToCartBtnP1.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('corn and cheese',300," & ComboBox1.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox1.SelectedItem > 0 Then
            MessageBox.Show(CornAndCheeseLabel.Text & " :- " & ComboBox1.SelectedItem, "Pizza ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnP2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnP2.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('veggies paradise',400," & ComboBox2.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox2.SelectedItem > 0 Then
            MessageBox.Show(Label4.Text & " :- " & ComboBox2.SelectedItem, "Pizza ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnP3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnP3.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('farmhouse',350," & ComboBox3.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox3.SelectedItem > 0 Then
            MessageBox.Show(Label7.Text & " :- " & ComboBox3.SelectedItem, "Pizza ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnP4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnP4.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('peppy paneer',450," & ComboBox4.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox4.SelectedItem > 0 Then
            MessageBox.Show(Label10.Text & " :- " & ComboBox4.SelectedItem, "Pizza ")
        End If
        conn.Close()

    End Sub
    Private Sub AddToCartBtnP5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnP5.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"


        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('mexican green wave',450," & ComboBox5.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox5.SelectedItem > 0 Then
            MessageBox.Show(Label13.Text & " :- " & ComboBox5.SelectedItem, "Pizza ")
        End If
        conn.Close()
    End Sub
    Private Sub AddToCartBtnP6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnP6.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('margherita',250," & ComboBox6.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox6.SelectedItem > 0 Then
            MessageBox.Show(Label16.Text & " :- " & ComboBox6.SelectedItem, "Pizza ")
        End If
        conn.Close()
    End Sub
    Private Sub Buton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Cartform.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class