

Public Class AddPerson
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
