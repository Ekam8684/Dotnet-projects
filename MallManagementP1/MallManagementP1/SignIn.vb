

Imports System.Data.OleDb

Public Class SignIn
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim Myconnection As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub SignIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MallManagementDataSet3.UserDataTable' table. You can move, or remove it, as needed.
        Me.UserDataTableTableAdapter.Fill(Me.MallManagementDataSet3.UserDataTable)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pro = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ekam\Documents\Visual Studio 2010\Projects\MallManagementP1\MallManagement.accdb"
        connstring = pro
        Myconnection.ConnectionString = connstring
        Myconnection.Open()
        command = " insert into UserDataTable ([FirstName],[LastName],[email],[Password]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        cmd = New OleDbCommand(command, Myconnection)
        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("email", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(TextBox4.Text, String)))
        MsgBox("|| Record Save ||")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            Myconnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            Form2.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Myconnection.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UserDataTableBindingSource.AddNew()
    End Sub
End Class