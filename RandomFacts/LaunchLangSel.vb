Public Class LaunchLangSel
    Private Sub BtnEn_Click(sender As Object, e As EventArgs) Handles BtnEn.Click
        Form1.GroupBox1.Text = "Sprache"
        Form1.Button1.Text = "Get Fact!"
        Form1.Button1.Width = "110"
        Form1.Button1.Height = "30"
        Form1.TextBox1.Location = New Point(128, 12)
        Form1.Width = "472"
        Form1.GroupBox1.Width = "110"
        Form1.TextBox1.Text = "Please Press The Button to Start!"
        Form1.Text = "Fact Generator"
        Form1.EnSel.Checked = 1
        Form1.DeSel.Checked = 0
        Loading.Label1.Text = "LOADING, PLEASE WAIT!"
        Loading.Text = "Loading Fact generator"
        Hide()
        Loading.Timer1.Enabled = True
        Loading.Timer2.Enabled = True
        Loading.Show()
    End Sub

    Private Sub BtnDe_Click(sender As Object, e As EventArgs) Handles BtnDe.Click
        Form1.GroupBox1.Text = "Language"
        Form1.Button1.Text = "Holen Sie sich Tatsachen!"
        Form1.Button1.Width = "195"
        Form1.Button1.Height = "30"
        Form1.TextBox1.Location = New Point(213, 12)
        Form1.Width = "553"
        Form1.GroupBox1.Width = "195"
        Form1.TextBox1.Text = "Bitte drücken Sie die Taste, um zu starten!"
        Form1.Text = "Faktengenerator"
        Form1.DeSel.Checked = 1
        Form1.EnSel.Checked = 0
        Loading.Label1.Text = "LADEN, BITTE WARTEN!"
        Loading.Text = "Laden des Faktengenerators"
        Hide()
        Loading.Timer1.Enabled = True
        Loading.Timer2.Enabled = True
        Loading.Show()
    End Sub

    Private Sub LaunchLangSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
    End Sub
End Class
