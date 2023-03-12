Public Class frmSplashScreen
    'Starts timer when the form loads
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrSplashScreen.Start()
    End Sub

    'Creating function for the progress bar and various changing text
    Private Sub UpdateProgressBar(percentComplete As Integer)
        If Me.IsHandleCreated Then
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
        End If
    End Sub

    'Using function created for the duration of the timer
    Private Sub tmrSplashScreen_Tick(sender As Object, e As EventArgs) Handles tmrSplashScreen.Tick
        Dim percentComplete As Integer = prgbrSplashScreen.Value + 1
        UpdateProgressBar(percentComplete)
    End Sub
End Class
