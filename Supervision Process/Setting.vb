

Public Class Setting
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TrackBar1.Scroll
        Label8.Text = TrackBar1.Value.ToString + "%"
    End Sub

    Private Sub Setting_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
        Label8.Text = TrackBar1.Value.ToString + "%"
    End Sub
End Class
