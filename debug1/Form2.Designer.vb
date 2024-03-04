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
        TextBox1 = New TextBox()
        Button1 = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(134, 73)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(302, 34)
        TextBox1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(485, 65)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 42)
        Button1.TabIndex = 8
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"bca", "bcom", "ba", "bsc"})
        ListBox1.Location = New Point(134, 137)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(550, 154)
        ListBox1.TabIndex = 9
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1139, 407)
        Controls.Add(ListBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
