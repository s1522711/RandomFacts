
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Form1
    Public Class GlobalVariables
        Public Shared Lang As String
        Public Shared DeDayFact As String = "none"
        Public Shared EnDayFact As String = "none"
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EnSel.Checked = True Then
            GlobalVariables.Lang = "en"
            TextBox1.Text = "LOADING, PLEASE WAIT"
        ElseIf DeSel.Checked = True Then
            GlobalVariables.Lang = "de"
            TextBox1.Text = "LADEN, BITTE WARTEN"
        End If

        Timer1.Start()
        '"https://uselessfacts.jsph.pl/api/v2/facts/random?language=en"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        '"https://uselessfacts.jsph.pl/api/v2/facts/random?language=en"

        Dim html As String

        Using webClient As New WebClient
            If RanFact.Checked = True Then
                html = webClient.DownloadString("https://uselessfacts.jsph.pl/api/v2/facts/random?language=" + GlobalVariables.Lang)
            Else
                If GlobalVariables.DeDayFact = "none" Or GlobalVariables.EnDayFact = "none" Then
                    html = webClient.DownloadString("https://uselessfacts.jsph.pl/api/v2/facts/today?language=" + GlobalVariables.Lang)
                    If EnSel.Checked = True Then
                        GlobalVariables.EnDayFact = html
                    ElseIf DeSel.Checked = True Then
                        GlobalVariables.DeDayFact = html
                    End If
                ElseIf EnSel.Checked = True Then
                    html = GlobalVariables.EnDayFact
                ElseIf DeSel.Checked = True Then
                    html = GlobalVariables.DeDayFact
                End If
            End If
            Debug.WriteLine(html)
            TextBox1.Text = html
        End Using

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim parsejson As JObject = JObject.Parse(html)
        Dim output = parsejson.SelectToken("text").ToString()
        TextBox1.Text = output
    End Sub

    Private Sub DeSel_CheckedChanged(sender As Object, e As EventArgs) Handles DeSel.CheckedChanged
        GroupBox1.Text = "Language"
        Button1.Text = "Holen Sie sich Tatsachen!"
        Button1.Width = "195"
        Button1.Height = "30"
        TextBox1.Location = New Point(213, 12)
        Width = "553"
        GroupBox1.Width = "195"
        TextBox1.Text = "Bitte drücken Sie die Taste, um zu starten!"
        Text = "Faktengenerator"
        GroupBox2.Width = "195"
        GroupBox2.Text = "Faktentyp"
        RanFact.Text = "Zufälliger Fakt"
        DayFact.Text = "Fakt des Tages"
    End Sub

    Private Sub EnSel_CheckedChanged(sender As Object, e As EventArgs) Handles EnSel.CheckedChanged
        GroupBox1.Text = "Sprache"
        Button1.Text = "Get Fact!"
        Button1.Width = "143"
        Button1.Height = "30"
        TextBox1.Location = New Point(165, 12)
        Width = "508"
        GroupBox1.Width = "147"
        TextBox1.Text = "Please Press The Button to Start!"
        Text = "Fact Generator"
        GroupBox2.Width = "147"
        GroupBox2.Text = "Fact Type"
        RanFact.Text = "Random Fact"
        DayFact.Text = "Fact of the Day"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
    End Sub
    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        LaunchLangSel.Close()
    End Sub
End Class
