Public Class frmSettings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.PiHoleURL = txtPiHoleURL.Text
        My.Settings.AuthKey = txtAuthKey.Text
        My.Settings.UpdateInterval = trkUpdateInterval.Value
        My.Settings.Save()
        Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.PiHoleURL.ToString = "" Then
            'Do nothing
        Else
            txtPiHoleURL.Text = My.Settings.PiHoleURL.ToString
        End If

        If My.Settings.AuthKey.ToString = "" Then
            'Do nothing
        Else
            txtAuthKey.Text = My.Settings.AuthKey.ToString
        End If

        If My.Settings.UpdateInterval.ToString = "" Then
            'Do nothing
        Else
            trkUpdateInterval.Value = My.Settings.UpdateInterval.ToString
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSetDefaultURL.Click
        txtPiHoleURL.Text = "http://pi.hole/admin/"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExitWithoutSave.Click
        txtPiHoleURL.Text = My.Settings.PiHoleURL.ToString
        txtAuthKey.Text = My.Settings.AuthKey.ToString
        trkUpdateInterval.Value = My.Settings.UpdateInterval.ToString
        Close()
    End Sub


    Private Sub trkUpdateInterval_ValueChanged(sender As Object, e As EventArgs) Handles trkUpdateInterval.ValueChanged
        lblInterval.Text = "ManHole will update every " & trkUpdateInterval.Value & " seconds"
    End Sub

End Class