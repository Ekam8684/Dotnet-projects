
Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand
Public Class CartForm
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
        sql = "Update cart set Total = ItemPrice * ItemQuantity "
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).DefaultCellStyle.Font = New Font("Copperplate Gothic", 10, FontStyle.Bold)
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).DefaultCellStyle.Font = New Font("Copperplate Gothic", 10, FontStyle.Bold)
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).DefaultCellStyle.Font = New Font("Copperplate Gothic", 10, FontStyle.Bold)
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).DefaultCellStyle.Font = New Font("Copperplate Gothic", 10, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 100
        sql = "Select sum(Total) from Cart "
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView2.DataSource = dt
        sql = "Select * from Cart "
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = False
        PictureBox1.Visible = True
        PictureBox2.Visible = False
    End Sub
    Private Sub CartForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CanteenP2DataSet5.Cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.CanteenP2DataSet5.Cart)
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        PictureBox1.Visible = False
        conn = New OleDbConnection

    End Sub


End Class