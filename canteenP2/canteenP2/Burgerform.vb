

Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand
Public Class Burgerform

    Dim conn As OleDbConnection
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim reader As DataRelation
    Dim sql As String
    Dim a As Integer
        Private Sub Burgerform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CanteenP2DataSet.Cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.CanteenP2DataSet.Cart)

        conn = New OleDbConnection
        

        End Sub

   
    Private Sub AddToCartBtnB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnB1.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Cheeseslice tikki Burger',150," & ComboBox1.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox1.SelectedItem > 0 Then
            MessageBox.Show(Label1.Text & " :- " & ComboBox1.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub

    Private Sub AddToCartBtnB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnB2.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Veggie burger',100," & ComboBox4.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox4.SelectedItem > 0 Then
            MessageBox.Show(Label10.Text & " :- " & ComboBox4.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub

    Private Sub AddToCartBtnB3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnB3.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Double tikki Burger',230," & ComboBox2.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox2.SelectedItem > 0 Then
            MessageBox.Show(Label2.Text & " :- " & ComboBox2.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub

    Private Sub AddToCartBtnB4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCartBtnB4.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Visual Studio 2010\canteenP2\CanteenP2.accdb"
        com = New OleDb.OleDbCommand()
        sql = "insert into Cart values('Grilled tikki salad',170," & ComboBox3.SelectedItem & ",0)"
        com = conn.CreateCommand()
        com.CommandText = sql
        conn.Open()
        com.ExecuteNonQuery()
        If ComboBox3.SelectedItem > 0 Then
            MessageBox.Show(Label3.Text & " :- " & ComboBox3.SelectedItem, "pasta ")
        End If
        conn.Close()
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Cartform.Show()

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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class