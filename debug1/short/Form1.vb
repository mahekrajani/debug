Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\Documents\debug.net\debug1\short\Database1.mdf;Integrated Security=True")
    Sub fillgrid()
        Dim cmd As New SqlCommand("select*from tbl_demo", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "demo")
        DataGridView1.DataSource = ds.Tables("demo")
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        fillgrid()
    End Sub

    Private Sub b_Click(sender As Object, e As EventArgs) Handles b.Click
        Dim cmd As New SqlConnection("insert into tbl_demo values(@id,@name)", con)
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtid.Text
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("record inserted")
        fillgrid()
    End Sub

End Class
