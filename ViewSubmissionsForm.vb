Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Await LoadSubmissions()
            DisplaySubmission()
        Catch ex As Exception
            MessageBox.Show("Error loading submissions: " & ex.Message)
        End Try
    End Sub

    Private Async Function LoadSubmissions() As Task
        Dim client As New HttpClient()
        Dim response = Await client.GetAsync("http://localhost:3000/read")
        If response.IsSuccessStatusCode Then
            Dim responseBody = Await response.Content.ReadAsStringAsync()
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(responseBody)
        Else
            Throw New Exception("Error loading submissions: " & response.StatusCode.ToString())
        End If
    End Function

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGithubLink.Text = submission.github_link
            lblStopwatchTime.Text = submission.stopwatch_time
        Else
            txtName.Text = String.Empty
            txtEmail.Text = String.Empty
            txtPhone.Text = String.Empty
            txtGithubLink.Text = String.Empty
            lblStopwatchTime.Text = String.Empty
            MessageBox.Show("No submissions available.")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
