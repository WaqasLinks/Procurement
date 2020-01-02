﻿namespace Procurement
{
    partial class FrmBOM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBOM));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProjectEndUser = new System.Windows.Forms.TextBox();
            this.txtProjectCustomerName = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSaleBOM = new System.Windows.Forms.TabPage();
            this.tabDesignBOM = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabActualBOM = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.MenuStripSaleBOM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCopyAllToDesignBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripDesignBOM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCopyAllToActualBOM = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.LoadBOM = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSaleBOM.SuspendLayout();
            this.tabDesignBOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabActualBOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.MenuStripSaleBOM.SuspendLayout();
            this.MenuStripDesignBOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(885, 30);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 461);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // txtProjectEndUser
            // 
            this.txtProjectEndUser.Location = new System.Drawing.Point(432, 28);
            this.txtProjectEndUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectEndUser.Multiline = true;
            this.txtProjectEndUser.Name = "txtProjectEndUser";
            this.txtProjectEndUser.Size = new System.Drawing.Size(129, 30);
            this.txtProjectEndUser.TabIndex = 16;
            // 
            // txtProjectCustomerName
            // 
            this.txtProjectCustomerName.Location = new System.Drawing.Point(293, 28);
            this.txtProjectCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectCustomerName.Multiline = true;
            this.txtProjectCustomerName.Name = "txtProjectCustomerName";
            this.txtProjectCustomerName.Size = new System.Drawing.Size(129, 30);
            this.txtProjectCustomerName.TabIndex = 15;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(157, 28);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectName.Multiline = true;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(129, 30);
            this.txtProjectName.TabIndex = 14;
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Location = new System.Drawing.Point(19, 28);
            this.txtProjectCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectCode.Multiline = true;
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(129, 30);
            this.txtProjectCode.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "End User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project Code";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSaleBOM);
            this.tabControl1.Controls.Add(this.tabDesignBOM);
            this.tabControl1.Controls.Add(this.tabActualBOM);
            this.tabControl1.Location = new System.Drawing.Point(3, 102);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 494);
            this.tabControl1.TabIndex = 18;
            // 
            // tabSaleBOM
            // 
            this.tabSaleBOM.Controls.Add(this.dataGridView1);
            this.tabSaleBOM.Location = new System.Drawing.Point(4, 25);
            this.tabSaleBOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSaleBOM.Name = "tabSaleBOM";
            this.tabSaleBOM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSaleBOM.Size = new System.Drawing.Size(1226, 465);
            this.tabSaleBOM.TabIndex = 0;
            this.tabSaleBOM.Text = "Sale BOM";
            this.tabSaleBOM.UseVisualStyleBackColor = true;
            // 
            // tabDesignBOM
            // 
            this.tabDesignBOM.Controls.Add(this.dataGridView2);
            this.tabDesignBOM.Location = new System.Drawing.Point(4, 25);
            this.tabDesignBOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDesignBOM.Name = "tabDesignBOM";
            this.tabDesignBOM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDesignBOM.Size = new System.Drawing.Size(1225, 465);
            this.tabDesignBOM.TabIndex = 1;
            this.tabDesignBOM.Text = "Design BOM";
            this.tabDesignBOM.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1219, 461);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // tabActualBOM
            // 
            this.tabActualBOM.Controls.Add(this.dataGridView3);
            this.tabActualBOM.Location = new System.Drawing.Point(4, 25);
            this.tabActualBOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabActualBOM.Name = "tabActualBOM";
            this.tabActualBOM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabActualBOM.Size = new System.Drawing.Size(1225, 465);
            this.tabActualBOM.TabIndex = 2;
            this.tabActualBOM.Text = "Actual BOM";
            this.tabActualBOM.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1219, 461);
            this.dataGridView3.TabIndex = 3;
            // 
            // MenuStripSaleBOM
            // 
            this.MenuStripSaleBOM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripSaleBOM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopyAllToDesignBOM});
            this.MenuStripSaleBOM.Name = "contextMenuStrip1";
            this.MenuStripSaleBOM.Size = new System.Drawing.Size(240, 28);
            // 
            // mnuCopyAllToDesignBOM
            // 
            this.mnuCopyAllToDesignBOM.Name = "mnuCopyAllToDesignBOM";
            this.mnuCopyAllToDesignBOM.Size = new System.Drawing.Size(239, 24);
            this.mnuCopyAllToDesignBOM.Text = "Copy All to Design BOM";
            this.mnuCopyAllToDesignBOM.Click += new System.EventHandler(this.mnuCopyAllToDesignBOM_Click);
            // 
            // MenuStripDesignBOM
            // 
            this.MenuStripDesignBOM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripDesignBOM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopyAllToActualBOM});
            this.MenuStripDesignBOM.Name = "contextMenuStrip1";
            this.MenuStripDesignBOM.Size = new System.Drawing.Size(236, 28);
            // 
            // mnuCopyAllToActualBOM
            // 
            this.mnuCopyAllToActualBOM.Name = "mnuCopyAllToActualBOM";
            this.mnuCopyAllToActualBOM.Size = new System.Drawing.Size(235, 24);
            this.mnuCopyAllToActualBOM.Text = "Copy All to Actual BOM";
            this.mnuCopyAllToActualBOM.Click += new System.EventHandler(this.mnuCopyAllToActualBOM_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewProjects);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.LoadBOM);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.txtProjectCode);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtProjectEndUser);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtProjectCustomerName);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtProjectName);
            this.splitContainer1.Size = new System.Drawing.Size(1461, 639);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 20;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "3d bar chart.bmp");
            this.imageList1.Images.SetKeyName(1, "Abort.bmp");
            this.imageList1.Images.SetKeyName(2, "About.bmp");
            this.imageList1.Images.SetKeyName(3, "Add.bmp");
            this.imageList1.Images.SetKeyName(4, "Anchor.bmp");
            this.imageList1.Images.SetKeyName(5, "Application.bmp");
            this.imageList1.Images.SetKeyName(6, "Apply.bmp");
            this.imageList1.Images.SetKeyName(7, "Back.bmp");
            this.imageList1.Images.SetKeyName(8, "Bad mark.bmp");
            this.imageList1.Images.SetKeyName(9, "Blue key.bmp");
            this.imageList1.Images.SetKeyName(10, "Blue tag.bmp");
            this.imageList1.Images.SetKeyName(11, "Boss.bmp");
            this.imageList1.Images.SetKeyName(12, "Bottom.bmp");
            this.imageList1.Images.SetKeyName(13, "Calculator.bmp");
            this.imageList1.Images.SetKeyName(14, "Calendar.bmp");
            this.imageList1.Images.SetKeyName(15, "Car key.bmp");
            this.imageList1.Images.SetKeyName(16, "CD.bmp");
            this.imageList1.Images.SetKeyName(17, "Clipboard.bmp");
            this.imageList1.Images.SetKeyName(18, "Clock.bmp");
            this.imageList1.Images.SetKeyName(19, "Close.bmp");
            this.imageList1.Images.SetKeyName(20, "Compass.bmp");
            this.imageList1.Images.SetKeyName(21, "Component.bmp");
            this.imageList1.Images.SetKeyName(22, "Copy.bmp");
            this.imageList1.Images.SetKeyName(23, "Create.bmp");
            this.imageList1.Images.SetKeyName(24, "Cut.bmp");
            this.imageList1.Images.SetKeyName(25, "Danger.bmp");
            this.imageList1.Images.SetKeyName(26, "Database.bmp");
            this.imageList1.Images.SetKeyName(27, "Delete.bmp");
            this.imageList1.Images.SetKeyName(28, "Delivery.bmp");
            this.imageList1.Images.SetKeyName(29, "Dial.bmp");
            this.imageList1.Images.SetKeyName(30, "Disaster.bmp");
            this.imageList1.Images.SetKeyName(31, "Dollar.bmp");
            this.imageList1.Images.SetKeyName(32, "Down.bmp");
            this.imageList1.Images.SetKeyName(33, "Download.bmp");
            this.imageList1.Images.SetKeyName(34, "Eject.bmp");
            this.imageList1.Images.SetKeyName(35, "E-mail.bmp");
            this.imageList1.Images.SetKeyName(36, "Erase.bmp");
            this.imageList1.Images.SetKeyName(37, "Error.bmp");
            this.imageList1.Images.SetKeyName(38, "Euro.bmp");
            this.imageList1.Images.SetKeyName(39, "Exit.bmp");
            this.imageList1.Images.SetKeyName(40, "Fall.bmp");
            this.imageList1.Images.SetKeyName(41, "Fast-forward.bmp");
            this.imageList1.Images.SetKeyName(42, "Favourites.bmp");
            this.imageList1.Images.SetKeyName(43, "Female.bmp");
            this.imageList1.Images.SetKeyName(44, "Filter.bmp");
            this.imageList1.Images.SetKeyName(45, "Find.bmp");
            this.imageList1.Images.SetKeyName(46, "First record.bmp");
            this.imageList1.Images.SetKeyName(47, "First.bmp");
            this.imageList1.Images.SetKeyName(48, "Flag.bmp");
            this.imageList1.Images.SetKeyName(49, "Folder.bmp");
            this.imageList1.Images.SetKeyName(50, "Forbidden.bmp");
            this.imageList1.Images.SetKeyName(51, "Forward.bmp");
            this.imageList1.Images.SetKeyName(52, "Free bsd.bmp");
            this.imageList1.Images.SetKeyName(53, "Go back.bmp");
            this.imageList1.Images.SetKeyName(54, "Go forward.bmp");
            this.imageList1.Images.SetKeyName(55, "Go.bmp");
            this.imageList1.Images.SetKeyName(56, "Good-mark.bmp");
            this.imageList1.Images.SetKeyName(57, "Green tag.bmp");
            this.imageList1.Images.SetKeyName(58, "Heart.bmp");
            this.imageList1.Images.SetKeyName(59, "Help book 3d.bmp");
            this.imageList1.Images.SetKeyName(60, "Help book.bmp");
            this.imageList1.Images.SetKeyName(61, "Help.bmp");
            this.imageList1.Images.SetKeyName(62, "Hint.bmp");
            this.imageList1.Images.SetKeyName(63, "Home.bmp");
            this.imageList1.Images.SetKeyName(64, "How-to.bmp");
            this.imageList1.Images.SetKeyName(65, "Hungup.bmp");
            this.imageList1.Images.SetKeyName(66, "Info.bmp");
            this.imageList1.Images.SetKeyName(67, "Key.bmp");
            this.imageList1.Images.SetKeyName(68, "Last recor.bmp");
            this.imageList1.Images.SetKeyName(69, "Last.bmp");
            this.imageList1.Images.SetKeyName(70, "Left-right.bmp");
            this.imageList1.Images.SetKeyName(71, "Lightning.bmp");
            this.imageList1.Images.SetKeyName(72, "Linux.bmp");
            this.imageList1.Images.SetKeyName(73, "List.bmp");
            this.imageList1.Images.SetKeyName(74, "Load.bmp");
            this.imageList1.Images.SetKeyName(75, "Lock.bmp");
            this.imageList1.Images.SetKeyName(76, "Low rating.bmp");
            this.imageList1.Images.SetKeyName(77, "Mail.bmp");
            this.imageList1.Images.SetKeyName(78, "Male.bmp");
            this.imageList1.Images.SetKeyName(79, "Medium rating.bmp");
            this.imageList1.Images.SetKeyName(80, "Message.bmp");
            this.imageList1.Images.SetKeyName(81, "Mobile-phone.bmp");
            this.imageList1.Images.SetKeyName(82, "Modify.bmp");
            this.imageList1.Images.SetKeyName(83, "Movie.bmp");
            this.imageList1.Images.SetKeyName(84, "Music.bmp");
            this.imageList1.Images.SetKeyName(85, "New document.bmp");
            this.imageList1.Images.SetKeyName(86, "New.bmp");
            this.imageList1.Images.SetKeyName(87, "Next track.bmp");
            this.imageList1.Images.SetKeyName(88, "Next.bmp");
            this.imageList1.Images.SetKeyName(89, "No.bmp");
            this.imageList1.Images.SetKeyName(90, "No-entry.bmp");
            this.imageList1.Images.SetKeyName(91, "Notes.bmp");
            this.imageList1.Images.SetKeyName(92, "OK.bmp");
            this.imageList1.Images.SetKeyName(93, "Paste.bmp");
            this.imageList1.Images.SetKeyName(94, "Pause.bmp");
            this.imageList1.Images.SetKeyName(95, "People.bmp");
            this.imageList1.Images.SetKeyName(96, "Person.bmp");
            this.imageList1.Images.SetKeyName(97, "Phone number.bmp");
            this.imageList1.Images.SetKeyName(98, "Pie chart.bmp");
            this.imageList1.Images.SetKeyName(99, "Pinion.bmp");
            this.imageList1.Images.SetKeyName(100, "Play.bmp");
            this.imageList1.Images.SetKeyName(101, "Playback.bmp");
            this.imageList1.Images.SetKeyName(102, "Play-music.bmp");
            this.imageList1.Images.SetKeyName(103, "Previous record.bmp");
            this.imageList1.Images.SetKeyName(104, "Previous.bmp");
            this.imageList1.Images.SetKeyName(105, "Problem.bmp");
            this.imageList1.Images.SetKeyName(106, "Question.bmp");
            this.imageList1.Images.SetKeyName(107, "Raise.bmp");
            this.imageList1.Images.SetKeyName(108, "Record.bmp");
            this.imageList1.Images.SetKeyName(109, "Red mark.bmp");
            this.imageList1.Images.SetKeyName(110, "Red star.bmp");
            this.imageList1.Images.SetKeyName(111, "Red tag.bmp");
            this.imageList1.Images.SetKeyName(112, "Redo.bmp");
            this.imageList1.Images.SetKeyName(113, "Refresh.bmp");
            this.imageList1.Images.SetKeyName(114, "Remove.bmp");
            this.imageList1.Images.SetKeyName(115, "Repair.bmp");
            this.imageList1.Images.SetKeyName(116, "Report.bmp");
            this.imageList1.Images.SetKeyName(117, "Retort.bmp");
            this.imageList1.Images.SetKeyName(118, "Rewind.bmp");
            this.imageList1.Images.SetKeyName(119, "Sad.bmp");
            this.imageList1.Images.SetKeyName(120, "Save.bmp");
            this.imageList1.Images.SetKeyName(121, "Search.bmp");
            this.imageList1.Images.SetKeyName(122, "Shopping cart.bmp");
            this.imageList1.Images.SetKeyName(123, "Smile.bmp");
            this.imageList1.Images.SetKeyName(124, "Sound.bmp");
            this.imageList1.Images.SetKeyName(125, "Stop sign.bmp");
            this.imageList1.Images.SetKeyName(126, "Stop.bmp");
            this.imageList1.Images.SetKeyName(127, "Sync.bmp");
            this.imageList1.Images.SetKeyName(128, "Table.bmp");
            this.imageList1.Images.SetKeyName(129, "Target.bmp");
            this.imageList1.Images.SetKeyName(130, "Taxi.bmp");
            this.imageList1.Images.SetKeyName(131, "Terminate.bmp");
            this.imageList1.Images.SetKeyName(132, "Text preview.bmp");
            this.imageList1.Images.SetKeyName(133, "Text.bmp");
            this.imageList1.Images.SetKeyName(134, "Thumbs down.bmp");
            this.imageList1.Images.SetKeyName(135, "Thumbs up.bmp");
            this.imageList1.Images.SetKeyName(136, "Top.bmp");
            this.imageList1.Images.SetKeyName(137, "Turn off.bmp");
            this.imageList1.Images.SetKeyName(138, "Undo.bmp");
            this.imageList1.Images.SetKeyName(139, "Unlock.bmp");
            this.imageList1.Images.SetKeyName(140, "Up.bmp");
            this.imageList1.Images.SetKeyName(141, "Update.bmp");
            this.imageList1.Images.SetKeyName(142, "Up-down.bmp");
            this.imageList1.Images.SetKeyName(143, "Upload.bmp");
            this.imageList1.Images.SetKeyName(144, "User group.bmp");
            this.imageList1.Images.SetKeyName(145, "View.bmp");
            this.imageList1.Images.SetKeyName(146, "Warning.bmp");
            this.imageList1.Images.SetKeyName(147, "Wrench.bmp");
            this.imageList1.Images.SetKeyName(148, "Yes.bmp");
            this.imageList1.Images.SetKeyName(149, "Zoom.bmp");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.ImageKey = "Create.bmp";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(3, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProjects.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(3, 101);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.RowHeadersVisible = false;
            this.dataGridViewProjects.RowHeadersWidth = 51;
            this.dataGridViewProjects.RowTemplate.Height = 24;
            this.dataGridViewProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjects.Size = new System.Drawing.Size(213, 489);
            this.dataGridViewProjects.TabIndex = 21;
            // 
            // LoadBOM
            // 
            this.LoadBOM.Location = new System.Drawing.Point(910, 65);
            this.LoadBOM.Name = "LoadBOM";
            this.LoadBOM.Size = new System.Drawing.Size(75, 31);
            this.LoadBOM.TabIndex = 20;
            this.LoadBOM.Text = "Load";
            this.LoadBOM.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1155, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(1074, 600);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 31);
            this.button5.TabIndex = 22;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageKey = "Left-right.bmp";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(176, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1461, 639);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM";
            this.Load += new System.EventHandler(this.FrmBOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSaleBOM.ResumeLayout(false);
            this.tabDesignBOM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabActualBOM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.MenuStripSaleBOM.ResumeLayout(false);
            this.MenuStripDesignBOM.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProjectEndUser;
        private System.Windows.Forms.TextBox txtProjectCustomerName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSaleBOM;
        private System.Windows.Forms.TabPage tabDesignBOM;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabActualBOM;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ContextMenuStrip MenuStripSaleBOM;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyAllToDesignBOM;
        private System.Windows.Forms.ContextMenuStrip MenuStripDesignBOM;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyAllToActualBOM;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button LoadBOM;
        private System.Windows.Forms.Button button1;
    }
}

