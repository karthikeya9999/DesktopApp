Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim client As New HttpClient()
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = lblStopwatchTime.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
        Dim responseString = Await response.Content.ReadAsStringAsync()
        MessageBox.Show("Submission successful!")
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            btnToggleStopwatch.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
