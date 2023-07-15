<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Loading))
        Label1 = New Label()
        Timer1 = New Timer(components)
        ProgressBar1 = New ProgressBar()
        Timer2 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Papyrus", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(324, 30)
        Label1.TabIndex = 0
        Label1.Text = "LOADING, PLEASE WAIT!"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 3800
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 50)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(324, 23)
        ProgressBar1.Step = 1
        ProgressBar1.TabIndex = 1
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 30
        ' 
        ' Loading
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 85)
        ControlBox = False
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Loading"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fact generator Loading"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer2 As Timer
End Class
