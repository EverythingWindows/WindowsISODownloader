Imports System.IO

Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.SelectedItem = Nothing
        ComboBox3.SelectedItem = Nothing
        ComboBox4.SelectedItem = Nothing
        Select Case ComboBox1.SelectedItem
            Case "Client"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Windows 10")
            Case "Client Beta"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Nickel")
                ComboBox2.Items.Add("Zinc")
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.SelectedItem = Nothing
        ComboBox4.SelectedItem = Nothing
        Select Case ComboBox1.SelectedItem
            Case "Client"
                Select Case ComboBox2.SelectedItem
                    Case "Windows 10"
                        ComboBox3.Items.Clear()
                        ComboBox3.Items.Add("22H2")
                End Select
            Case "Client Beta"
                Select Case ComboBox2.SelectedItem
                    Case "Nickel"
                        ComboBox3.Items.Clear()
                        ComboBox3.Items.Add("21380")
                        ComboBox3.Items.Add("21996.1")
                        ComboBox3.Items.Add("22000.9")
                    Case "Zinc"
                        ComboBox3.Items.Clear()
                        ComboBox3.Items.Add("25267 (partner build)")
                End Select
        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.SelectedItem = Nothing
        Select Case ComboBox1.SelectedItem
            Case "Client"
                Select Case ComboBox2.SelectedItem
                    Case "Windows 10"
                        Select Case ComboBox3.SelectedItem
                            Case "22H2"
                                ComboBox4.Items.Clear()
                                ComboBox4.Items.Add("x64")
                        End Select
                End Select
            Case "Client Beta"
                Select Case ComboBox2.SelectedItem
                    Case "Nickel"
                        Select Case ComboBox3.SelectedItem
                            Case "21380"
                                ComboBox4.Items.Clear()
                                ComboBox4.Enabled = False
                                InsertDownload("https://archive.org/download/Win11Build21380/21380.1001.210511-1900.fs_dev6_flt_CLIENT_CONSUMER_x64FRE_en-us.iso", "Windows 11 build 21380 is a build of Windows 11 that was leaked on 2023. This build is first seen in Hong Kong Computer Festival back in 2021.")
                            Case "21996.1"
                                ComboBox4.Items.Clear()
                                ComboBox4.Enabled = False
                                InsertDownload("https://archive.org/download/windows11_21996.1.210529-1541.co-release-client-consumer-x-64-fre-en-us-2/21996.1.210529-1541.co_release_CLIENT_CONSUMER_x64FRE_en-us_2.iso", "Windows 11 build 21996.1 is the first Windows 11 build leaked to the public on June 2021. The build includes the Bloom background, Widgets, and several others.")
                        End Select
                    Case "Zinc"
                        Select Case ComboBox3.SelectedItem
                            Case "25267 (partner build)"
                                ComboBox4.Items.Clear()
                                ComboBox4.Enabled = False
                                InsertDownload("https://archive.org/download/win11-partner-25267-wdatp-edr/25267.1001.amd64fre.rs_wdatp_edr.221212-0900_client_cliententerprise_en-us.ISO", "TBD")
                        End Select
                End Select
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(DownloadLink)
    End Sub
End Class
