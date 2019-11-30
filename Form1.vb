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



        If My.Computer.FileSystem.FileExists("doEverything.reg") Then
            MsgBox("doEverything Resources Exist! Skipping File creation")
        Else
            MsgBox("doEverything Resource Files Were Created")
            Dim doeverythingfile As System.IO.StreamWriter
            doeverythingfile = My.Computer.FileSystem.OpenTextFileWriter("doEverything.reg", True)
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



        If My.Computer.FileSystem.FileExists("hideCortanaButton.reg") Then
            MsgBox("Cortana Resources Exist! Skipping File creation")
        Else
            MsgBox("Cortana Resource Files Were Created")
            Dim cortanafile As System.IO.StreamWriter
            cortanafile = My.Computer.FileSystem.OpenTextFileWriter("hideCortanaButton.reg", True)
            cortanafile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced]
""ShowCortanaButton""=dword:00000000")
            cortanafile.Close()
        End If


        If My.Computer.FileSystem.FileExists("disableStartInternetSearch.reg") Then
            MsgBox("Search Resources Exist! Skipping File creation")
        Else
            MsgBox("Search Resource Files Were Created")
            Dim searchfile As System.IO.StreamWriter
            searchfile = My.Computer.FileSystem.OpenTextFileWriter("disableStartInternetSearch.reg", True)
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






        If My.Computer.FileSystem.FileExists("hidePeopleButton.reg") Then
            MsgBox("People Resources Exist! Skipping File creation")
        Else
            MsgBox("People Resource Files Were Created")
            Dim peoplefile As System.IO.StreamWriter
            peoplefile = My.Computer.FileSystem.OpenTextFileWriter("hidePeopleButton.reg", True)
            peoplefile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People]
""PeopleBand""=dword:00000000")
            peoplefile.Close()
        End If



        If My.Computer.FileSystem.FileExists("showTaskViewbutton.reg") Then
            MsgBox("Taskview Resources Exist! Skipping File creation")
        Else
            MsgBox("Taskview Resource Files Were Created")
            Dim taskviewfile As System.IO.StreamWriter
            taskviewfile = My.Computer.FileSystem.OpenTextFileWriter("showTaskViewButton.reg", True)
            taskviewfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced]
""ShowTaskViewButton""=dword:00000000")
            taskviewfile.Close()
        End If


        If My.Computer.FileSystem.FileExists("showTaskTreyIcons.reg") Then
            MsgBox("Tasktrey Resources Exist! Skipping File creation")
        Else
            MsgBox("Tasktrey Resource Files Were Created")
            Dim tasktreyfile As System.IO.StreamWriter
            tasktreyfile = My.Computer.FileSystem.OpenTextFileWriter("showTaskTreyIcons.reg", True)
            tasktreyfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer]
""EnableAutoTray""=dword:00000000")
            tasktreyfile.Close()
        End If



        If My.Computer.FileSystem.FileExists("hideSearchBox.reg") Then
            MsgBox("hideSearchBox Resources Exist! Skipping File creation")
        Else
            MsgBox("hideSearchBox Resource Files Were Created")
            Dim searchboxfile As System.IO.StreamWriter
            searchboxfile = My.Computer.FileSystem.OpenTextFileWriter("hideSearchBox.reg", True)
            searchboxfile.WriteLine("Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Search]
""SearchboxTaskbarMode""=dword:00000001")
            searchboxfile.Close()
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
        Process.Start("doEverything.reg")
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RemoveCortana_Click(sender As Object, e As EventArgs) Handles RemoveCortana.Click

        Process.Start("hideCortanaButton.reg")

    End Sub

    Private Sub ShowTaskTreyIcons_Click(sender As Object, e As EventArgs) Handles ShowTaskTreyIcons.Click
        Process.Start("showTaskTreyIcons.reg")
    End Sub

    Private Sub RemoveInternetSearchResults_Click(sender As Object, e As EventArgs) Handles RemoveInternetSearchResults.Click
        Process.Start("disableStartInternetSearch.reg")
    End Sub

    Private Sub RemoveTaskViewButton_Click(sender As Object, e As EventArgs) Handles RemoveTaskViewButton.Click
        Process.Start("hideTaskViewButton.reg")
    End Sub

    Private Sub RemoveInkWorkspace_Click(sender As Object, e As EventArgs) Handles RemoveInkWorkspace.Click
        Process.Start("hideWindowsInk.reg")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles hideSearchBox.Click
        Process.Start("hideSearchBox.reg")
    End Sub
End Class
