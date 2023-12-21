Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand


Public Class RefreshPage


    Dim conn As OleDbConnection
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim reader As DataRelation
    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abc\OneDrive\Documents\Database3.accdb"
        conn.Open()
        Sql = "Delete * from Cart "
        da = New OleDbDataAdapter(Sql, conn)
        dt = New DataTable
        da.Fill(dt)
        conn.Close()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class