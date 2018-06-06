Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAboutAppTitle.Text = My.Application.Info.Title
        lblAboutVersion.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub btnAboutClose_Click(sender As Object, e As EventArgs) Handles btnAboutClose.Click
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://paypal.me/justinboughton")
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3J2L3Z4DHW9UY")
        Hide()
    End Sub
End Class