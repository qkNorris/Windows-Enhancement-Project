<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.Panel_LeftSide = New System.Windows.Forms.Panel()
        Me.Main_Title_LeftSide = New System.Windows.Forms.Label()
        Me.Main_Logo_LeftSide = New System.Windows.Forms.PictureBox()
        Me.Panel_Active_Marker_LeftSide = New System.Windows.Forms.Panel()
        Me.Button_Project_LeftSide = New System.Windows.Forms.Button()
        Me.Button_Extras_LeftSide = New System.Windows.Forms.Button()
        Me.Button_About_LeftSide = New System.Windows.Forms.Button()
        Me.Panel_Project_Content = New System.Windows.Forms.Panel()
        Me.hideSearchBox = New System.Windows.Forms.Button()
        Me.RemoveInternetSearchResults = New System.Windows.Forms.Button()
        Me.RemoveTaskViewButton = New System.Windows.Forms.Button()
        Me.ShowTaskTreyIcons = New System.Windows.Forms.Button()
        Me.RemoveInkWorkspace = New System.Windows.Forms.Button()
        Me.RemoveCortana = New System.Windows.Forms.Button()
        Me.Enchancement = New System.Windows.Forms.Label()
        Me.Project = New System.Windows.Forms.Label()
        Me.Windows = New System.Windows.Forms.Label()
        Me.justFixItButton = New System.Windows.Forms.Button()
        Me.Panel_About_Content = New System.Windows.Forms.Panel()
        Me.GitHubLink = New System.Windows.Forms.LinkLabel()
        Me.DocumentationLink = New System.Windows.Forms.LinkLabel()
        Me.DeveloperLink = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label_About_Content = New System.Windows.Forms.Label()
        Me.Panel_Extras_Content = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.undoEverything = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel_Startup_Center = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonClickToStart = New System.Windows.Forms.Button()
        Me.Panel_LeftSide.SuspendLayout()
        CType(Me.Main_Logo_LeftSide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Project_Content.SuspendLayout()
        Me.Panel_About_Content.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Extras_Content.SuspendLayout()
        Me.Panel_Startup_Center.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_LeftSide
        '
        Me.Panel_LeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel_LeftSide.Controls.Add(Me.Main_Title_LeftSide)
        Me.Panel_LeftSide.Controls.Add(Me.Main_Logo_LeftSide)
        Me.Panel_LeftSide.Controls.Add(Me.Panel_Active_Marker_LeftSide)
        Me.Panel_LeftSide.Controls.Add(Me.Button_Project_LeftSide)
        Me.Panel_LeftSide.Controls.Add(Me.Button_Extras_LeftSide)
        Me.Panel_LeftSide.Controls.Add(Me.Button_About_LeftSide)
        Me.Panel_LeftSide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_LeftSide.Location = New System.Drawing.Point(0, 0)
        Me.Panel_LeftSide.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_LeftSide.Name = "Panel_LeftSide"
        Me.Panel_LeftSide.Size = New System.Drawing.Size(1264, 681)
        Me.Panel_LeftSide.TabIndex = 0
        '
        'Main_Title_LeftSide
        '
        Me.Main_Title_LeftSide.AutoSize = True
        Me.Main_Title_LeftSide.Font = New System.Drawing.Font("Gadugi", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_Title_LeftSide.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Main_Title_LeftSide.Location = New System.Drawing.Point(108, 35)
        Me.Main_Title_LeftSide.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Main_Title_LeftSide.Name = "Main_Title_LeftSide"
        Me.Main_Title_LeftSide.Size = New System.Drawing.Size(73, 32)
        Me.Main_Title_LeftSide.TabIndex = 7
        Me.Main_Title_LeftSide.Text = "WEP"
        '
        'Main_Logo_LeftSide
        '
        Me.Main_Logo_LeftSide.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Main_Logo_LeftSide.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.LogoWPS
        Me.Main_Logo_LeftSide.Location = New System.Drawing.Point(9, 11)
        Me.Main_Logo_LeftSide.Margin = New System.Windows.Forms.Padding(2)
        Me.Main_Logo_LeftSide.Name = "Main_Logo_LeftSide"
        Me.Main_Logo_LeftSide.Size = New System.Drawing.Size(85, 85)
        Me.Main_Logo_LeftSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Main_Logo_LeftSide.TabIndex = 8
        Me.Main_Logo_LeftSide.TabStop = False
        '
        'Panel_Active_Marker_LeftSide
        '
        Me.Panel_Active_Marker_LeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel_Active_Marker_LeftSide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel_Active_Marker_LeftSide.Location = New System.Drawing.Point(817, 69)
        Me.Panel_Active_Marker_LeftSide.Name = "Panel_Active_Marker_LeftSide"
        Me.Panel_Active_Marker_LeftSide.Size = New System.Drawing.Size(112, 4)
        Me.Panel_Active_Marker_LeftSide.TabIndex = 5
        '
        'Button_Project_LeftSide
        '
        Me.Button_Project_LeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Project_LeftSide.FlatAppearance.BorderSize = 0
        Me.Button_Project_LeftSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Project_LeftSide.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Project_LeftSide.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Project_LeftSide.Location = New System.Drawing.Point(806, 35)
        Me.Button_Project_LeftSide.Name = "Button_Project_LeftSide"
        Me.Button_Project_LeftSide.Size = New System.Drawing.Size(131, 34)
        Me.Button_Project_LeftSide.TabIndex = 6
        Me.Button_Project_LeftSide.Text = "PROJECT"
        Me.Button_Project_LeftSide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Project_LeftSide.UseVisualStyleBackColor = True
        '
        'Button_Extras_LeftSide
        '
        Me.Button_Extras_LeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Extras_LeftSide.FlatAppearance.BorderSize = 0
        Me.Button_Extras_LeftSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Extras_LeftSide.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Extras_LeftSide.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Extras_LeftSide.Location = New System.Drawing.Point(934, 35)
        Me.Button_Extras_LeftSide.Name = "Button_Extras_LeftSide"
        Me.Button_Extras_LeftSide.Size = New System.Drawing.Size(119, 34)
        Me.Button_Extras_LeftSide.TabIndex = 2
        Me.Button_Extras_LeftSide.Text = "EXTRAS"
        Me.Button_Extras_LeftSide.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_Extras_LeftSide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Extras_LeftSide.UseVisualStyleBackColor = True
        '
        'Button_About_LeftSide
        '
        Me.Button_About_LeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_About_LeftSide.FlatAppearance.BorderSize = 0
        Me.Button_About_LeftSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_About_LeftSide.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_About_LeftSide.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_About_LeftSide.Location = New System.Drawing.Point(1050, 36)
        Me.Button_About_LeftSide.Name = "Button_About_LeftSide"
        Me.Button_About_LeftSide.Size = New System.Drawing.Size(112, 33)
        Me.Button_About_LeftSide.TabIndex = 4
        Me.Button_About_LeftSide.Text = "ABOUT"
        Me.Button_About_LeftSide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_About_LeftSide.UseVisualStyleBackColor = True
        '
        'Panel_Project_Content
        '
        Me.Panel_Project_Content.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel_Project_Content.Controls.Add(Me.hideSearchBox)
        Me.Panel_Project_Content.Controls.Add(Me.RemoveInternetSearchResults)
        Me.Panel_Project_Content.Controls.Add(Me.RemoveTaskViewButton)
        Me.Panel_Project_Content.Controls.Add(Me.ShowTaskTreyIcons)
        Me.Panel_Project_Content.Controls.Add(Me.RemoveInkWorkspace)
        Me.Panel_Project_Content.Controls.Add(Me.RemoveCortana)
        Me.Panel_Project_Content.Controls.Add(Me.Enchancement)
        Me.Panel_Project_Content.Controls.Add(Me.Project)
        Me.Panel_Project_Content.Controls.Add(Me.Windows)
        Me.Panel_Project_Content.Controls.Add(Me.justFixItButton)
        Me.Panel_Project_Content.Location = New System.Drawing.Point(130, 150)
        Me.Panel_Project_Content.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Project_Content.Name = "Panel_Project_Content"
        Me.Panel_Project_Content.Size = New System.Drawing.Size(1007, 466)
        Me.Panel_Project_Content.TabIndex = 2
        '
        'hideSearchBox
        '
        Me.hideSearchBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hideSearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hideSearchBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.hideSearchBox.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.searchIcon
        Me.hideSearchBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.hideSearchBox.Location = New System.Drawing.Point(605, 364)
        Me.hideSearchBox.Name = "hideSearchBox"
        Me.hideSearchBox.Size = New System.Drawing.Size(365, 49)
        Me.hideSearchBox.TabIndex = 17
        Me.hideSearchBox.Text = "Create Search Icon"
        Me.hideSearchBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hideSearchBox.UseVisualStyleBackColor = False
        '
        'RemoveInternetSearchResults
        '
        Me.RemoveInternetSearchResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveInternetSearchResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveInternetSearchResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RemoveInternetSearchResults.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.ezgif_2_05f5e5de209e
        Me.RemoveInternetSearchResults.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveInternetSearchResults.Location = New System.Drawing.Point(605, 298)
        Me.RemoveInternetSearchResults.Name = "RemoveInternetSearchResults"
        Me.RemoveInternetSearchResults.Size = New System.Drawing.Size(365, 49)
        Me.RemoveInternetSearchResults.TabIndex = 15
        Me.RemoveInternetSearchResults.Text = "Remove Internet Search Results"
        Me.RemoveInternetSearchResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveInternetSearchResults.UseVisualStyleBackColor = False
        '
        'RemoveTaskViewButton
        '
        Me.RemoveTaskViewButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveTaskViewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveTaskViewButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RemoveTaskViewButton.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.taskviewsmall1
        Me.RemoveTaskViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveTaskViewButton.Location = New System.Drawing.Point(605, 235)
        Me.RemoveTaskViewButton.Name = "RemoveTaskViewButton"
        Me.RemoveTaskViewButton.Size = New System.Drawing.Size(365, 49)
        Me.RemoveTaskViewButton.TabIndex = 14
        Me.RemoveTaskViewButton.Text = "Remove Task View Button"
        Me.RemoveTaskViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveTaskViewButton.UseVisualStyleBackColor = False
        '
        'ShowTaskTreyIcons
        '
        Me.ShowTaskTreyIcons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowTaskTreyIcons.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowTaskTreyIcons.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ShowTaskTreyIcons.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.show_hidden_icons
        Me.ShowTaskTreyIcons.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ShowTaskTreyIcons.Location = New System.Drawing.Point(49, 298)
        Me.ShowTaskTreyIcons.Name = "ShowTaskTreyIcons"
        Me.ShowTaskTreyIcons.Size = New System.Drawing.Size(366, 49)
        Me.ShowTaskTreyIcons.TabIndex = 13
        Me.ShowTaskTreyIcons.Text = "Show Task Trey Icons"
        Me.ShowTaskTreyIcons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowTaskTreyIcons.UseVisualStyleBackColor = False
        '
        'RemoveInkWorkspace
        '
        Me.RemoveInkWorkspace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveInkWorkspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveInkWorkspace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RemoveInkWorkspace.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.ink
        Me.RemoveInkWorkspace.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveInkWorkspace.Location = New System.Drawing.Point(49, 364)
        Me.RemoveInkWorkspace.Name = "RemoveInkWorkspace"
        Me.RemoveInkWorkspace.Size = New System.Drawing.Size(366, 49)
        Me.RemoveInkWorkspace.TabIndex = 16
        Me.RemoveInkWorkspace.Text = "Remove Ink Workspace"
        Me.RemoveInkWorkspace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveInkWorkspace.UseVisualStyleBackColor = False
        '
        'RemoveCortana
        '
        Me.RemoveCortana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveCortana.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveCortana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RemoveCortana.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.cortana_logo
        Me.RemoveCortana.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveCortana.Location = New System.Drawing.Point(49, 235)
        Me.RemoveCortana.Name = "RemoveCortana"
        Me.RemoveCortana.Size = New System.Drawing.Size(366, 49)
        Me.RemoveCortana.TabIndex = 9
        Me.RemoveCortana.Text = "Remove Cortana"
        Me.RemoveCortana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveCortana.UseVisualStyleBackColor = False
        '
        'Enchancement
        '
        Me.Enchancement.AutoSize = True
        Me.Enchancement.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enchancement.ForeColor = System.Drawing.Color.White
        Me.Enchancement.Location = New System.Drawing.Point(498, 20)
        Me.Enchancement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Enchancement.Name = "Enchancement"
        Me.Enchancement.Size = New System.Drawing.Size(160, 29)
        Me.Enchancement.TabIndex = 12
        Me.Enchancement.Text = "Enhancement"
        '
        'Project
        '
        Me.Project.AutoSize = True
        Me.Project.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Project.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Project.Location = New System.Drawing.Point(396, 47)
        Me.Project.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Project.Name = "Project"
        Me.Project.Size = New System.Drawing.Size(89, 21)
        Me.Project.TabIndex = 11
        Me.Project.Text = "PROJECT"
        '
        'Windows
        '
        Me.Windows.AutoSize = True
        Me.Windows.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Windows.ForeColor = System.Drawing.Color.White
        Me.Windows.Location = New System.Drawing.Point(370, 17)
        Me.Windows.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Windows.Name = "Windows"
        Me.Windows.Size = New System.Drawing.Size(131, 31)
        Me.Windows.TabIndex = 10
        Me.Windows.Text = "Windows"
        '
        'justFixItButton
        '
        Me.justFixItButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.justFixItButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.justFixItButton.FlatAppearance.BorderSize = 2
        Me.justFixItButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.justFixItButton.Font = New System.Drawing.Font("Gadugi", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.justFixItButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.justFixItButton.Location = New System.Drawing.Point(374, 82)
        Me.justFixItButton.Margin = New System.Windows.Forms.Padding(2)
        Me.justFixItButton.Name = "justFixItButton"
        Me.justFixItButton.Size = New System.Drawing.Size(276, 63)
        Me.justFixItButton.TabIndex = 1
        Me.justFixItButton.Text = "> Just fix it! <"
        Me.justFixItButton.UseVisualStyleBackColor = False
        '
        'Panel_About_Content
        '
        Me.Panel_About_Content.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel_About_Content.Controls.Add(Me.GitHubLink)
        Me.Panel_About_Content.Controls.Add(Me.DocumentationLink)
        Me.Panel_About_Content.Controls.Add(Me.DeveloperLink)
        Me.Panel_About_Content.Controls.Add(Me.Label4)
        Me.Panel_About_Content.Controls.Add(Me.Label3)
        Me.Panel_About_Content.Controls.Add(Me.PictureBox1)
        Me.Panel_About_Content.Controls.Add(Me.TextBox2)
        Me.Panel_About_Content.Controls.Add(Me.Label_About_Content)
        Me.Panel_About_Content.Location = New System.Drawing.Point(130, 150)
        Me.Panel_About_Content.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_About_Content.Name = "Panel_About_Content"
        Me.Panel_About_Content.Size = New System.Drawing.Size(1007, 464)
        Me.Panel_About_Content.TabIndex = 3
        '
        'GitHubLink
        '
        Me.GitHubLink.AutoSize = True
        Me.GitHubLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GitHubLink.LinkColor = System.Drawing.Color.White
        Me.GitHubLink.Location = New System.Drawing.Point(544, 364)
        Me.GitHubLink.Name = "GitHubLink"
        Me.GitHubLink.Size = New System.Drawing.Size(106, 18)
        Me.GitHubLink.TabIndex = 7
        Me.GitHubLink.TabStop = True
        Me.GitHubLink.Text = "GitHub Source"
        '
        'DocumentationLink
        '
        Me.DocumentationLink.AutoSize = True
        Me.DocumentationLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentationLink.LinkColor = System.Drawing.Color.White
        Me.DocumentationLink.Location = New System.Drawing.Point(712, 364)
        Me.DocumentationLink.Name = "DocumentationLink"
        Me.DocumentationLink.Size = New System.Drawing.Size(109, 18)
        Me.DocumentationLink.TabIndex = 6
        Me.DocumentationLink.TabStop = True
        Me.DocumentationLink.Text = "Documentation"
        '
        'DeveloperLink
        '
        Me.DeveloperLink.AutoSize = True
        Me.DeveloperLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeveloperLink.LinkColor = System.Drawing.Color.White
        Me.DeveloperLink.Location = New System.Drawing.Point(366, 364)
        Me.DeveloperLink.Name = "DeveloperLink"
        Me.DeveloperLink.Size = New System.Drawing.Size(133, 18)
        Me.DeveloperLink.TabIndex = 5
        Me.DeveloperLink.TabStop = True
        Me.DeveloperLink.Text = "Developer Website"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(558, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Enhancement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(457, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PROJECT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.LogoWPS
        Me.PictureBox1.Location = New System.Drawing.Point(100, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(383, 120)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(525, 208)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'Label_About_Content
        '
        Me.Label_About_Content.AutoSize = True
        Me.Label_About_Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_About_Content.ForeColor = System.Drawing.Color.White
        Me.Label_About_Content.Location = New System.Drawing.Point(431, 28)
        Me.Label_About_Content.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_About_Content.Name = "Label_About_Content"
        Me.Label_About_Content.Size = New System.Drawing.Size(131, 31)
        Me.Label_About_Content.TabIndex = 0
        Me.Label_About_Content.Text = "Windows"
        '
        'Panel_Extras_Content
        '
        Me.Panel_Extras_Content.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel_Extras_Content.Controls.Add(Me.Button2)
        Me.Panel_Extras_Content.Controls.Add(Me.Button1)
        Me.Panel_Extras_Content.Controls.Add(Me.TextBox1)
        Me.Panel_Extras_Content.Controls.Add(Me.undoEverything)
        Me.Panel_Extras_Content.Controls.Add(Me.TextBox3)
        Me.Panel_Extras_Content.Location = New System.Drawing.Point(130, 150)
        Me.Panel_Extras_Content.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Extras_Content.Name = "Panel_Extras_Content"
        Me.Panel_Extras_Content.Size = New System.Drawing.Size(1007, 464)
        Me.Panel_Extras_Content.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button2.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.shortcut
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(49, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(365, 52)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Create Useful Shortcuts"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button1.Image = Global.Modern_Flat_UI___Application.My.Resources.Resources.foldertiny
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(605, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(365, 52)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cleanup Desktop"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(626, 149)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(297, 35)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Create desktop folder to drag files into"
        '
        'undoEverything
        '
        Me.undoEverything.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.undoEverything.Cursor = System.Windows.Forms.Cursors.Hand
        Me.undoEverything.FlatAppearance.BorderSize = 2
        Me.undoEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.undoEverything.Font = New System.Drawing.Font("Gadugi", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.undoEverything.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.undoEverything.Location = New System.Drawing.Point(676, 374)
        Me.undoEverything.Margin = New System.Windows.Forms.Padding(2)
        Me.undoEverything.Name = "undoEverything"
        Me.undoEverything.Size = New System.Drawing.Size(308, 63)
        Me.undoEverything.TabIndex = 4
        Me.undoEverything.Text = "Restore Defaults"
        Me.undoEverything.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(70, 153)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(361, 122)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "Adds multiple hard to find shortcuts onto the desktop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Uninstall/Add programs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Show/Hide taskbar icons" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Windows Update"
        '
        'Panel_Startup_Center
        '
        Me.Panel_Startup_Center.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel_Startup_Center.Controls.Add(Me.Label8)
        Me.Panel_Startup_Center.Controls.Add(Me.Label9)
        Me.Panel_Startup_Center.Controls.Add(Me.Label10)
        Me.Panel_Startup_Center.Controls.Add(Me.ButtonClickToStart)
        Me.Panel_Startup_Center.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Startup_Center.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Startup_Center.Name = "Panel_Startup_Center"
        Me.Panel_Startup_Center.Size = New System.Drawing.Size(1264, 681)
        Me.Panel_Startup_Center.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(615, 267)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Enhancement"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(513, 294)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "PROJECT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(487, 264)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 31)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Windows"
        '
        'ButtonClickToStart
        '
        Me.ButtonClickToStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ButtonClickToStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClickToStart.FlatAppearance.BorderSize = 2
        Me.ButtonClickToStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClickToStart.Font = New System.Drawing.Font("Gadugi", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClickToStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonClickToStart.Location = New System.Drawing.Point(480, 342)
        Me.ButtonClickToStart.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClickToStart.Name = "ButtonClickToStart"
        Me.ButtonClickToStart.Size = New System.Drawing.Size(309, 63)
        Me.ButtonClickToStart.TabIndex = 1
        Me.ButtonClickToStart.Text = "Click to start"
        Me.ButtonClickToStart.UseVisualStyleBackColor = False
        '
        'formMain
        '
        Me.AccessibleName = "formMain"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel_Startup_Center)
        Me.Controls.Add(Me.Panel_Project_Content)
        Me.Controls.Add(Me.Panel_Extras_Content)
        Me.Controls.Add(Me.Panel_About_Content)
        Me.Controls.Add(Me.Panel_LeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Enhancement Project"
        Me.Panel_LeftSide.ResumeLayout(False)
        Me.Panel_LeftSide.PerformLayout()
        CType(Me.Main_Logo_LeftSide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Project_Content.ResumeLayout(False)
        Me.Panel_Project_Content.PerformLayout()
        Me.Panel_About_Content.ResumeLayout(False)
        Me.Panel_About_Content.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Extras_Content.ResumeLayout(False)
        Me.Panel_Extras_Content.PerformLayout()
        Me.Panel_Startup_Center.ResumeLayout(False)
        Me.Panel_Startup_Center.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_LeftSide As Panel
    Friend WithEvents Button_Extras_LeftSide As Button
    Friend WithEvents Panel_Active_Marker_LeftSide As Panel
    Friend WithEvents Button_Project_LeftSide As Button
    Friend WithEvents Button_About_LeftSide As Button
    Friend WithEvents Panel_Project_Content As Panel
    Friend WithEvents Panel_About_Content As Panel
    Friend WithEvents Label_About_Content As Label
    Friend WithEvents Main_Title_LeftSide As Label
    Friend WithEvents Main_Logo_LeftSide As PictureBox
    Friend WithEvents Panel_Extras_Content As Panel
    Friend WithEvents justFixItButton As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GitHubLink As LinkLabel
    Friend WithEvents DocumentationLink As LinkLabel
    Friend WithEvents DeveloperLink As LinkLabel
    Friend WithEvents Enchancement As Label
    Friend WithEvents Project As Label
    Friend WithEvents Windows As Label
    Friend WithEvents ShowTaskTreyIcons As Button
    Friend WithEvents RemoveCortana As Button
    Friend WithEvents RemoveInternetSearchResults As Button
    Friend WithEvents RemoveTaskViewButton As Button
    Friend WithEvents Panel_Startup_Center As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonClickToStart As Button
    Friend WithEvents RemoveInkWorkspace As Button
    Friend WithEvents hideSearchBox As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents undoEverything As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
