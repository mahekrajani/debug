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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtid = New TextBox()
        txtname = New TextBox()
        txttype = New TextBox()
        txtsourse = New TextBox()
        txtdestination = New TextBox()
        comcapacity = New ComboBox()
        btninsert = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        btnshow = New Button()
        Label7 = New Label()
        Label8 = New Label()
        txtrsourse = New TextBox()
        txtrdestination = New TextBox()
        btnreport = New Button()
        btnstod = New Button()
        datagridview = New DataGridView()
        CType(datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label1.Location = New Point(62, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "flight id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label2.Location = New Point(62, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 0
        Label2.Text = "flight name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label3.Location = New Point(62, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 20)
        Label3.TabIndex = 0
        Label3.Text = "type"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label4.Location = New Point(62, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 0
        Label4.Text = "capacity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label5.Location = New Point(62, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 0
        Label5.Text = "sourse"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label6.Location = New Point(62, 295)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 20)
        Label6.TabIndex = 0
        Label6.Text = "destination"
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(177, 57)
        txtid.Name = "txtid"
        txtid.Size = New Size(151, 23)
        txtid.TabIndex = 1
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(177, 106)
        txtname.Name = "txtname"
        txtname.Size = New Size(151, 23)
        txtname.TabIndex = 1
        ' 
        ' txttype
        ' 
        txttype.Location = New Point(177, 149)
        txttype.Name = "txttype"
        txttype.Size = New Size(151, 23)
        txttype.TabIndex = 1
        ' 
        ' txtsourse
        ' 
        txtsourse.Location = New Point(177, 242)
        txtsourse.Name = "txtsourse"
        txtsourse.Size = New Size(151, 23)
        txtsourse.TabIndex = 1
        ' 
        ' txtdestination
        ' 
        txtdestination.Location = New Point(177, 295)
        txtdestination.Name = "txtdestination"
        txtdestination.Size = New Size(151, 23)
        txtdestination.TabIndex = 1
        ' 
        ' comcapacity
        ' 
        comcapacity.FormattingEnabled = True
        comcapacity.Location = New Point(177, 198)
        comcapacity.Name = "comcapacity"
        comcapacity.Size = New Size(151, 23)
        comcapacity.TabIndex = 2
        ' 
        ' btninsert
        ' 
        btninsert.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btninsert.Location = New Point(62, 377)
        btninsert.Name = "btninsert"
        btninsert.Size = New Size(75, 34)
        btninsert.TabIndex = 3
        btninsert.Text = "insert"
        btninsert.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnupdate.Location = New Point(143, 377)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(90, 34)
        btnupdate.TabIndex = 3
        btnupdate.Text = "update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btndelete.Location = New Point(239, 377)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(75, 34)
        btndelete.TabIndex = 3
        btndelete.Text = "delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btnshow
        ' 
        btnshow.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnshow.Location = New Point(320, 377)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(75, 34)
        btnshow.TabIndex = 3
        btnshow.Text = "show"
        btnshow.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label7.Location = New Point(450, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 20)
        Label7.TabIndex = 0
        Label7.Text = "sourse"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label8.Location = New Point(693, 60)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 20)
        Label8.TabIndex = 0
        Label8.Text = "destination"
        ' 
        ' txtrsourse
        ' 
        txtrsourse.Location = New Point(520, 57)
        txtrsourse.Name = "txtrsourse"
        txtrsourse.Size = New Size(151, 23)
        txtrsourse.TabIndex = 1
        ' 
        ' txtrdestination
        ' 
        txtrdestination.Location = New Point(787, 57)
        txtrdestination.Name = "txtrdestination"
        txtrdestination.Size = New Size(151, 23)
        txtrdestination.TabIndex = 1
        ' 
        ' btnreport
        ' 
        btnreport.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnreport.Location = New Point(665, 109)
        btnreport.Name = "btnreport"
        btnreport.Size = New Size(82, 34)
        btnreport.TabIndex = 3
        btnreport.Text = "report"
        btnreport.UseVisualStyleBackColor = True
        ' 
        ' btnstod
        ' 
        btnstod.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnstod.Location = New Point(355, 198)
        btnstod.Name = "btnstod"
        btnstod.Size = New Size(82, 93)
        btnstod.TabIndex = 3
        btnstod.Text = "surat to delhi"
        btnstod.UseVisualStyleBackColor = True
        ' 
        ' datagridview
        ' 
        datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        datagridview.Location = New Point(462, 152)
        datagridview.Name = "datagridview"
        datagridview.Size = New Size(488, 410)
        datagridview.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(962, 574)
        Controls.Add(datagridview)
        Controls.Add(btnstod)
        Controls.Add(btnreport)
        Controls.Add(btnshow)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btninsert)
        Controls.Add(comcapacity)
        Controls.Add(txtdestination)
        Controls.Add(txtsourse)
        Controls.Add(txttype)
        Controls.Add(txtname)
        Controls.Add(txtrdestination)
        Controls.Add(txtrsourse)
        Controls.Add(txtid)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txttype As TextBox
    Friend WithEvents txtsourse As TextBox
    Friend WithEvents txtdestination As TextBox
    Friend WithEvents comcapacity As ComboBox
    Friend WithEvents btninsert As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtrsourse As TextBox
    Friend WithEvents txtrdestination As TextBox
    Friend WithEvents btnreport As Button
    Friend WithEvents btnstod As Button
    Friend WithEvents datagridview As DataGridView




End Class
