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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        RichTextBox1 = New System.Windows.Forms.RichTextBox()
        btnopenfile = New Button()
        btnfont = New Button()
        btnsavefile = New Button()
        btnprint = New Button()
        btncolor = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        FontDialog1 = New FontDialog()
        ColorDialog1 = New ColorDialog()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 12)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(776, 328)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' btnopenfile
        ' 
        btnopenfile.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnopenfile.Location = New Point(12, 357)
        btnopenfile.Name = "btnopenfile"
        btnopenfile.Size = New Size(108, 47)
        btnopenfile.TabIndex = 1
        btnopenfile.Text = "openfile"
        btnopenfile.UseVisualStyleBackColor = True
        ' 
        ' btnfont
        ' 
        btnfont.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnfont.Location = New Point(323, 357)
        btnfont.Name = "btnfont"
        btnfont.Size = New Size(108, 47)
        btnfont.TabIndex = 1
        btnfont.Text = "font"
        btnfont.UseVisualStyleBackColor = True
        ' 
        ' btnsavefile
        ' 
        btnsavefile.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsavefile.Location = New Point(170, 357)
        btnsavefile.Name = "btnsavefile"
        btnsavefile.Size = New Size(108, 47)
        btnsavefile.TabIndex = 1
        btnsavefile.Text = "savefile"
        btnsavefile.UseVisualStyleBackColor = True
        ' 
        ' btnprint
        ' 
        btnprint.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnprint.Location = New Point(645, 357)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(108, 47)
        btnprint.TabIndex = 1
        btnprint.Text = "print"
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' btncolor
        ' 
        btncolor.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btncolor.Location = New Point(491, 357)
        btncolor.Name = "btncolor"
        btncolor.Size = New Size(108, 47)
        btncolor.TabIndex = 1
        btncolor.Text = "color"
        btncolor.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 416)
        Controls.Add(btncolor)
        Controls.Add(btnprint)
        Controls.Add(btnsavefile)
        Controls.Add(btnfont)
        Controls.Add(btnopenfile)
        Controls.Add(RichTextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnopenfile As Button
    Friend WithEvents btnfont As Button
    Friend WithEvents btnsavefile As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btncolor As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

End Class
