Imports IWshRuntimeLibrary
Public Class frmSettings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.PiHoleURL = txtPiHoleURL.Text
        My.Settings.AuthKey = txtAuthKey.Text
        My.Settings.UpdateInterval = trkUpdateInterval.Value

        'To create Start shortcut in the windows Startup folder: 
        Dim UserStartupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim ShortCutLnk As String = UserStartupFolder & "\ManHole.lnk"

        'Add shortcut.
        Dim WSHC As WshShell = New WshShell
        Dim ShortCut As IWshRuntimeLibrary.IWshShortcut

        'Setting autostart
        If chkAutoStart.Checked = True Then
            My.Settings.AutoStart = True

            ShortCut = CType(WSHC.CreateShortcut(ShortCutLnk), IWshRuntimeLibrary.IWshShortcut)
            ShortCut.TargetPath = Application.StartupPath & "\ManHole.exe"
            ShortCut.Save()
        Else
            'To delete the shortcut:
            If IO.File.Exists(ShortCutLnk) Then
                IO.File.Delete(ShortCutLnk)
            End If
            My.Settings.AutoStart = False
            End If
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

        If My.Settings.AutoStart.ToString = False Then
            chkAutoStart.Checked = False
        ElseIf My.Settings.AutoStart.ToString = True Then
            chkAutoStart.Checked = True
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