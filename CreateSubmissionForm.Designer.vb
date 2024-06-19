<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        btnToggleStopwatch = New Button()
        lblStopwatchTime = New Label()
        btnSubmit = New Button()
        timerStopwatch = New Timer(components)
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        txtGithubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        SuspendLayout()
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.DarkKhaki
        btnToggleStopwatch.Location = New Point(190, 363)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(191, 23)
        btnToggleStopwatch.TabIndex = 4
        btnToggleStopwatch.Text = "Toggle Stopwatch"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(480, 366)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(49, 15)
        lblStopwatchTime.TabIndex = 10
        lblStopwatchTime.Text = "00:00:00"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.CornflowerBlue
        btnSubmit.Location = New Point(366, 417)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(163, 23)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' timerStopwatch
        ' 
        timerStopwatch.Interval = 1000
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(410, 295)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(301, 23)
        TextBox4.TabIndex = 25
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(410, 219)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(301, 23)
        TextBox3.TabIndex = 24
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(410, 149)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(301, 23)
        TextBox2.TabIndex = 23
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(410, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(301, 23)
        TextBox1.TabIndex = 22
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(218, 295)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(123, 23)
        txtGithubLink.TabIndex = 21
        txtGithubLink.Text = "Github Link For Task 2"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(227, 219)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(100, 23)
        txtPhone.TabIndex = 20
        txtPhone.Text = "Phone Number"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(227, 149)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(100, 23)
        txtEmail.TabIndex = 19
        txtEmail.Text = "Email"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(227, 89)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 18
        txtName.Text = "Name"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnToggleStopwatch)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents timerStopwatch As Timer
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
End Class
