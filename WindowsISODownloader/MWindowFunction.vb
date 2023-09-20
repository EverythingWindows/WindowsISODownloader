Module MWindowFunction

    Public DownloadLink As String

    Public Sub InsertDownload(Link As String, Desc As String)
        Form1.Button1.Enabled = True
        DownloadLink = Link
        Form1.Label5.Text = Desc
    End Sub
End Module
