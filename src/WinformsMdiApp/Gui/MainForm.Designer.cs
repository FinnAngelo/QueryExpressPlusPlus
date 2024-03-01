using QueryExPlusPlus.WinformsMdiApp.Properties;

namespace QueryExPlusPlus.WinformsMdiApp;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        connectToolStripMenuItem = new ToolStripMenuItem();
        newToolStripMenuItem = new ToolStripMenuItem();
        settingsToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        disconnectToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator = new ToolStripSeparator();
        saveToolStripMenuItem = new ToolStripMenuItem();
        saveAsToolStripMenuItem = new ToolStripMenuItem();
        saveResultsAsToolStripMenuItem = new ToolStripMenuItem();
        importServerlistToolStripMenuItem = new ToolStripMenuItem();
        exportServerListToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        printToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        recentFilesMenuItem = new ToolStripMenuItem();
        exitToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem1 = new ToolStripMenuItem();
        undoToolStripMenuItem = new ToolStripMenuItem();
        redoToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        cutToolStripMenuItem = new ToolStripMenuItem();
        copyToolStripMenuItem = new ToolStripMenuItem();
        copyWithHeadersToolStripMenuItem = new ToolStripMenuItem();
        pasteToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        selectAllToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator7 = new ToolStripSeparator();
        findToolStripMenuItem = new ToolStripMenuItem();
        findNextToolStripMenuItem = new ToolStripMenuItem();
        queryToolStripMenuItem = new ToolStripMenuItem();
        executeToolStripMenuItem = new ToolStripMenuItem();
        cancelExecutingQueryToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator8 = new ToolStripSeparator();
        queryOptionsToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator9 = new ToolStripSeparator();
        resultsInTextToolStripMenuItem = new ToolStripMenuItem();
        resultsInGridToolStripMenuItem = new ToolStripMenuItem();
        hideNullValuesToolStripMenuItem = new ToolStripMenuItem();
        showNullValuesToolStripMenuItem = new ToolStripMenuItem();
        windowToolStripMenuItem = new ToolStripMenuItem();
        hideBrowserToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem1 = new ToolStripMenuItem();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        mainStrip = new ToolStrip();
        newToolStripButton = new ToolStripButton();
        openToolStripButton = new ToolStripButton();
        saveToolStripButton = new ToolStripButton();
        toolStripSeparator5 = new ToolStripSeparator();
        ExecutetoolStripButton = new ToolStripButton();
        cancelExecutingQuerytoolStripButton = new ToolStripButton();
        toolStripSeparator6 = new ToolStripSeparator();
        resultsInTexttoolStripButton = new ToolStripButton();
        resultsInGridtoolStripButton = new ToolStripButton();
        toolStripPanel1 = new ToolStripPanel();
        mruMenuManager1 = new MRUSampleControlLibrary.MruMenuManager(components);
        menuStrip1.SuspendLayout();
        mainStrip.SuspendLayout();
        toolStripPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem1, queryToolStripMenuItem, windowToolStripMenuItem, helpToolStripMenuItem1 });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.MdiWindowListItem = windowToolStripMenuItem;
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(7, 2, 0, 2);
        menuStrip1.Size = new Size(883, 24);
        menuStrip1.TabIndex = 3;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem, newToolStripMenuItem, settingsToolStripMenuItem, openToolStripMenuItem, disconnectToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, saveResultsAsToolStripMenuItem, importServerlistToolStripMenuItem, exportServerListToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, toolStripSeparator2, recentFilesMenuItem, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        // 
        // connectToolStripMenuItem
        // 
        connectToolStripMenuItem.Name = "connectToolStripMenuItem";
        connectToolStripMenuItem.Size = new Size(221, 22);
        connectToolStripMenuItem.Text = "&Connect";
        connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Image = Resources.newToolStripMenuItem_Image;
        newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        newToolStripMenuItem.Size = new Size(221, 22);
        newToolStripMenuItem.Text = "&New";
        newToolStripMenuItem.Click += newToolStripMenuItem_Click;
        // 
        // settingsToolStripMenuItem
        // 
        settingsToolStripMenuItem.Image = Resources.settingsToolStripMenuItem_Image;
        settingsToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
        settingsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
        settingsToolStripMenuItem.Size = new Size(221, 22);
        settingsToolStripMenuItem.Text = "Se&ttings";
        settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = Resources.openToolStripMenuItem_Image;
        openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        openToolStripMenuItem.Size = new Size(221, 22);
        openToolStripMenuItem.Text = "&Open";
        openToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // disconnectToolStripMenuItem
        // 

        disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
        disconnectToolStripMenuItem.Size = new Size(221, 22);
        disconnectToolStripMenuItem.Text = "C&lose";
        disconnectToolStripMenuItem.Click += disconnectToolStripMenuItem_Click;
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new Size(218, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = Resources.saveToolStripMenuItem_Image;
        saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        saveToolStripMenuItem.Size = new Size(221, 22);
        saveToolStripMenuItem.Text = "&Save";
        saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Size = new Size(221, 22);
        saveAsToolStripMenuItem.Text = "Save &As";
        saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
        // 
        // saveResultsAsToolStripMenuItem
        // 
        saveResultsAsToolStripMenuItem.Name = "saveResultsAsToolStripMenuItem";
        saveResultsAsToolStripMenuItem.Size = new Size(221, 22);
        saveResultsAsToolStripMenuItem.Text = "Sa&ve Results As";
        saveResultsAsToolStripMenuItem.Click += saveResultsAsToolStripMenuItem_Click;
        // 
        // importServerlistToolStripMenuItem
        // 
        importServerlistToolStripMenuItem.Name = "importServerlistToolStripMenuItem";
        importServerlistToolStripMenuItem.Size = new Size(221, 22);
        importServerlistToolStripMenuItem.Text = "&Import Serverlist From File...";
        importServerlistToolStripMenuItem.Click += importServerListToolStripMenuItem_Click;
        // 
        // exportServerListToolStripMenuItem
        // 
        exportServerListToolStripMenuItem.Name = "exportServerListToolStripMenuItem";
        exportServerListToolStripMenuItem.Size = new Size(221, 22);
        exportServerListToolStripMenuItem.Text = "&Export Serverlist To File...";
        exportServerListToolStripMenuItem.Click += exportServerListToolStripMenuItem_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(218, 6);
        // 
        // printToolStripMenuItem
        // 
        printToolStripMenuItem.Image = Resources.printToolStripMenuItem_Image;
        printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        printToolStripMenuItem.Name = "printToolStripMenuItem";
        printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
        printToolStripMenuItem.Size = new Size(221, 22);
        printToolStripMenuItem.Text = "&Print";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(218, 6);
        // 
        // recentFilesMenuItem
        // 
        recentFilesMenuItem.Name = "recentFilesMenuItem";
        recentFilesMenuItem.Size = new Size(221, 22);
        recentFilesMenuItem.Text = "Recent &Files";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(221, 22);
        exitToolStripMenuItem.Text = "E&xit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // editToolStripMenuItem1
        // 
        editToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, copyWithHeadersToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem, toolStripSeparator7, findToolStripMenuItem, findNextToolStripMenuItem });
        editToolStripMenuItem1.Name = "editToolStripMenuItem1";
        editToolStripMenuItem1.Size = new Size(39, 20);
        editToolStripMenuItem1.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
        undoToolStripMenuItem.Size = new Size(250, 22);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
        redoToolStripMenuItem.Size = new Size(250, 22);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(247, 6);
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Image = Resources.cutToolStripMenuItem_Image;
        cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        cutToolStripMenuItem.Size = new Size(250, 22);
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Image = Resources.copyToolStripMenuItem_Image;
        copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
        copyToolStripMenuItem.Size = new Size(250, 22);
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // copyWithHeadersToolStripMenuItem
        // 
        copyWithHeadersToolStripMenuItem.Image = Resources.copyWithHeadersToolStripMenuItem_Image;
        copyWithHeadersToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        copyWithHeadersToolStripMenuItem.Name = "copyWithHeadersToolStripMenuItem";
        copyWithHeadersToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
        copyWithHeadersToolStripMenuItem.Size = new Size(250, 22);
        copyWithHeadersToolStripMenuItem.Text = "Copy With Headers";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Image = Resources.pasteToolStripMenuItem_Image;
        pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
        pasteToolStripMenuItem.Size = new Size(250, 22);
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(247, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
        selectAllToolStripMenuItem.Size = new Size(250, 22);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // toolStripSeparator7
        // 
        toolStripSeparator7.Name = "toolStripSeparator7";
        toolStripSeparator7.Size = new Size(247, 6);
        // 
        // findToolStripMenuItem
        // 
        findToolStripMenuItem.Name = "findToolStripMenuItem";
        findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
        findToolStripMenuItem.Size = new Size(250, 22);
        findToolStripMenuItem.Text = "&Find";
        findToolStripMenuItem.Click += findToolStripMenuItem_Click;
        // 
        // findNextToolStripMenuItem
        // 
        findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
        findNextToolStripMenuItem.ShortcutKeys = Keys.F3;
        findNextToolStripMenuItem.Size = new Size(250, 22);
        findNextToolStripMenuItem.Text = "Find &Next";
        findNextToolStripMenuItem.Click += findNextToolStripMenuItem_Click;
        // 
        // queryToolStripMenuItem
        // 
        queryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { executeToolStripMenuItem, cancelExecutingQueryToolStripMenuItem, toolStripSeparator8, queryOptionsToolStripMenuItem, toolStripSeparator9, resultsInTextToolStripMenuItem, resultsInGridToolStripMenuItem, hideNullValuesToolStripMenuItem, showNullValuesToolStripMenuItem });
        queryToolStripMenuItem.Name = "queryToolStripMenuItem";
        queryToolStripMenuItem.Size = new Size(51, 20);
        queryToolStripMenuItem.Text = "&Query";
        // 
        // executeToolStripMenuItem
        // 
        executeToolStripMenuItem.Image = Resources.executeToolStripMenuItem_Image;
        executeToolStripMenuItem.Name = "executeToolStripMenuItem";
        executeToolStripMenuItem.ShortcutKeys = Keys.F5;
        executeToolStripMenuItem.Size = new Size(251, 22);
        executeToolStripMenuItem.Text = "&Execute";
        executeToolStripMenuItem.Click += executeToolStripMenuItem_Click;
        // 
        // cancelExecutingQueryToolStripMenuItem
        // 
        cancelExecutingQueryToolStripMenuItem.Image = Resources.cancelExecutingQueryToolStripMenuItem_Image;
        cancelExecutingQueryToolStripMenuItem.Name = "cancelExecutingQueryToolStripMenuItem";
        cancelExecutingQueryToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
        cancelExecutingQueryToolStripMenuItem.Size = new Size(251, 22);
        cancelExecutingQueryToolStripMenuItem.Text = "&Cancel Executing Query";
        cancelExecutingQueryToolStripMenuItem.Click += cancelExecutingQueryToolStripMenuItem_Click;
        // 
        // toolStripSeparator8
        // 
        toolStripSeparator8.Name = "toolStripSeparator8";
        toolStripSeparator8.Size = new Size(248, 6);
        // 
        // queryOptionsToolStripMenuItem
        // 
        queryOptionsToolStripMenuItem.Name = "queryOptionsToolStripMenuItem";
        queryOptionsToolStripMenuItem.Size = new Size(251, 22);
        queryOptionsToolStripMenuItem.Text = "Query &Options";
        queryOptionsToolStripMenuItem.Click += queryOptionsToolStripMenuItem_Click;
        // 
        // toolStripSeparator9
        // 
        toolStripSeparator9.Name = "toolStripSeparator9";
        toolStripSeparator9.Size = new Size(248, 6);
        // 
        // resultsInTextToolStripMenuItem
        // 
        resultsInTextToolStripMenuItem.Image = Resources.resultsInTextToolStripMenuItem_Image;
        resultsInTextToolStripMenuItem.Name = "resultsInTextToolStripMenuItem";
        resultsInTextToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
        resultsInTextToolStripMenuItem.Size = new Size(251, 22);
        resultsInTextToolStripMenuItem.Text = "Results In Text";
        resultsInTextToolStripMenuItem.Click += resultsInTextToolStripMenuItem_Click;
        // 
        // resultsInGridToolStripMenuItem
        // 
        resultsInGridToolStripMenuItem.Image = Resources.resultsInGridToolStripMenuItem_Image;
        resultsInGridToolStripMenuItem.Name = "resultsInGridToolStripMenuItem";
        resultsInGridToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
        resultsInGridToolStripMenuItem.Size = new Size(251, 22);
        resultsInGridToolStripMenuItem.Text = "Results In Grid";
        resultsInGridToolStripMenuItem.Click += resultsInGridToolStripMenuItem_Click;
        // 
        // hideNullValuesToolStripMenuItem
        // 
        hideNullValuesToolStripMenuItem.Name = "hideNullValuesToolStripMenuItem";
        hideNullValuesToolStripMenuItem.Size = new Size(251, 22);
        hideNullValuesToolStripMenuItem.Text = "Hide Null Values";
        hideNullValuesToolStripMenuItem.Click += hideNullValuesToolStripMenuItem_Click;
        // 
        // showNullValuesToolStripMenuItem
        // 
        showNullValuesToolStripMenuItem.Name = "showNullValuesToolStripMenuItem";
        showNullValuesToolStripMenuItem.Size = new Size(251, 22);
        showNullValuesToolStripMenuItem.Text = "Show Null Values";
        showNullValuesToolStripMenuItem.Click += showNullValuesToolStripMenuItem_Click;
        // 
        // windowToolStripMenuItem
        // 
        windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hideBrowserToolStripMenuItem });
        windowToolStripMenuItem.Name = "windowToolStripMenuItem";
        windowToolStripMenuItem.Size = new Size(63, 20);
        windowToolStripMenuItem.Text = "&Window";
        // 
        // hideBrowserToolStripMenuItem
        // 
        hideBrowserToolStripMenuItem.Name = "hideBrowserToolStripMenuItem";
        hideBrowserToolStripMenuItem.Size = new Size(182, 22);
        hideBrowserToolStripMenuItem.Text = "Hide &Object Browser";
        hideBrowserToolStripMenuItem.Click += hideBrowserToolStripMenuItem_Click;
        // 
        // helpToolStripMenuItem1
        // 
        helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
        helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
        helpToolStripMenuItem1.Size = new Size(44, 20);
        helpToolStripMenuItem1.Text = "&Help";
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(116, 22);
        aboutToolStripMenuItem.Text = "&About...";
        aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
        // 
        // mainStrip
        // 
        mainStrip.Dock = DockStyle.None;
        mainStrip.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator5, ExecutetoolStripButton, cancelExecutingQuerytoolStripButton, toolStripSeparator6, resultsInTexttoolStripButton, resultsInGridtoolStripButton });
        mainStrip.Location = new Point(3, 0);
        mainStrip.Name = "mainStrip";
        mainStrip.Size = new Size(541, 25);
        mainStrip.TabIndex = 4;
        // 
        // newToolStripButton
        // 
        newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        newToolStripButton.Image = Resources.newToolStripButton_Image;
        newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        newToolStripButton.Name = "newToolStripButton";
        newToolStripButton.Size = new Size(35, 22);
        newToolStripButton.Text = "&New";
        newToolStripButton.Click += newToolStripButton_Click;
        // 
        // openToolStripButton
        // 
        openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        openToolStripButton.Image = Resources.openToolStripButton_Image;
        openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        openToolStripButton.Name = "openToolStripButton";
        openToolStripButton.Size = new Size(40, 22);
        openToolStripButton.Text = "&Open";
        openToolStripButton.Click += openToolStripButton_Click;
        // 
        // saveToolStripButton
        // 
        saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        saveToolStripButton.Image = Resources.saveToolStripButton_Image;
        saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        saveToolStripButton.Name = "saveToolStripButton";
        saveToolStripButton.Size = new Size(35, 22);
        saveToolStripButton.Text = "&Save";
        saveToolStripButton.Click += saveToolStripButton_Click;
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(6, 25);
        // 
        // ExecutetoolStripButton
        // 
        ExecutetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        ExecutetoolStripButton.Image = Resources.ExecutetoolStripButton_Image;
        ExecutetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        ExecutetoolStripButton.Name = "ExecutetoolStripButton";
        ExecutetoolStripButton.Size = new Size(52, 22);
        ExecutetoolStripButton.Text = "Execute";
        ExecutetoolStripButton.Click += ExecutetoolStripButton_Click;
        // 
        // cancelExecutingQuerytoolStripButton
        // 

        cancelExecutingQuerytoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        cancelExecutingQuerytoolStripButton.Image = Resources.cancelExecutingQuerytoolStripButton_Image;
        cancelExecutingQuerytoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        cancelExecutingQuerytoolStripButton.Name = "cancelExecutingQuerytoolStripButton";
        cancelExecutingQuerytoolStripButton.Size = new Size(153, 22);
        cancelExecutingQuerytoolStripButton.Text = "Cancel Executing Query";
        cancelExecutingQuerytoolStripButton.Click += cancelExecutingQuerytoolStripButton_Click;
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Name = "toolStripSeparator6";
        toolStripSeparator6.Size = new Size(6, 25);
        // 
        // resultsInTexttoolStripButton
        // 
        resultsInTexttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        resultsInTexttoolStripButton.Image = Resources.resultsInTexttoolStripButton_Image;
        resultsInTexttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        resultsInTexttoolStripButton.Name = "resultsInTexttoolStripButton";
        resultsInTexttoolStripButton.Size = new Size(85, 22);
        resultsInTexttoolStripButton.Text = "Results In Text";
        resultsInTexttoolStripButton.Click += ResultsInTexttoolStripButton_Click;
        // 
        // resultsInGridtoolStripButton
        // 
        resultsInGridtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        resultsInGridtoolStripButton.Image = Resources.resultsInGridtoolStripButton_Image;
        resultsInGridtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        resultsInGridtoolStripButton.Name = "resultsInGridtoolStripButton";
        resultsInGridtoolStripButton.Size = new Size(86, 22);
        resultsInGridtoolStripButton.Text = "Results In Grid";
        resultsInGridtoolStripButton.Click += resultsInGridtoolStripButton_Click;
        // 
        // toolStripPanel1
        // 
        toolStripPanel1.Controls.Add(mainStrip);
        toolStripPanel1.Dock = DockStyle.Top;
        toolStripPanel1.Location = new Point(0, 24);
        toolStripPanel1.Name = "toolStripPanel1";
        toolStripPanel1.Orientation = Orientation.Horizontal;
        toolStripPanel1.RowMargin = new Padding(3, 0, 0, 0);
        toolStripPanel1.Size = new Size(883, 25);
        // 
        // mruMenuManager1
        // 
        mruMenuManager1.DisplayStyle = MRUSampleControlLibrary.MruListDisplayStyle.InSubMenu;
        mruMenuManager1.MruListMenu = recentFilesMenuItem;
        mruMenuManager1.MruMenuItemClick += mruMenuManager1_MruMenuItemClick;
        mruMenuManager1.MruMenuItemFileMissing += mruMenuManager1_MruMenuItemFileMissing;
        // 
        // MainForm
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(883, 615);
        Controls.Add(toolStripPanel1);
        Controls.Add(menuStrip1);
        Icon = Resources.Icon;
        IsMdiContainer = true;
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4, 3, 4, 3);
        Name = "MainForm";
        Text = "Query ExPlus";
        FormClosed += MainForm_FormClosed;
        Load += MainForm_Load;
        DragDrop += MainForm_DragDrop;
        DragEnter += MainForm_DragEnter;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        mainStrip.ResumeLayout(false);
        mainStrip.PerformLayout();
        toolStripPanel1.ResumeLayout(false);
        toolStripPanel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
    private System.Windows.Forms.ToolStrip mainStrip;
    private System.Windows.Forms.ToolStripButton newToolStripButton;
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelExecutingQueryToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripMenuItem queryOptionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.ToolStripMenuItem resultsInTextToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resultsInGridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showNullValuesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideNullValuesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hideBrowserToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveResultsAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripPanel toolStripPanel1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton ExecutetoolStripButton;
    private System.Windows.Forms.ToolStripButton cancelExecutingQuerytoolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripButton resultsInTexttoolStripButton;
    private System.Windows.Forms.ToolStripButton resultsInGridtoolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyWithHeadersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem recentFilesMenuItem;
    private MRUSampleControlLibrary.MruMenuManager mruMenuManager1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportServerListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importServerlistToolStripMenuItem;


}

