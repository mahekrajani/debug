<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        NumericUpDown1 = New NumericUpDown()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        GroupBox3 = New GroupBox()
        TextBox3 = New TextBox()
        ListBox1 = New ListBox()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 0
        Label1.Text = "ROLL NO."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(71, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "NAME"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(150, 64)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(150, 103)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(120, 23)
        TextBox1.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(71, 142)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(214, 75)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "GENDER"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 47)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(68, 19)
        RadioButton2.TabIndex = 5
        RadioButton2.TabStop = True
        RadioButton2.Text = "FEMALE"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(56, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "MALE"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Location = New Point(71, 238)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(214, 108)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "HOBBY"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(3, 69)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(91, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "TRAVELLING"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(3, 44)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(79, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "DRAWING"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(3, 19)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(79, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "DANCING"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox3)
        GroupBox3.Controls.Add(ListBox1)
        GroupBox3.Controls.Add(ComboBox1)
        GroupBox3.Controls.Add(TextBox2)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Location = New Point(483, 86)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(267, 260)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "ADDRESS"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(93, 192)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(120, 23)
        TextBox3.TabIndex = 7
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"GUJARAT", "MUMBAI", "GOA", "UP", "MP", "PUNJAB"})
        ListBox1.Location = New Point(93, 78)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 94)
        ListBox1.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(93, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(93, 16)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(121, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 196)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 3
        Label6.Text = "PINCODE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 15)
        Label5.TabIndex = 2
        Label5.Text = "STATE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 49)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 1
        Label4.Text = "CITY"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 0
        Label3.Text = "ADDRESS"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Button1.Location = New Point(280, 380)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "SUBMIT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Button2.Location = New Point(389, 380)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "RESET"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox1)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
