<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtid = New TextBox()
        txtname = New TextBox()
        b = New Button()
        btnshow = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label1.Location = New Point(62, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 25)
        Label1.TabIndex = 0
        Label1.Text = "id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label2.Location = New Point(62, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 0
        Label2.Text = "name"
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(171, 66)
        txtid.Name = "txtid"
        txtid.Size = New Size(159, 23)
        txtid.TabIndex = 1
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(171, 120)
        txtname.Name = "txtname"
        txtname.Size = New Size(159, 23)
        txtname.TabIndex = 1
        ' 
        ' b
        ' 
        b.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        b.Location = New Point(62, 214)
        b.Name = "b"
        b.Size = New Size(108, 46)
        b.TabIndex = 2
        b.Text = "insert"
        b.UseVisualStyleBackColor = True
        ' 
        ' btnshow
        ' 
        btnshow.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        btnshow.Location = New Point(195, 214)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(108, 46)
        btnshow.TabIndex = 2
        btnshow.Text = "show"
        btnshow.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(369, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(419, 360)
        DataGridView1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnshow)
        Controls.Add(b)
        Controls.Add(txtname)
        Controls.Add(txtid)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents b As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
