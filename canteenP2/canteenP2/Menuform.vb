Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb.OleDbCommand

Public Class Menuform
    Dim conn As OleDbConnection
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim reader As DataRelation
    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PizzaBtn.Click
        Pizzaform.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BurgerBtn.Click
        Burgerform.Show()
    End Sub
    Private Sub SandwichBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SandwichBtn.Click
        Sandwichform.Show()
    End Sub
    Private Sub PastaBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PastaBtn.Click
        Pastaform.Show()
    End Sub
    Private Sub DrinksBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrinksBtn.Click
        Drinksform.Show()
    End Sub
    Private Sub DessertBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DessertBtn.Click
        Dessertformvb.Show()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CartForm.Show()
    End Sub
    Private Sub Menuform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection
     
    End Sub
End Class