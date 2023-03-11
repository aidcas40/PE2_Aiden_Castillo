<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.pctAllegroLogo = New System.Windows.Forms.PictureBox()
        Me.prgbrSplashScreen = New System.Windows.Forms.ProgressBar()
        Me.tmrSplashScreen = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.lblLoadingPercent = New System.Windows.Forms.Label()
        Me.lblAllegro = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        CType(Me.pctAllegroLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctAllegroLogo
        '
        Me.pctAllegroLogo.BackgroundImage = CType(resources.GetObject("pctAllegroLogo.BackgroundImage"), System.Drawing.Image)
        Me.pctAllegroLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctAllegroLogo.InitialImage = CType(resources.GetObject("pctAllegroLogo.InitialImage"), System.Drawing.Image)
        Me.pctAllegroLogo.Location = New System.Drawing.Point(329, 80)
        Me.pctAllegroLogo.Name = "pctAllegroLogo"
        Me.pctAllegroLogo.Size = New System.Drawing.Size(141, 128)
        Me.pctAllegroLogo.TabIndex = 0
        Me.pctAllegroLogo.TabStop = False
        '
        'prgbrSplashScreen
        '
        Me.prgbrSplashScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.prgbrSplashScreen.Location = New System.Drawing.Point(0, 427)
        Me.prgbrSplashScreen.Name = "prgbrSplashScreen"
        Me.prgbrSplashScreen.Size = New System.Drawing.Size(801, 27)
        Me.prgbrSplashScreen.TabIndex = 1
        '
        'tmrSplashScreen
        '
        Me.tmrSplashScreen.Enabled = True
        Me.tmrSplashScreen.Interval = 20
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLoading.Location = New System.Drawing.Point(12, 408)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(69, 16)
        Me.lblLoading.TabIndex = 2
        Me.lblLoading.Text = "Loading..."
        '
        'lblLoadingPercent
        '
        Me.lblLoadingPercent.AutoSize = True
        Me.lblLoadingPercent.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingPercent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLoadingPercent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLoadingPercent.Location = New System.Drawing.Point(745, 408)
        Me.lblLoadingPercent.Name = "lblLoadingPercent"
        Me.lblLoadingPercent.Size = New System.Drawing.Size(43, 16)
        Me.lblLoadingPercent.TabIndex = 3
        Me.lblLoadingPercent.Text = "000%"
        '
        'lblAllegro
        '
        Me.lblAllegro.AutoSize = True
        Me.lblAllegro.BackColor = System.Drawing.Color.Transparent
        Me.lblAllegro.Font = New System.Drawing.Font("Inter", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllegro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAllegro.Location = New System.Drawing.Point(358, 227)
        Me.lblAllegro.Name = "lblAllegro"
        Me.lblAllegro.Size = New System.Drawing.Size(82, 25)
        Me.lblAllegro.TabIndex = 4
        Me.lblAllegro.Text = "Allegro"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblVersion.Location = New System.Drawing.Point(383, 265)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(32, 16)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "v1.0"
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 454)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblAllegro)
        Me.Controls.Add(Me.lblLoadingPercent)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.prgbrSplashScreen)
        Me.Controls.Add(Me.pctAllegroLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allegro"
        CType(Me.pctAllegroLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctAllegroLogo As PictureBox
    Friend WithEvents prgbrSplashScreen As ProgressBar
    Friend WithEvents tmrSplashScreen As Timer
    Friend WithEvents lblLoading As Label
    Friend WithEvents lblLoadingPercent As Label
    Friend WithEvents lblAllegro As Label
    Friend WithEvents lblVersion As Label
End Class
