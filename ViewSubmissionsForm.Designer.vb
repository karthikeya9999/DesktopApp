<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        components = New ComponentModel.Container()
        Button1 = New Button()
        btnPrevious = New Button()
        btnNext = New Button()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        lbIStopwatchTime = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        lblStopwatchTime = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 10
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.IndianRed
        btnPrevious.Location = New Point(232, 417)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(135, 23)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.CornflowerBlue
        btnNext.Location = New Point(463, 419)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(141, 23)
        btnNext.TabIndex = 12
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(276, 68)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 14
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(276, 130)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 15
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(260, 192)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(86, 15)
        lblPhone.TabIndex = 16
        lblPhone.Text = "Phone number"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(245, 259)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(122, 15)
        lblGithubLink.TabIndex = 17
        lblGithubLink.Text = "Github Link For Task 2"
        ' 
        ' lbIStopwatchTime
        ' 
        lbIStopwatchTime.AutoSize = True
        lbIStopwatchTime.Location = New Point(260, 331)
        lbIStopwatchTime.Name = "lbIStopwatchTime"
        lbIStopwatchTime.Size = New Size(90, 15)
        lbIStopwatchTime.TabIndex = 18
        lbIStopwatchTime.Text = "Stopwatch time"
        lbIStopwatchTime.Visible = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(435, 68)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(283, 23)
        txtName.TabIndex = 20
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(435, 127)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(283, 23)
        txtEmail.TabIndex = 21
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(435, 192)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(283, 23)
        txtPhone.TabIndex = 22
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(435, 259)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(283, 23)
        txtGithubLink.TabIndex = 23
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Location = New Point(435, 328)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.ReadOnly = True
        lblStopwatchTime.Size = New Size(283, 23)
        lblStopwatchTime.TabIndex = 24
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lbIStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Button1)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lbIStopwatchTime As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblStopwatchTime As TextBox
End Class
