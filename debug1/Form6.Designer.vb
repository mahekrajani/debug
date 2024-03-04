<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Label5 = New Label()
        txtflightid = New TextBox()
        txtflightname = New TextBox()
        txtflightcapacity = New TextBox()
        txtflightsource = New TextBox()
        comtype = New ComboBox()
        Label6 = New Label()
        txtdestination = New TextBox()
        btninsert = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        btnshow = New Button()
        btndtos = New Button()
        Label7 = New Label()
        Label8 = New Label()
        txtrsource = New TextBox()
        txtrdestination = New TextBox()
        btnrreport = New Button()
        datagridview1 = New DataGridView()
        CType(datagridview1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(43, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "FLIGHT ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(43, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 1
        Label2.Text = "FLIGHT NAME:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(43, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 2
        Label3.Text = "TYPE:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(43, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 3
        Label4.Text = "CAPACITY:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(43, 273)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 4
        Label5.Text = "SOURCE:"
        ' 
        ' txtflightid
        ' 
        txtflightid.Location = New Point(158, 52)
        txtflightid.Name = "txtflightid"
        txtflightid.Size = New Size(141, 23)
        txtflightid.TabIndex = 5
        ' 
        ' txtflightname
        ' 
        txtflightname.Location = New Point(158, 107)
        txtflightname.Name = "txtflightname"
        txtflightname.Size = New Size(141, 23)
        txtflightname.TabIndex = 6
        ' 
        ' txtflightcapacity
        ' 
        txtflightcapacity.Location = New Point(158, 216)
        txtflightcapacity.Name = "txtflightcapacity"
        txtflightcapacity.Size = New Size(141, 23)
        txtflightcapacity.TabIndex = 7
        ' 
        ' txtflightsource
        ' 
        txtflightsource.Location = New Point(158, 273)
        txtflightsource.Name = "txtflightsource"
        txtflightsource.Size = New Size(141, 23)
        txtflightsource.TabIndex = 8
        ' 
        ' comtype
        ' 
        comtype.FormattingEnabled = True
        comtype.Location = New Point(158, 157)
        comtype.Name = "comtype"
        comtype.Size = New Size(141, 23)
        comtype.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(43, 329)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 15)
        Label6.TabIndex = 10
        Label6.Text = "DESTINATION:"
        ' 
        ' txtdestination
        ' 
        txtdestination.Location = New Point(158, 329)
        txtdestination.Name = "txtdestination"
        txtdestination.Size = New Size(141, 23)
        txtdestination.TabIndex = 11
        ' 
        ' btninsert
        ' 
        btninsert.BackColor = Color.Gold
        btninsert.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btninsert.Location = New Point(43, 391)
        btninsert.Name = "btninsert"
        btninsert.Size = New Size(75, 23)
        btninsert.TabIndex = 12
        btninsert.Text = "INSERT"
        btninsert.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.Gold
        btnupdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnupdate.Location = New Point(142, 391)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(75, 23)
        btnupdate.TabIndex = 13
        btnupdate.Text = "UPDATE"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.Gold
        btndelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.Location = New Point(236, 391)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(75, 23)
        btndelete.TabIndex = 14
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnshow
        ' 
        btnshow.BackColor = Color.Gold
        btnshow.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnshow.Location = New Point(338, 391)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(75, 23)
        btnshow.TabIndex = 15
        btnshow.Text = "SHOW"
        btnshow.UseVisualStyleBackColor = False
        ' 
        ' btndtos
        ' 
        btndtos.BackColor = Color.Gold
        btndtos.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndtos.Location = New Point(338, 192)
        btndtos.Name = "btndtos"
        btndtos.Size = New Size(75, 121)
        btndtos.TabIndex = 16
        btndtos.Text = "DELHI TO SURAT"
        btndtos.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(371, 52)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 15)
        Label7.TabIndex = 17
        Label7.Text = "SOURCE:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(558, 52)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 15)
        Label8.TabIndex = 18
        Label8.Text = "DESTINATION:"
        ' 
        ' txtrsource
        ' 
        txtrsource.Location = New Point(431, 44)
        txtrsource.Name = "txtrsource"
        txtrsource.Size = New Size(121, 23)
        txtrsource.TabIndex = 19
        ' 
        ' txtrdestination
        ' 
        txtrdestination.Location = New Point(646, 44)
        txtrdestination.Name = "txtrdestination"
        txtrdestination.Size = New Size(141, 23)
        txtrdestination.TabIndex = 20
        ' 
        ' btnrreport
        ' 
        btnrreport.BackColor = Color.Gold
        btnrreport.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnrreport.Location = New Point(545, 86)
        btnrreport.Name = "btnrreport"
        btnrreport.Size = New Size(75, 23)
        btnrreport.TabIndex = 21
        btnrreport.Text = "REPORT"
        btnrreport.UseVisualStyleBackColor = False
        ' 
        ' datagridview1
        ' 
        datagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        datagridview1.Location = New Point(431, 128)
        datagridview1.Name = "datagridview1"
        datagridview1.RowTemplate.Height = 25
        datagridview1.Size = New Size(356, 286)
        datagridview1.TabIndex = 22
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(836, 462)
        Controls.Add(datagridview1)
        Controls.Add(btnrreport)
        Controls.Add(txtrdestination)
        Controls.Add(txtrsource)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(btndtos)
        Controls.Add(btnshow)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btninsert)
        Controls.Add(txtdestination)
        Controls.Add(Label6)
        Controls.Add(comtype)
        Controls.Add(txtflightsource)
        Controls.Add(txtflightcapacity)
        Controls.Add(txtflightname)
        Controls.Add(txtflightid)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form6"
        Text = "Form6"
        CType(datagridview1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtflightid As TextBox
    Friend WithEvents txtflightname As TextBox
    Friend WithEvents txtflightcapacity As TextBox
    Friend WithEvents txtflightsource As TextBox
    Friend WithEvents comtype As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdestination As TextBox
    Friend WithEvents btninsert As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents btndtos As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtrsource As TextBox
    Friend WithEvents txtrdestination As TextBox
    Friend WithEvents btnrreport As Button
    Friend WithEvents datagridview1 As DataGridView
End Class
