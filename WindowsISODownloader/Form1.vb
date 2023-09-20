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
                ComboBox2.Items.Add("Windows 11")
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
                        ComboBox3.Items.Add("21996.1")
                        ComboBox3.Items.Add("22000.9")
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
        End Select
    End Sub
End Class
