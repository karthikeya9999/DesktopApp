﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable key preview for the form to capture key events
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle Ctrl+V for View Submissions and Ctrl+N for Create New Submission
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub


    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub


    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub
End Class
