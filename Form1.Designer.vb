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
        btnCreateSubmission = New Button()
        btnViewSubmissions = New Button()
        SuspendLayout()
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.CornflowerBlue
        btnCreateSubmission.Location = New Point(330, 230)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(219, 54)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.DarkGoldenrod
        btnViewSubmissions.Location = New Point(330, 105)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(219, 54)
        btnViewSubmissions.TabIndex = 2
        btnViewSubmissions.Text = "View Submissions"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateSubmission)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnViewSubmissions As Button

End Class
