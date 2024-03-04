<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        btndelete = New Button()
        btninsert = New Button()
        btnupdate = New Button()
        btnshow = New Button()
        Button1 = New Button()
        Button2 = New Button()
        btnreport = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(41, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 21)
        Label1.TabIndex = 0
        Label1.Text = "itemno"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(41, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 21)
        Label2.TabIndex = 0
        Label2.Text = "name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(41, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 21)
        Label3.TabIndex = 0
        Label3.Text = "cost"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(41, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 21)
        Label4.TabIndex = 0
        Label4.Text = "quantity"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(135, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(158, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(135, 108)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(158, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(135, 145)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(158, 23)
        TextBox3.TabIndex = 1
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(135, 186)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(158, 23)
        TextBox4.TabIndex = 1
        ' 
        ' btndelete
        ' 
        btndelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btndelete.Location = New Point(25, 325)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(75, 31)
        btndelete.TabIndex = 2
        btndelete.Text = "delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btninsert
        ' 
        btninsert.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btninsert.Location = New Point(25, 251)
        btninsert.Name = "btninsert"
        btninsert.Size = New Size(75, 31)
        btninsert.TabIndex = 2
        btninsert.Text = "insert"
        btninsert.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnupdate.Location = New Point(145, 251)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(75, 31)
        btnupdate.TabIndex = 2
        btnupdate.Text = "update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btnshow
        ' 
        btnshow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnshow.Location = New Point(145, 325)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(75, 31)
        btnshow.TabIndex = 2
        btnshow.Text = "show"
        btnshow.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(25, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 31)
        Button1.TabIndex = 2
        Button1.Text = "delete"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.Location = New Point(25, 251)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 31)
        Button2.TabIndex = 2
        Button2.Text = "insert"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnreport
        ' 
        btnreport.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnreport.Location = New Point(84, 381)
        btnreport.Name = "btnreport"
        btnreport.Size = New Size(75, 31)
        btnreport.TabIndex = 2
        btnreport.Text = "Report"
        btnreport.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(360, 70)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(415, 342)
        DataGridView1.TabIndex = 3
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnshow)
        Controls.Add(btnupdate)
        Controls.Add(Button2)
        Controls.Add(btnreport)
        Controls.Add(Button1)
        Controls.Add(btninsert)
        Controls.Add(btndelete)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btninsert As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
