Imports System.Data.SqlClient
Imports System.Data
Public Class Form2
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\Documents\debug.net\debug1\remode\remode\remode\Database2.mdf;Integrated Security=True")
    Sub fillgrid()
        Dim cmd As New SqlCommand("select*from tbl_item", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        fillgrid()
    End Sub
End Class


