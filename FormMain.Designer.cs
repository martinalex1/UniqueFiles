
namespace UniqueFiles
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtReponame = new System.Windows.Forms.TextBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRepo = new System.Windows.Forms.TabPage();
            this.lblDrop = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdFolder = new System.Windows.Forms.Button();
            this.txtChangeCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.txtDuplicateCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.txtFileCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.listResult = new System.Windows.Forms.ListView();
            this.colFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.popView = new System.Windows.Forms.ToolStripMenuItem();
            this.popViewExternal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripResult = new System.Windows.Forms.ToolStrip();
            this.tbCheck = new System.Windows.Forms.ToolStripSplitButton();
            this.tbCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCheckNone = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCheckSecond = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbView = new System.Windows.Forms.ToolStripSplitButton();
            this.tbViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tbViewChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCopy = new System.Windows.Forms.ToolStripSplitButton();
            this.tbCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCopyChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbDelete = new System.Windows.Forms.ToolStripSplitButton();
            this.tbDeleteChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.tabView = new System.Windows.Forms.TabPage();
            this.toolStripView = new System.Windows.Forms.ToolStrip();
            this.tbPrior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbChecked = new System.Windows.Forms.ToolStripButton();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtView = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.cboHashType = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabRepo.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.popList.SuspendLayout();
            this.toolStripResult.SuspendLayout();
            this.tabView.SuspendLayout();
            this.toolStripView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReponame
            // 
            this.txtReponame.Location = new System.Drawing.Point(136, 22);
            this.txtReponame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReponame.Name = "txtReponame";
            this.txtReponame.Size = new System.Drawing.Size(198, 22);
            this.txtReponame.TabIndex = 0;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(136, 62);
            this.txtDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(532, 22);
            this.txtDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Repository";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directory";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMain});
            this.statusStrip.Location = new System.Drawing.Point(0, 388);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(1064, 26);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusMain
            // 
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(25, 20);
            this.statusMain.Text = "    ";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabRepo);
            this.tabControl.Controls.Add(this.tabResult);
            this.tabControl.Controls.Add(this.tabView);
            this.tabControl.ItemSize = new System.Drawing.Size(106, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1064, 357);
            this.tabControl.TabIndex = 5;
            this.tabControl.TabStop = false;
            this.tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TabControl_KeyDown);
            // 
            // tabRepo
            // 
            this.tabRepo.Controls.Add(this.cboHashType);
            this.tabRepo.Controls.Add(this.lblDrop);
            this.tabRepo.Controls.Add(this.cmdStop);
            this.tabRepo.Controls.Add(this.cmdFolder);
            this.tabRepo.Controls.Add(this.txtChangeCount);
            this.tabRepo.Controls.Add(this.label6);
            this.tabRepo.Controls.Add(this.cmdOpen);
            this.tabRepo.Controls.Add(this.txtDuplicateCount);
            this.tabRepo.Controls.Add(this.label5);
            this.tabRepo.Controls.Add(this.cmdUpdate);
            this.tabRepo.Controls.Add(this.txtFileCount);
            this.tabRepo.Controls.Add(this.label4);
            this.tabRepo.Controls.Add(this.txtLastUpdate);
            this.tabRepo.Controls.Add(this.label3);
            this.tabRepo.Controls.Add(this.label1);
            this.tabRepo.Controls.Add(this.txtReponame);
            this.tabRepo.Controls.Add(this.txtDirectory);
            this.tabRepo.Controls.Add(this.label2);
            this.tabRepo.Location = new System.Drawing.Point(4, 29);
            this.tabRepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRepo.Name = "tabRepo";
            this.tabRepo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRepo.Size = new System.Drawing.Size(1056, 324);
            this.tabRepo.TabIndex = 0;
            this.tabRepo.Text = " Repository ";
            this.tabRepo.UseVisualStyleBackColor = true;
            this.tabRepo.Enter += new System.EventHandler(this.TabRepo_Enter);
            // 
            // lblDrop
            // 
            this.lblDrop.AutoSize = true;
            this.lblDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrop.Location = new System.Drawing.Point(338, 290);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(137, 25);
            this.lblDrop.TabIndex = 16;
            this.lblDrop.Text = "Drop files here";
            this.lblDrop.Visible = false;
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(195, 222);
            this.cmdStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(72, 44);
            this.cmdStop.TabIndex = 15;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Visible = false;
            this.cmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // cmdFolder
            // 
            this.cmdFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFolder.Location = new System.Drawing.Point(693, 59);
            this.cmdFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdFolder.Name = "cmdFolder";
            this.cmdFolder.Size = new System.Drawing.Size(36, 34);
            this.cmdFolder.TabIndex = 14;
            this.cmdFolder.Text = "...";
            this.cmdFolder.UseVisualStyleBackColor = true;
            this.cmdFolder.Click += new System.EventHandler(this.CmdFolder_Click);
            // 
            // txtChangeCount
            // 
            this.txtChangeCount.Location = new System.Drawing.Point(514, 151);
            this.txtChangeCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChangeCount.Name = "txtChangeCount";
            this.txtChangeCount.ReadOnly = true;
            this.txtChangeCount.Size = new System.Drawing.Size(98, 22);
            this.txtChangeCount.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Change count";
            // 
            // cmdOpen
            // 
            this.cmdOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmdOpen.Image")));
            this.cmdOpen.Location = new System.Drawing.Point(361, 18);
            this.cmdOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(36, 27);
            this.cmdOpen.TabIndex = 11;
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // txtDuplicateCount
            // 
            this.txtDuplicateCount.Location = new System.Drawing.Point(514, 192);
            this.txtDuplicateCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuplicateCount.Name = "txtDuplicateCount";
            this.txtDuplicateCount.ReadOnly = true;
            this.txtDuplicateCount.Size = new System.Drawing.Size(98, 22);
            this.txtDuplicateCount.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Duplicate count";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(20, 222);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(151, 44);
            this.cmdUpdate.TabIndex = 8;
            this.cmdUpdate.Text = "Update repository";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // txtFileCount
            // 
            this.txtFileCount.Location = new System.Drawing.Point(136, 150);
            this.txtFileCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileCount.Name = "txtFileCount";
            this.txtFileCount.ReadOnly = true;
            this.txtFileCount.Size = new System.Drawing.Size(98, 22);
            this.txtFileCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "File count";
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.Location = new System.Drawing.Point(136, 106);
            this.txtLastUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.ReadOnly = true;
            this.txtLastUpdate.Size = new System.Drawing.Size(198, 22);
            this.txtLastUpdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last update";
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.listResult);
            this.tabResult.Controls.Add(this.toolStripResult);
            this.tabResult.Location = new System.Drawing.Point(4, 29);
            this.tabResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabResult.Size = new System.Drawing.Size(1056, 324);
            this.tabResult.TabIndex = 1;
            this.tabResult.Text = " Result ";
            this.tabResult.UseVisualStyleBackColor = true;
            this.tabResult.Enter += new System.EventHandler(this.TabResult_Enter);
            // 
            // listResult
            // 
            this.listResult.AllowDrop = true;
            this.listResult.CheckBoxes = true;
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFilename,
            this.colFolder,
            this.colResult,
            this.colDate,
            this.colSize});
            this.listResult.ContextMenuStrip = this.popList;
            this.listResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listResult.FullRowSelect = true;
            this.listResult.GridLines = true;
            this.listResult.HideSelection = false;
            this.listResult.Location = new System.Drawing.Point(3, 29);
            this.listResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(1050, 293);
            this.listResult.TabIndex = 0;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            this.listResult.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListResult_DragDrop);
            this.listResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListResult_DragEnter);
            this.listResult.DragOver += new System.Windows.Forms.DragEventHandler(this.ListResult_DragOver);
            this.listResult.DoubleClick += new System.EventHandler(this.ListResult_DoubleClick);
            // 
            // colFilename
            // 
            this.colFilename.Text = "Filename";
            this.colFilename.Width = 200;
            // 
            // colFolder
            // 
            this.colFolder.Text = "Folder";
            this.colFolder.Width = 300;
            // 
            // colResult
            // 
            this.colResult.Text = "Result";
            this.colResult.Width = 100;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 120;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSize.Width = 80;
            // 
            // popList
            // 
            this.popList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.popList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popFolder,
            this.popView,
            this.popViewExternal});
            this.popList.Name = "popList";
            this.popList.Size = new System.Drawing.Size(159, 76);
            // 
            // popFolder
            // 
            this.popFolder.Name = "popFolder";
            this.popFolder.Size = new System.Drawing.Size(158, 24);
            this.popFolder.Text = "Show folder";
            this.popFolder.Click += new System.EventHandler(this.PopFolder_Click);
            // 
            // popView
            // 
            this.popView.Name = "popView";
            this.popView.Size = new System.Drawing.Size(158, 24);
            this.popView.Text = "View";
            this.popView.Click += new System.EventHandler(this.PopView_Click);
            // 
            // popViewExternal
            // 
            this.popViewExternal.Name = "popViewExternal";
            this.popViewExternal.Size = new System.Drawing.Size(158, 24);
            this.popViewExternal.Text = "View with...";
            this.popViewExternal.Click += new System.EventHandler(this.PopViewExternal_Click);
            // 
            // toolStripResult
            // 
            this.toolStripResult.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbCheck,
            this.toolStripSeparator2,
            this.tbView,
            this.toolStripSeparator3,
            this.tbCopy,
            this.toolStripSeparator4,
            this.tbDelete});
            this.toolStripResult.Location = new System.Drawing.Point(3, 2);
            this.toolStripResult.Name = "toolStripResult";
            this.toolStripResult.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripResult.Size = new System.Drawing.Size(1050, 27);
            this.toolStripResult.TabIndex = 1;
            this.toolStripResult.Text = "toolStrip1";
            // 
            // tbCheck
            // 
            this.tbCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbCheckAll,
            this.tbCheckNone,
            this.tbCheckSecond});
            this.tbCheck.Image = ((System.Drawing.Image)(resources.GetObject("tbCheck.Image")));
            this.tbCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(67, 24);
            this.tbCheck.Text = "Check";
            this.tbCheck.ButtonClick += new System.EventHandler(this.TbCheck_ButtonClick);
            // 
            // tbCheckAll
            // 
            this.tbCheckAll.Name = "tbCheckAll";
            this.tbCheckAll.Size = new System.Drawing.Size(152, 26);
            this.tbCheckAll.Text = "All";
            this.tbCheckAll.Click += new System.EventHandler(this.TbCheckAll_Click);
            // 
            // tbCheckNone
            // 
            this.tbCheckNone.Name = "tbCheckNone";
            this.tbCheckNone.Size = new System.Drawing.Size(152, 26);
            this.tbCheckNone.Text = "None";
            this.tbCheckNone.Click += new System.EventHandler(this.TbCheckNone_Click);
            // 
            // tbCheckSecond
            // 
            this.tbCheckSecond.Name = "tbCheckSecond";
            this.tbCheckSecond.Size = new System.Drawing.Size(152, 26);
            this.tbCheckSecond.Text = "Each 2nd";
            this.tbCheckSecond.Click += new System.EventHandler(this.TbCheckSecond_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbView
            // 
            this.tbView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbViewAll,
            this.tbViewChecked});
            this.tbView.Image = ((System.Drawing.Image)(resources.GetObject("tbView.Image")));
            this.tbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbView.Name = "tbView";
            this.tbView.Size = new System.Drawing.Size(60, 24);
            this.tbView.Text = "View";
            this.tbView.ButtonClick += new System.EventHandler(this.TbView_ButtonClick);
            // 
            // tbViewAll
            // 
            this.tbViewAll.Name = "tbViewAll";
            this.tbViewAll.Size = new System.Drawing.Size(148, 26);
            this.tbViewAll.Text = "All";
            this.tbViewAll.Click += new System.EventHandler(this.TbViewAll_Click);
            // 
            // tbViewChecked
            // 
            this.tbViewChecked.Name = "tbViewChecked";
            this.tbViewChecked.Size = new System.Drawing.Size(148, 26);
            this.tbViewChecked.Text = "Checked";
            this.tbViewChecked.Click += new System.EventHandler(this.TbViewChecked_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tbCopy
            // 
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbCopyAll,
            this.tbCopyChecked});
            this.tbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tbCopy.Image")));
            this.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(62, 24);
            this.tbCopy.Text = "Copy";
            this.tbCopy.ButtonClick += new System.EventHandler(this.TbCopy_ButtonClick);
            // 
            // tbCopyAll
            // 
            this.tbCopyAll.Name = "tbCopyAll";
            this.tbCopyAll.Size = new System.Drawing.Size(148, 26);
            this.tbCopyAll.Text = "All";
            this.tbCopyAll.Click += new System.EventHandler(this.TbCopyAll_Click);
            // 
            // tbCopyChecked
            // 
            this.tbCopyChecked.Name = "tbCopyChecked";
            this.tbCopyChecked.Size = new System.Drawing.Size(148, 26);
            this.tbCopyChecked.Text = "Checked";
            this.tbCopyChecked.Click += new System.EventHandler(this.TbCopyChecked_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tbDelete
            // 
            this.tbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbDeleteChecked});
            this.tbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbDelete.Image")));
            this.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(72, 24);
            this.tbDelete.Text = "Delete";
            this.tbDelete.ButtonClick += new System.EventHandler(this.TbDelete_ButtonClick);
            // 
            // tbDeleteChecked
            // 
            this.tbDeleteChecked.Name = "tbDeleteChecked";
            this.tbDeleteChecked.Size = new System.Drawing.Size(194, 26);
            this.tbDeleteChecked.Text = "Delete checked";
            this.tbDeleteChecked.Click += new System.EventHandler(this.TbDeleteChecked_Click);
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.toolStripView);
            this.tabView.Controls.Add(this.picBox);
            this.tabView.Controls.Add(this.txtView);
            this.tabView.Location = new System.Drawing.Point(4, 29);
            this.tabView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabView.Size = new System.Drawing.Size(1056, 324);
            this.tabView.TabIndex = 2;
            this.tabView.Text = " View ";
            this.tabView.UseVisualStyleBackColor = true;
            this.tabView.Enter += new System.EventHandler(this.TabView_Enter);
            // 
            // toolStripView
            // 
            this.toolStripView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbPrior,
            this.toolStripSeparator5,
            this.tbNext,
            this.toolStripSeparator6,
            this.tbChecked});
            this.toolStripView.Location = new System.Drawing.Point(3, 2);
            this.toolStripView.Name = "toolStripView";
            this.toolStripView.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripView.Size = new System.Drawing.Size(1050, 31);
            this.toolStripView.TabIndex = 1;
            this.toolStripView.Text = "toolStrip2";
            // 
            // tbPrior
            // 
            this.tbPrior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPrior.Image = ((System.Drawing.Image)(resources.GetObject("tbPrior.Image")));
            this.tbPrior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPrior.Name = "tbPrior";
            this.tbPrior.Size = new System.Drawing.Size(29, 28);
            this.tbPrior.Text = "Prior";
            this.tbPrior.Click += new System.EventHandler(this.TbPrior_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // tbNext
            // 
            this.tbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNext.Image = ((System.Drawing.Image)(resources.GetObject("tbNext.Image")));
            this.tbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNext.Name = "tbNext";
            this.tbNext.Size = new System.Drawing.Size(29, 28);
            this.tbNext.Text = "Next";
            this.tbNext.Click += new System.EventHandler(this.TbNext_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // tbChecked
            // 
            this.tbChecked.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbChecked.Image = ((System.Drawing.Image)(resources.GetObject("tbChecked.Image")));
            this.tbChecked.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbChecked.Name = "tbChecked";
            this.tbChecked.Size = new System.Drawing.Size(29, 28);
            this.tbChecked.Text = "C";
            this.tbChecked.Click += new System.EventHandler(this.TbChecked_Click);
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(-4, 31);
            this.picBox.Margin = new System.Windows.Forms.Padding(1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1060, 296);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // txtView
            // 
            this.txtView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtView.Location = new System.Drawing.Point(0, 47);
            this.txtView.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ReadOnly = true;
            this.txtView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtView.Size = new System.Drawing.Size(1052, 280);
            this.txtView.TabIndex = 2;
            this.txtView.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeyDisplayString = "Ctrl + N";
            this.mnuNew.Size = new System.Drawing.Size(198, 26);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.MnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeyDisplayString = "Ctrl + O";
            this.mnuOpen.Size = new System.Drawing.Size(198, 26);
            this.mnuOpen.Text = "Open...";
            this.mnuOpen.Click += new System.EventHandler(this.MnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeyDisplayString = "Ctrl + S";
            this.mnuSave.Size = new System.Drawing.Size(198, 26);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.MnuSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeyDisplayString = "Ctrl + W";
            this.mnuExit.Size = new System.Drawing.Size(198, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(55, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(133, 26);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "checked2.png");
            this.imageList.Images.SetKeyName(1, "nchecked2.png");
            // 
            // cboHashType
            // 
            this.cboHashType.FormattingEnabled = true;
            this.cboHashType.Items.AddRange(new object[] {
            "File",
            "Image",
            "File & Image"});
            this.cboHashType.Location = new System.Drawing.Point(323, 233);
            this.cboHashType.Name = "cboHashType";
            this.cboHashType.Size = new System.Drawing.Size(121, 24);
            this.cboHashType.TabIndex = 17;
            this.cboHashType.Text = "File";
            // 
            // FormMain
            // 
            this.AcceptButton = this.cmdUpdate;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 414);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Unique Files";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.FormMain_DragOver);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabRepo.ResumeLayout(false);
            this.tabRepo.PerformLayout();
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            this.popList.ResumeLayout(false);
            this.toolStripResult.ResumeLayout(false);
            this.toolStripResult.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            this.toolStripView.ResumeLayout(false);
            this.toolStripView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReponame;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRepo;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TextBox txtFileCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.ToolStripStatusLabel statusMain;
        private System.Windows.Forms.TextBox txtDuplicateCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.ColumnHeader colFilename;
        private System.Windows.Forms.ColumnHeader colFolder;
        private System.Windows.Forms.ColumnHeader colResult;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtChangeCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdFolder;
        private System.Windows.Forms.ToolStrip toolStripResult;
        private System.Windows.Forms.ToolStripSplitButton tbCheck;
        private System.Windows.Forms.ToolStripMenuItem tbCheckAll;
        private System.Windows.Forms.ToolStripMenuItem tbCheckNone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton tbView;
        private System.Windows.Forms.ToolStripMenuItem tbViewAll;
        private System.Windows.Forms.ToolStripMenuItem tbViewChecked;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton tbCopy;
        private System.Windows.Forms.ToolStripMenuItem tbCopyAll;
        private System.Windows.Forms.ToolStripMenuItem tbCopyChecked;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton tbDelete;
        private System.Windows.Forms.ToolStripMenuItem tbDeleteChecked;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ToolStrip toolStripView;
        private System.Windows.Forms.ToolStripButton tbPrior;
        private System.Windows.Forms.ToolStripButton tbNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbChecked;
        private System.Windows.Forms.ToolStripMenuItem tbCheckSecond;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ContextMenuStrip popList;
        private System.Windows.Forms.ToolStripMenuItem popFolder;
        private System.Windows.Forms.ToolStripMenuItem popView;
        private System.Windows.Forms.ToolStripMenuItem popViewExternal;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label lblDrop;
        private System.Windows.Forms.ComboBox cboHashType;
    }
}

