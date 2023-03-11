Public Class frmSplashScreen
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrSplashScreen.Start()
    End Sub

    Private Sub tmrSplashScreen_Tick(sender As Object, e As EventArgs) Handles tmrSplashScreen.Tick
        Dim percentComplete As Integer = prgbrSplashScreen.Value + 1

        ' Use Invoke to update the progress bar control on the UI thread
        Me.Invoke(Sub()
                      prgbrSplashScreen.Value = percentComplete
                      lblLoadingPercent.Text = percentComplete & "%"

                      If percentComplete > 20 Then
                          lblLoading.Text = "Loading... Please wait"
                      End If

                      If percentComplete > 50 Then
                          lblLoading.Text = "Loading... Almost there"
                      End If

                      If percentComplete = 100 Then
                          lblLoading.Text = "Launching Application"
                          tmrSplashScreen.Dispose()
                      End If
                  End Sub)
    End Sub
End Class
