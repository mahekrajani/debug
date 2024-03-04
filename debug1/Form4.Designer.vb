<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(103, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 28)
        Label1.TabIndex = 0
        Label1.Text = "ENTER NUMBER :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(297, 104)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 25)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(437, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 25)
        TextBox2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.MenuHighlight
        Button1.Location = New Point(103, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 47)
        Button1.TabIndex = 3
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
