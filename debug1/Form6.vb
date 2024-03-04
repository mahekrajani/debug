Imports System.Data.SqlClient
Imports System.Data


Public Class Form6
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\Documents\debug.net\debug1\Database1.mdf;Integrated Security=True")
    Sub Fillgrid()
        Dim cmd As New SqlCommand("select*from flight", con)
        Dim da As New SqlDataAddepter(cmd)
        Dim ds As New DataSet
    End Sub




    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Class SqlDataAdapter
    Private cmd As SqlCommand

    Public Sub New(cmd As SqlCommand)
        Me.cmd = cmd
    End Sub
End Class
