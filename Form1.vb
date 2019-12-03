Imports System.IO
Imports ControlzEx.Standard

Public Class formMain
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label_About_Content.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Main_Title_LeftSide.Click

    End Sub


    Private Sub ButtonClickToStart_Click(sender As Object, e As EventArgs) Handles ButtonClickToStart.Click
        Panel_Active_Marker_LeftSide.Width = Button_Project_LeftSide.Width - 20
        Panel_Active_Marker_LeftSide.Left = Button_Project_LeftSide.Left + 10
        Panel_Project_Content.Visible = True
        Panel_About_Content.Visible = False
        Panel_Extras_Content.Visible = False
        Panel_Startup_Center.Visible = False



        If My.Computer.FileSystem.FileExists("resources\doEverything.reg") Then

        Else

            My.Computer.FileSystem.CreateDirectory(
  "resources")
            Dim doeverythingfile As System.IO.StreamWriter
            doeverythingfile = My.Computer.FileSystem.OpenTextFileWriter("resources\doEverything.reg", True)
            doeverythingfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search]
""CortanaConsent""=dword:00000000
""AllowSearchToUseLocation""=dword:00000000
""BingSearchEnabled""=dword:00000000

[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search]
""ConnectedSearchUseWebOverMeteredConnections""=dword:00000000
""AllowCortana""=dword:00000000
""DisableWebSearch""=dword:00000001
""ConnectedSearchUseWeb""=dword:00000000

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced]
""ShowCortanaButton""=dword:00000000

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People]
""PeopleBand""=dword:00000000

[HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Search]
""SearchboxTaskbarMode""=dword:00000001

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced]
""ShowTaskViewButton""=dword:00000000

[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsInkWorkspace]
""AllowWindowsInkWorkspace""=dword:00000000

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer]
""EnableAutoTray""=dword:00000000")
            doeverythingfile.Close()
        End If



        If My.Computer.FileSystem.FileExists("resources\hideCortanaButton.reg") Then

        Else

            Dim cortanafile As System.IO.StreamWriter
            cortanafile = My.Computer.FileSystem.OpenTextFileWriter("resources\hideCortanaButton.reg", True)
            cortanafile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced]
""ShowCortanaButton""=dword:00000000")
            cortanafile.Close()
        End If


        If My.Computer.FileSystem.FileExists("resources\disableStartInternetSearch.reg") Then

        Else

            Dim searchfile As System.IO.StreamWriter
            searchfile = My.Computer.FileSystem.OpenTextFileWriter("resources\disableStartInternetSearch.reg", True)
            searchfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search]
""CortanaConsent""=dword:00000000
""AllowSearchToUseLocation""=dword:00000000
""BingSearchEnabled""=dword:00000000

[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search]
""ConnectedSearchUseWebOverMeteredConnections""=dword:00000000
""AllowCortana""=dword:00000000
""DisableWebSearch""=dword:00000001
""ConnectedSearchUseWeb""=dword:00000000")
            searchfile.Close()
        End If


        If My.Computer.FileSystem.FileExists("resources\hidePeopleButton.reg") Then

        Else

            Dim peoplefile As System.IO.StreamWriter
            peoplefile = My.Computer.FileSystem.OpenTextFileWriter("resources\hidePeopleButton.reg", True)
            peoplefile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People]
""PeopleBand""=dword:00000000")
            peoplefile.Close()
        End If



        If My.Computer.FileSystem.FileExists("resources\showTaskViewbutton.reg") Then

        Else

            Dim taskviewfile As System.IO.StreamWriter
            taskviewfile = My.Computer.FileSystem.OpenTextFileWriter("resources\showTaskViewButton.reg", True)
            taskviewfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced]
""ShowTaskViewButton""=dword:00000000")
            taskviewfile.Close()
        End If


        If My.Computer.FileSystem.FileExists("resources\showTaskTreyIcons.reg") Then

        Else

            Dim tasktreyfile As System.IO.StreamWriter
            tasktreyfile = My.Computer.FileSystem.OpenTextFileWriter("resources\showTaskTreyIcons.reg", True)
            tasktreyfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer]
""EnableAutoTray""=dword:00000000")
            tasktreyfile.Close()
        End If



        If My.Computer.FileSystem.FileExists("resources\hideSearchBox.reg") Then

        Else

            Dim searchboxfile As System.IO.StreamWriter
            searchboxfile = My.Computer.FileSystem.OpenTextFileWriter("resources\hideSearchBox.reg", True)
            searchboxfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Search]
""SearchboxTaskbarMode""=dword:00000001")
            searchboxfile.Close()
        End If

        If My.Computer.FileSystem.FileExists("resources\undoEverything.reg") Then

        Else


            Dim undoeverythingfile As System.IO.StreamWriter
            undoeverythingfile = My.Computer.FileSystem.OpenTextFileWriter("resources\undoEverything.reg", True)
            undoeverythingfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search]
""CortanaConsent""=dword:00000001
""AllowSearchToUseLocation""=dword:00000001
""BingSearchEnabled""=dword:00000001

[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search]
""ConnectedSearchUseWebOverMeteredConnections""=dword:00000001
""AllowCortana""=dword:00000001
""DisableWebSearch""=dword:00000000
""ConnectedSearchUseWeb""=dword:00000001

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced]
""ShowCortanaButton""=dword:00000001

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People]
""PeopleBand""=dword:00000001

[HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Search]
""SearchboxTaskbarMode""=dword:00000000

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced]
""ShowTaskViewButton""=dword:00000001

[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsInkWorkspace]
""AllowWindowsInkWorkspace""=dword:00000001

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer]
""EnableAutoTray""=dword:00000001")
            undoeverythingfile.Close()
        End If


    End Sub




    Private Sub Project_b_Click(sender As Object, e As EventArgs) Handles Button_Project_LeftSide.Click
        Panel_Active_Marker_LeftSide.Width = Button_Project_LeftSide.Width - 20
        Panel_Active_Marker_LeftSide.Left = Button_Project_LeftSide.Left + 10
        Panel_Project_Content.Visible = True
        Panel_About_Content.Visible = False
        Panel_Extras_Content.Visible = False


    End Sub

    Private Sub Button_Extras_LeftSide_Click(sender As Object, e As EventArgs) Handles Button_Extras_LeftSide.Click
        Panel_Active_Marker_LeftSide.Width = Button_Extras_LeftSide.Width - 20
        Panel_Active_Marker_LeftSide.Left = Button_Extras_LeftSide.Left + 10
        Panel_Project_Content.Visible = False
        Panel_About_Content.Visible = False
        Panel_Extras_Content.Visible = True
    End Sub

    Private Sub Button_About_LeftSide_Click(sender As Object, e As EventArgs) Handles Button_About_LeftSide.Click
        Panel_Active_Marker_LeftSide.Width = Button_About_LeftSide.Width - 20
        Panel_Active_Marker_LeftSide.Left = Button_About_LeftSide.Left + 10
        Panel_Project_Content.Visible = False
        Panel_About_Content.Visible = True
        Panel_Extras_Content.Visible = False
    End Sub

    Private Sub Panel_Active_Marker_LeftSide_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Active_Marker_LeftSide.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles justFixItButton.Click

        MsgBox("After allowing the file, please restart to apply changes!")
        Process.Start("resources\doEverything.reg")


    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RemoveCortana_Click(sender As Object, e As EventArgs) Handles RemoveCortana.Click

        Process.Start("resources\hideCortanaButton.reg")

    End Sub

    Private Sub ShowTaskTreyIcons_Click(sender As Object, e As EventArgs) Handles ShowTaskTreyIcons.Click
        Process.Start("resources\showTaskTreyIcons.reg")
    End Sub

    Private Sub RemoveInternetSearchResults_Click(sender As Object, e As EventArgs) Handles RemoveInternetSearchResults.Click
        Process.Start("resources\disableStartInternetSearch.reg")
    End Sub

    Private Sub RemoveTaskViewButton_Click(sender As Object, e As EventArgs) Handles RemoveTaskViewButton.Click
        Process.Start("resources\hideTaskViewButton.reg")
    End Sub

    Private Sub RemoveInkWorkspace_Click(sender As Object, e As EventArgs) Handles RemoveInkWorkspace.Click
        Process.Start("resources\hideWindowsInk.reg")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles hideSearchBox.Click
        Process.Start("resources\hideSearchBox.reg")
    End Sub

    Private Sub UndoEverything_Click(sender As Object, e As EventArgs) Handles undoEverything.Click
        Process.Start("resources\undoEverything.reg")
    End Sub

    Private Sub Label_Extras_Content_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)

        Using sink As New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Desktop + "\Uninstall Programs.bat", False, utf8WithoutBom)
            sink.Write("explorer ms-settings:appsfeatures")
        End Using

        Dim utf8WithoutBom2 As New System.Text.UTF8Encoding(False)

        Using sink As New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Desktop + "\Windows Update.bat", False, utf8WithoutBom2)
            sink.Write("explorer ms-settings:windowsupdate")
        End Using

        Dim utf8WithoutBom3 As New System.Text.UTF8Encoding(False)

        Using sink As New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Desktop + "\Edit Startup Programs.bat", False, utf8WithoutBom3)
            sink.Write("explorer ms-settings:startupapps")
        End Using

        Dim utf8WithoutBom4 As New System.Text.UTF8Encoding(False)

        Using sink As New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Desktop + "\Colors and Background.bat", False, utf8WithoutBom4)
            sink.Write("explorer ms-settings:personalization-background")
        End Using

        MsgBox("Completed!")

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeveloperLink.LinkClicked
        Dim url As String = “http://www.example.com“
        Process.Start(url)
    End Sub

    Private Sub GitHubLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitHubLink.LinkClicked
        Dim url2 As String = “https://github.com/qkNorris/Windows-Enhancement-Project“
        Process.Start(url2)
    End Sub

    Private Sub DocumentationLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DocumentationLink.LinkClicked
        Dim url3 As String = “https://github.com/qkNorris/Windows-Enhancement-Project/blob/master/Documentation.txt“
        Process.Start(url3)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desktopFolder As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\dragFilesHere"

        If System.IO.Directory.Exists(desktopFolder) = False Then
            Try
                System.IO.Directory.CreateDirectory(desktopFolder)

            Catch ex As Exception
                'Nothing to do
            End Try
        End If

        MsgBox("Completed!")

    End Sub
End Class
