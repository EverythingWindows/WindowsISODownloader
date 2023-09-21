Imports System.IO

Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.SelectedItem = Nothing
        ComboBox3.SelectedItem = Nothing
        ComboBox4.SelectedItem = Nothing
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        Select Case ComboBox1.SelectedItem
            Case "Client"
                AddItem(2, "Windows 1")
            Case "Client Beta"

        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.SelectedItem = Nothing
        ComboBox4.SelectedItem = Nothing
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox3.Enabled = True
        ComboBox4.Enabled = False
        Select Case ComboBox1.SelectedItem
            Case "Client"
                Select Case ComboBox2.SelectedItem
                    Case "Windows 1"
                        AddItem(3, "1.01")
                        AddItem(3, "1.02")
                        AddItem(3, "1.03")
                        AddItem(3, "1.04")
                End Select
            Case "Client Beta"
                Select Case ComboBox2.SelectedItem
                    Case "Nickel"

                    Case "Zinc"

                End Select
        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.SelectedItem = Nothing
        ComboBox4.Items.Clear()
        ComboBox4.Enabled = True
        Select Case ComboBox1.SelectedItem
            Case "Client"
                Select Case ComboBox2.SelectedItem
                    Case "Windows 1"
                        Select Case ComboBox3.SelectedItem
                            Case "1.01"

                        End Select
                End Select
            Case "Client Beta"

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(DownloadLink)
    End Sub
End Class
