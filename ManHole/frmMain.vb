Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.ComponentModel
Public Class frmMain
    Private Sub Scrape()
        Try

            Dim piHoleURL As String = My.Settings.PiHoleURL.ToString
            Dim phAuthToken As String = My.Settings.AuthKey.ToString
            Dim strURL As String = piHoleURL & "api.php?summaryRaw"

            Dim strOutput As String = ""

            Dim wrResponse As WebResponse
            Dim wrRequest As WebRequest = HttpWebRequest.Create(strURL)

            wrResponse = wrRequest.GetResponse()

            Using sr As New StreamReader(wrResponse.GetResponseStream())
                strOutput = sr.ReadToEnd()
                ' Close and clean up the StreamReader
                sr.Close()
            End Using

            'Formatting Techniques

            ' Remove Doctype ( HTML 5 )
            strOutput = Regex.Replace(strOutput, "<!(.|\s)*?>", "")

            ' Remove HTML Tags
            strOutput = Regex.Replace(strOutput, "</?[a-z][a-z0-9]*[^<>]*>", "")

            ' Remove HTML Comments
            strOutput = Regex.Replace(strOutput, "<!--(.|\s)*?-->", "")

            ' Remove Script Tags
            strOutput = Regex.Replace(strOutput, "<script.*?</script>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            ' Remove Stylesheets
            strOutput = Regex.Replace(strOutput, "<style.*?</style>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            ' Remove more unwanted characters from the string
            strOutput = strOutput.Replace("{", "")
            strOutput = strOutput.Replace("}", "")
            strOutput = strOutput.Replace("""", "")
            strOutput = strOutput.Replace("_", " ")
            strOutput = strOutput.Replace(":", ": ")
            strOutput = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(strOutput)

            Dim piholeAPIarray As String()
            piholeAPIarray = strOutput.Split(",")

            Dim dict As New Dictionary(Of String, String)

            'Processing the array
            Dim strval As String = ""
            For i As Integer = 0 To piholeAPIarray.Length - 1
                strval = piholeAPIarray(i)

                dict.Add(strval.Split(": ")(0), strval.Split(": ")(1))

                If strval = "Status: Enabled" Then
                    lblPHStatus.Text = "Enabled"
                    lblPHStatus.ForeColor = Color.Green
                    mnuPHEnabled.Checked = True
                    TrayIcon.Text = "ManHole: Pi-Hole is Enabled!"
                Else
                    lblPHStatus.Text = "Disabled"
                    lblPHStatus.ForeColor = Color.Red
                    mnuPHEnabled.Checked = False
                    TrayIcon.Text = "ManHole: Pi-Hole is Disabled!"
                End If
            Next

            'Domains Being Blocked
            Dim DomainsBlocked As String = dict.Item("Domains Being Blocked")
            DomainsBlocked = FormatNumber(DomainsBlocked, 0, , , TriState.True)
            lblDomainsBlocked.Text = DomainsBlocked

            'DNS Queries Today
            Dim DNSQueriesToday As String = dict.Item("Dns Queries Today")
            DNSQueriesToday = FormatNumber(DNSQueriesToday, 0, , , TriState.True)
            lblDNSQueriesToday.Text = DNSQueriesToday

            'Ads Blocked Today
            Dim AdsBlockedToday As String = dict.Item("Ads Blocked Today")
            AdsBlockedToday = FormatNumber(AdsBlockedToday, 0, , , TriState.True)
            lblAdsBlocked.Text = AdsBlockedToday

            'Ads Percentage Today
            Dim AdsPercentageToday As String = dict.Item("Ads Percentage Today")
            AdsPercentageToday = FormatNumber(AdsPercentageToday, 0, , , TriState.True)
            prgBlocked.Value = AdsPercentageToday
            If prgBlocked.Value <= "25" Then
                prgBlocked.ForeColor = Color.Green
            ElseIf prgBlocked.Value > "25" And prgBlocked.Value <= "50" Then
                prgBlocked.ForeColor = Color.Yellow
            ElseIf prgBlocked.Value > "50" And prgBlocked.Value <= "75" Then
                prgBlocked.ForeColor = Color.Orange
            ElseIf prgBlocked.Value > "75" Then
                prgBlocked.ForeColor = Color.Red
            End If
            lblAdsPercentage.Text = AdsPercentageToday & "%"

            'Unique Domains
            Dim UniqueDomains As String = dict.Item("Unique Domains")
            UniqueDomains = FormatNumber(UniqueDomains, 0, , , TriState.True)
            lblUniqueDomains.Text = UniqueDomains

            'Queries Forwarded
            Dim QueriesForwarded As String = dict.Item("Queries Forwarded")
            QueriesForwarded = FormatNumber(QueriesForwarded, 0, , , TriState.True)
            lblQueriesForwarded.Text = QueriesForwarded

            'Queries Cached
            Dim QueriesCached As String = dict.Item("Queries Cached")
            QueriesCached = FormatNumber(QueriesCached, 0, , , TriState.True)
            lblQueriesCached.Text = QueriesCached

            'Clients Ever Seen
            Dim ClientsEverSeen As String = dict.Item("Clients Ever Seen")
            ClientsEverSeen = FormatNumber(ClientsEverSeen, 0, , , TriState.True)
            lblClientsEverSeen.Text = ClientsEverSeen

            'Unique Clients
            Dim UniqueClients As String = dict.Item("Unique Clients")
            UniqueClients = FormatNumber(UniqueClients, 0, , , TriState.True)
            lblUniqueClients.Text = UniqueClients

        Catch ex As Exception

            Console.WriteLine(ex.Message, "Error")

        End Try
    End Sub
    Private Sub RecentBlocked()
        Try

            Dim piHoleURL As String = My.Settings.PiHoleURL.ToString
            Dim phAuthToken As String = My.Settings.AuthKey.ToString
            Dim strURL As String = piHoleURL & "api.php?recentBlocked"

            Dim strOutput As String = ""

            Dim wrResponse As WebResponse
            Dim wrRequest As WebRequest = HttpWebRequest.Create(strURL)

            wrResponse = wrRequest.GetResponse()

            Using sr As New StreamReader(wrResponse.GetResponseStream())
                strOutput = sr.ReadToEnd()
                ' Close and clean up the StreamReader
                sr.Close()
            End Using

            lblRecentlyBlocked.Text = strOutput


        Catch ex As Exception

            Console.WriteLine(ex.Message, "Error")

        End Try
    End Sub

    Private Sub PHControl()
        If lblPHStatus.Text = "Enabled" Then
            Dim disablePiHole As WebRequest = HttpWebRequest.Create(My.Settings.PiHoleURL.ToString & "api.php?disable&auth=" & My.Settings.AuthKey.ToString)
            disablePiHole.GetResponse()
            tmrUpdate.Enabled = False
            btnAutoRefresh.Text = "Auto-refresh: Disabled"
            btnAutoRefresh.ForeColor = Color.Red
            mnuAutoRefresh.Checked = False
            lblPHStatus.Text = "Disabled"
            lblPHStatus.ForeColor = Color.Red
        ElseIf lblPHStatus.Text = "Disabled" Then
            Dim disablePiHole As WebRequest = HttpWebRequest.Create(My.Settings.PiHoleURL.ToString & "api.php?enable&auth=" & My.Settings.AuthKey.ToString)
            disablePiHole.GetResponse()
            tmrUpdate.Enabled = True
            btnAutoRefresh.Text = "Auto-refresh: Enabled"
            btnAutoRefresh.ForeColor = Color.Green
            mnuAutoRefresh.Checked = True
            lblPHStatus.Text = "Enabled"
            lblPHStatus.ForeColor = Color.Green
        End If
    End Sub

    Private Sub GetTopBlocked()
        Try

            Dim piHoleURL As String = My.Settings.PiHoleURL.ToString
            Dim phAuthToken As String = My.Settings.AuthKey.ToString
            Dim strURL As String = piHoleURL & "api.php?topItems=1&auth=" & My.Settings.AuthKey.ToString

            Dim strOutput As String = ""

            Dim wrResponse As WebResponse
            Dim wrRequest As WebRequest = HttpWebRequest.Create(strURL)

            wrResponse = wrRequest.GetResponse()

            Using sr As New StreamReader(wrResponse.GetResponseStream())
                strOutput = sr.ReadToEnd()
                ' Close and clean up the StreamReader
                sr.Close()
            End Using

            'Formatting Techniques

            ' Remove Doctype ( HTML 5 )
            strOutput = Regex.Replace(strOutput, "<!(.|\s)*?>", "")

            ' Remove HTML Tags
            strOutput = Regex.Replace(strOutput, "</?[a-z][a-z0-9]*[^<>]*>", "")

            ' Remove HTML Comments
            strOutput = Regex.Replace(strOutput, "<!--(.|\s)*?-->", "")

            ' Remove Script Tags
            strOutput = Regex.Replace(strOutput, "<script.*?</script>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            ' Remove Stylesheets
            strOutput = Regex.Replace(strOutput, "<style.*?</style>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            ' Remove more unwanted characters from the string
            strOutput = strOutput.Replace("{", "")
            strOutput = strOutput.Replace("}", "")
            strOutput = strOutput.Replace("""", "")
            strOutput = strOutput.Replace("_", " ")
            strOutput = strOutput.Replace(":", ": ")
            strOutput = strOutput.Replace("top queries:", "Top Queries: ")
            strOutput = strOutput.Replace("top ads:", "Top Ads: ")

            Dim piholeAPIarray As String()
            piholeAPIarray = strOutput.Split(",")

            'Processing the array
            Dim strval As String = ""
            For i As Integer = 0 To piholeAPIarray.Length - 1
                strval = piholeAPIarray(i)
                listTop.Items.Add(strval)
            Next


        Catch ex As Exception

            Console.WriteLine(ex.Message, "Error")

        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting version display info on the main window
        Me.Text = " ManHole v" & My.Application.Info.Version.ToString

        'Checking settings
        If My.Settings.AuthKey.ToString = "" Or My.Settings.PiHoleURL.ToString = "" Then
            MsgBox("This is either your first time running ManHole, or you haven't setup your Pi-Hole URL and auth key yet. The settings window will now open so you can set that up.")
            frmSettings.Show()
        End If
        If My.Settings.PiHoleURL.ToString IsNot "" Then
            lblPHAdminLink.Text = My.Settings.PiHoleURL.ToString
        End If
        'Reposition the form to the bottom right corner of the screen
        Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)

        If My.Settings.PiHoleURL.ToString IsNot "" Then
            Scrape()
            RecentBlocked()
        End If

        If My.Settings.AuthKey.ToString IsNot "" Then
            GetTopBlocked()
        End If

        If My.Settings.UpdateInterval.ToString IsNot "" Then
            tmrUpdate.Interval = My.Settings.UpdateInterval.ToString * 1000
            tmrUpdate.Enabled = True
            btnAutoRefresh.Text = "Auto-refresh: Enabled"
            btnAutoRefresh.ForeColor = Color.Green
            mnuAutoRefresh.Checked = True
        End If

        Hide()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs)
        frmSettings.Show()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Hide()
        e.Cancel = True
    End Sub

    Private Sub TrayIcon_DoubleClick(sender As Object, e As EventArgs) Handles TrayIcon.DoubleClick
        Show()
    End Sub



    Private Sub btnAbout_Click(sender As Object, e As EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub lblPHAdminLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPHAdminLink.LinkClicked
        Process.Start(lblPHAdminLink.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Scrape()
        RecentBlocked()
        If My.Settings.AuthKey.ToString IsNot "" Then
            listTop.Items.Clear()
            GetTopBlocked()
        End If
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        Scrape()
        RecentBlocked()
        If My.Settings.AuthKey.ToString IsNot "" Then
            listTop.Items.Clear()
            GetTopBlocked()
        End If
        mnuAutoRefresh.Checked = True
    End Sub

    Private Sub lblRecentlyBlocked_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRecentlyBlocked.LinkClicked
        Process.Start(lblRecentlyBlocked.Text)
    End Sub

    Private Sub btnAutoRefresh_Click(sender As Object, e As EventArgs) Handles btnAutoRefresh.Click
        If btnAutoRefresh.Text = "Auto-refresh: Disabled" And tmrUpdate.Enabled = False Then
            btnAutoRefresh.Text = "Auto-refresh: Enabled"
            btnAutoRefresh.ForeColor = Color.Green
            tmrUpdate.Enabled = True
            tmrUpdate.Start()
        ElseIf btnAutoRefresh.Text = "Auto-refresh: Enabled" And tmrUpdate.Enabled = True Then
            btnAutoRefresh.Text = "Auto-refresh: Disabled"
            btnAutoRefresh.ForeColor = Color.Red
            tmrUpdate.Enabled = False
            tmrUpdate.Stop()
        End If
    End Sub

    Private Sub TrayIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles TrayIcon.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then 'Checks if the pressed button is the Right Mouse
            TrayMenu.Show(MousePosition)
            TrayMenu.AutoClose = True
        End If
    End Sub

    Private Sub TrayMenu_MouseLeave(sender As Object, e As EventArgs) Handles TrayMenu.MouseLeave
        TrayMenu.AutoClose = True
        TrayMenu.Close()
    End Sub

    Private Sub mnuExitManHole_Click(sender As Object, e As EventArgs) Handles mnuExitManHole.Click
        TrayIcon.Visible = False
        End
    End Sub

    Private Sub mnuPHEnabled_Click(sender As Object, e As EventArgs) Handles mnuPHEnabled.Click
        PHControl()
    End Sub

    Private Sub lblPHStatus_Click(sender As Object, e As EventArgs) Handles lblPHStatus.Click
        PHControl()

    End Sub

    Private Sub mnuAutoRefresh_Click(sender As Object, e As EventArgs) Handles mnuAutoRefresh.Click
        If tmrUpdate.Enabled = True And btnAutoRefresh.Text = "Auto-refresh: Enabled" Then
            mnuAutoRefresh.Checked = False
            tmrUpdate.Enabled = False
            btnAutoRefresh.Text = "Auto-refresh: Disabled"
        ElseIf tmrUpdate.Enabled = False And btnAutoRefresh.Text = "Auto-refresh: Disabled" Then
            mnuAutoRefresh.Checked = True
            tmrUpdate.Enabled = True
            btnAutoRefresh.Text = "Auto-refresh: Enabled"
        End If
    End Sub

    Private Sub mnuSettings_Click(sender As Object, e As EventArgs) Handles mnuSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub mnuShowMainWindow_Click(sender As Object, e As EventArgs) Handles mnuShowMainWindow.Click
        Show()
    End Sub

    Private Sub btnCloseToTray_Click(sender As Object, e As EventArgs) Handles btnCloseToTray.Click
        Hide()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        frmAbout.Show()
    End Sub
End Class
