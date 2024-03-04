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
        components = New ComponentModel.Container()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(195, 51)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(401, 74)
        ProgressBar1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(101, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 42)
        Button1.TabIndex = 1
        Button1.Text = "START"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(101, 216)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 42)
        Button2.TabIndex = 2
        Button2.Text = "STOP"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(101, 294)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 42)
        Button3.TabIndex = 3
        Button3.Text = "CLEAR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(428, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 4
        Label1.Text = "INCREMENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(428, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 25)
        Label2.TabIndex = 5
        Label2.Text = "INTERVAL"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(562, 164)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(562, 219)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 7
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
End Class
