Module MWindowFunction

    Public DownloadLink As String

    Public Sub InsertDownload(Link As String, Desc As String)
        Form1.Button1.Enabled = True
        DownloadLink = Link
        Form1.Label5.Text = Desc
    End Sub

    Public Sub AddItem(ChooseCB As Integer, CBItem As String)
        Select Case ChooseCB
            Case 2
                Form1.ComboBox2.Items.Add(CBItem)
            Case 3
                Form1.ComboBox3.Items.Add(CBItem)
            Case 4
                Form1.ComboBox4.Items.Add(CBItem)
        End Select
    End Sub
End Module
