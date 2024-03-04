Friend Class SqlDataAdapter
    Private cmd As SqlCommand

    Public Sub New(cmd As SqlCommand)
        Me.cmd = cmd
    End Sub
End Class
