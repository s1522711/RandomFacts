
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Form1
    Public Class GlobalVariables
        Public Shared Lang As String
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
            html = webClient.DownloadString("https://uselessfacts.jsph.pl/api/v2/facts/random?language=" + GlobalVariables.Lang)
            Debug.WriteLine(html)
            TextBox1.Text = html
        End Using

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim parsejson As JObject = JObject.Parse(html)
        Dim output = parsejson.SelectToken("text").ToString()
        TextBox1.Text = output
    End Sub
End Class
