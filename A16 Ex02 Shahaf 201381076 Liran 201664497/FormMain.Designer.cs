namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.tabControlUserData = new System.Windows.Forms.TabControl();
            this.tabWall = new System.Windows.Forms.TabPage();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.labelSelectedEventLocation = new System.Windows.Forms.Label();
            this.labelSelectedEventDate = new System.Windows.Forms.Label();
            this.pictureBoxEventPicture = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.pictureBoxFriendPic = new System.Windows.Forms.PictureBox();
            this.listBoxFriend = new System.Windows.Forms.ListBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.gridViewPlacesList = new System.Windows.Forms.DataGridView();
            this.placeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOpenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxKeyWord = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.chartAvgLikesPerHour = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxCheckin = new System.Windows.Forms.CheckBox();
            this.labelLastCheckinPlace = new System.Windows.Forms.Label();
            this.toolTipDescription = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoadingGif = new System.Windows.Forms.PictureBox();
            this.buttonAvgLikes = new System.Windows.Forms.Button();
            this.buttonGiveMePlaces = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.tabControlUserData.SuspendLayout();
            this.tabWall.SuspendLayout();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).BeginInit();
            this.tabFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlacesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgLikesPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxStatus.ForeColor = System.Drawing.Color.Gray;
            this.textBoxStatus.Location = new System.Drawing.Point(564, 32);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(402, 49);
            this.textBoxStatus.TabIndex = 999;
            this.textBoxStatus.Text = "What\'s on your mind...";
            this.textBoxStatus.Enter += new System.EventHandler(this.textBoxStatus_Enter);
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonPost.Enabled = false;
            this.buttonPost.FlatAppearance.BorderSize = 0;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(972, 32);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(93, 49);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // tabControlUserData
            // 
            this.tabControlUserData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlUserData.Controls.Add(this.tabWall);
            this.tabControlUserData.Controls.Add(this.tabEvents);
            this.tabControlUserData.Controls.Add(this.tabFriends);
            this.tabControlUserData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlUserData.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControlUserData.Location = new System.Drawing.Point(13, 242);
            this.tabControlUserData.Name = "tabControlUserData";
            this.tabControlUserData.SelectedIndex = 0;
            this.tabControlUserData.Size = new System.Drawing.Size(413, 402);
            this.tabControlUserData.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlUserData.TabIndex = 13;
            // 
            // tabWall
            // 
            this.tabWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabWall.Controls.Add(this.listBoxStatus);
            this.tabWall.Location = new System.Drawing.Point(4, 34);
            this.tabWall.Name = "tabWall";
            this.tabWall.Padding = new System.Windows.Forms.Padding(3);
            this.tabWall.Size = new System.Drawing.Size(405, 364);
            this.tabWall.TabIndex = 0;
            this.tabWall.Text = "Wall";
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.labelEventDescription);
            this.tabEvents.Controls.Add(this.labelSelectedEventLocation);
            this.tabEvents.Controls.Add(this.labelSelectedEventDate);
            this.tabEvents.Controls.Add(this.pictureBoxEventPicture);
            this.tabEvents.Controls.Add(this.listBoxEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 34);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabEvents.Size = new System.Drawing.Size(405, 364);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelEventDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEventDescription.Location = new System.Drawing.Point(174, 277);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(214, 65);
            this.labelEventDescription.TabIndex = 1017;
            this.labelEventDescription.Text = "Description";
            // 
            // labelSelectedEventLocation
            // 
            this.labelSelectedEventLocation.AutoSize = true;
            this.labelSelectedEventLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedEventLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSelectedEventLocation.Location = new System.Drawing.Point(174, 253);
            this.labelSelectedEventLocation.Name = "labelSelectedEventLocation";
            this.labelSelectedEventLocation.Size = new System.Drawing.Size(68, 19);
            this.labelSelectedEventLocation.TabIndex = 1016;
            this.labelSelectedEventLocation.Text = "Location";
            // 
            // labelSelectedEventDate
            // 
            this.labelSelectedEventDate.AutoSize = true;
            this.labelSelectedEventDate.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedEventDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSelectedEventDate.Location = new System.Drawing.Point(174, 229);
            this.labelSelectedEventDate.Name = "labelSelectedEventDate";
            this.labelSelectedEventDate.Size = new System.Drawing.Size(41, 19);
            this.labelSelectedEventDate.TabIndex = 1015;
            this.labelSelectedEventDate.Text = "Date";
            // 
            // pictureBoxEventPicture
            // 
            this.pictureBoxEventPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEventPicture.Location = new System.Drawing.Point(15, 229);
            this.pictureBoxEventPicture.Name = "pictureBoxEventPicture";
            this.pictureBoxEventPicture.Size = new System.Drawing.Size(134, 122);
            this.pictureBoxEventPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEventPicture.TabIndex = 1015;
            this.pictureBoxEventPicture.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxEvents.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(3, 3);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(399, 192);
            this.listBoxEvents.TabIndex = 13;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // tabFriends
            // 
            this.tabFriends.Controls.Add(this.pictureBoxFriendPic);
            this.tabFriends.Controls.Add(this.listBoxFriend);
            this.tabFriends.Location = new System.Drawing.Point(4, 34);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabFriends.Size = new System.Drawing.Size(405, 364);
            this.tabFriends.TabIndex = 2;
            this.tabFriends.Text = "Friends";
            this.tabFriends.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriendPic
            // 
            this.pictureBoxFriendPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFriendPic.Location = new System.Drawing.Point(284, 17);
            this.pictureBoxFriendPic.Name = "pictureBoxFriendPic";
            this.pictureBoxFriendPic.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFriendPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendPic.TabIndex = 14;
            this.pictureBoxFriendPic.TabStop = false;
            // 
            // listBoxFriend
            // 
            this.listBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFriend.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxFriend.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriend.FormattingEnabled = true;
            this.listBoxFriend.ItemHeight = 16;
            this.listBoxFriend.Location = new System.Drawing.Point(3, 3);
            this.listBoxFriend.Name = "listBoxFriend";
            this.listBoxFriend.Size = new System.Drawing.Size(231, 358);
            this.listBoxFriend.TabIndex = 13;
            this.listBoxFriend.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelType.Location = new System.Drawing.Point(487, 353);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(123, 13);
            this.labelType.TabIndex = 1003;
            this.labelType.Text = "What you\'r looking for : ";
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRadius.Location = new System.Drawing.Point(487, 380);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(39, 13);
            this.labelRadius.TabIndex = 1004;
            this.labelRadius.Text = "Radius";
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trackBarRadius.LargeChange = 100;
            this.trackBarRadius.Location = new System.Drawing.Point(533, 377);
            this.trackBarRadius.Maximum = 5000;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(338, 45);
            this.trackBarRadius.TabIndex = 1005;
            this.trackBarRadius.TickFrequency = 100;
            this.trackBarRadius.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRadius.ValueChanged += new System.EventHandler(this.trackBarRadius_ValueChanged);
            // 
            // gridViewPlacesList
            // 
            this.gridViewPlacesList.AllowUserToDeleteRows = false;
            this.gridViewPlacesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewPlacesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewPlacesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPlacesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewPlacesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPlacesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeNameColumn,
            this.addressColumn,
            this.isOpenColumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPlacesList.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridViewPlacesList.EnableHeadersVisualStyles = false;
            this.gridViewPlacesList.GridColor = System.Drawing.Color.Gray;
            this.gridViewPlacesList.Location = new System.Drawing.Point(482, 428);
            this.gridViewPlacesList.MultiSelect = false;
            this.gridViewPlacesList.Name = "gridViewPlacesList";
            this.gridViewPlacesList.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPlacesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridViewPlacesList.RowHeadersVisible = false;
            this.gridViewPlacesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewPlacesList.Size = new System.Drawing.Size(554, 212);
            this.gridViewPlacesList.TabIndex = 1007;
            this.gridViewPlacesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridViewPlacesList_CellFormatting);
            // 
            // placeNameColumn
            // 
            this.placeNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.placeNameColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.placeNameColumn.HeaderText = "Place Name";
            this.placeNameColumn.Name = "placeNameColumn";
            this.placeNameColumn.ReadOnly = true;
            this.placeNameColumn.Width = 120;
            // 
            // addressColumn
            // 
            this.addressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            this.addressColumn.Width = 300;
            // 
            // isOpenColumn
            // 
            this.isOpenColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.isOpenColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.isOpenColumn.HeaderText = "Open/Close";
            this.isOpenColumn.Name = "isOpenColumn";
            this.isOpenColumn.ReadOnly = true;
            // 
            // textBoxKeyWord
            // 
            this.textBoxKeyWord.Location = new System.Drawing.Point(611, 349);
            this.textBoxKeyWord.Name = "textBoxKeyWord";
            this.textBoxKeyWord.Size = new System.Drawing.Size(248, 20);
            this.textBoxKeyWord.TabIndex = 1014;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(216, 92);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(87, 19);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            this.labelUserName.Visible = false;
            // 
            // chartAvgLikesPerHour
            // 
            this.chartAvgLikesPerHour.BackColor = System.Drawing.Color.Transparent;
            this.chartAvgLikesPerHour.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            this.chartAvgLikesPerHour.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea";
            chartArea2.Visible = false;
            this.chartAvgLikesPerHour.ChartAreas.Add(chartArea2);
            this.chartAvgLikesPerHour.Location = new System.Drawing.Point(601, 100);
            this.chartAvgLikesPerHour.Name = "chartAvgLikesPerHour";
            this.chartAvgLikesPerHour.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.Name = "AvgLikesPerHour";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series2.YValuesPerPoint = 2;
            this.chartAvgLikesPerHour.Series.Add(series2);
            this.chartAvgLikesPerHour.Size = new System.Drawing.Size(435, 226);
            this.chartAvgLikesPerHour.TabIndex = 1019;
            // 
            // checkBoxCheckin
            // 
            this.checkBoxCheckin.AutoSize = true;
            this.checkBoxCheckin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCheckin.Location = new System.Drawing.Point(570, 12);
            this.checkBoxCheckin.Name = "checkBoxCheckin";
            this.checkBoxCheckin.Size = new System.Drawing.Size(63, 17);
            this.checkBoxCheckin.TabIndex = 1020;
            this.checkBoxCheckin.Text = "Checkin";
            this.checkBoxCheckin.UseVisualStyleBackColor = true;
            this.checkBoxCheckin.CheckedChanged += new System.EventHandler(this.checkBoxCheckin_CheckedChanged);
            // 
            // labelLastCheckinPlace
            // 
            this.labelLastCheckinPlace.AutoSize = true;
            this.labelLastCheckinPlace.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLastCheckinPlace.Location = new System.Drawing.Point(627, 409);
            this.labelLastCheckinPlace.Name = "labelLastCheckinPlace";
            this.labelLastCheckinPlace.Size = new System.Drawing.Size(77, 16);
            this.labelLastCheckinPlace.TabIndex = 1021;
            this.labelLastCheckinPlace.Text = "Last checkin";
            // 
            // toolTipDescription
            // 
            this.toolTipDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.toolTipDescription.ForeColor = System.Drawing.Color.White;
            this.toolTipDescription.IsBalloon = true;
            this.toolTipDescription.OwnerDraw = true;
            this.toolTipDescription.ShowAlways = true;
            this.toolTipDescription.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(972, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1025;
            this.pictureBox2.TabStop = false;
            this.toolTipDescription.SetToolTip(this.pictureBox2, "Press for near places.");
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGraph.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGraph.Image")));
            this.pictureBoxGraph.Location = new System.Drawing.Point(486, 127);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGraph.TabIndex = 1024;
            this.pictureBoxGraph.TabStop = false;
            this.toolTipDescription.SetToolTip(this.pictureBoxGraph, "Press to get your likes statictics");
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(179, 81);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1023;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxLoadingGif
            // 
            this.pictureBoxLoadingGif.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoadingGif.Image = global::A16_Ex01_Shahaf_201381076_Liran_201664497.Properties.Resources.LoadingGif;
            this.pictureBoxLoadingGif.Location = new System.Drawing.Point(733, 169);
            this.pictureBoxLoadingGif.Name = "pictureBoxLoadingGif";
            this.pictureBoxLoadingGif.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxLoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLoadingGif.TabIndex = 1022;
            this.pictureBoxLoadingGif.TabStop = false;
            this.pictureBoxLoadingGif.Visible = false;
            // 
            // buttonAvgLikes
            // 
            this.buttonAvgLikes.BackColor = System.Drawing.Color.Transparent;
            this.buttonAvgLikes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAvgLikes.BackgroundImage")));
            this.buttonAvgLikes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAvgLikes.Enabled = false;
            this.buttonAvgLikes.FlatAppearance.BorderSize = 0;
            this.buttonAvgLikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvgLikes.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAvgLikes.Location = new System.Drawing.Point(514, 100);
            this.buttonAvgLikes.Name = "buttonAvgLikes";
            this.buttonAvgLikes.Size = new System.Drawing.Size(60, 60);
            this.buttonAvgLikes.TabIndex = 1018;
            this.buttonAvgLikes.UseVisualStyleBackColor = false;
            this.buttonAvgLikes.Click += new System.EventHandler(this.buttonAvgLikes_Click);
            // 
            // buttonGiveMePlaces
            // 
            this.buttonGiveMePlaces.BackgroundImage = global::A16_Ex01_Shahaf_201381076_Liran_201664497.Properties.Resources.SearchIcon;
            this.buttonGiveMePlaces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGiveMePlaces.Enabled = false;
            this.buttonGiveMePlaces.FlatAppearance.BorderSize = 0;
            this.buttonGiveMePlaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGiveMePlaces.Location = new System.Drawing.Point(906, 333);
            this.buttonGiveMePlaces.Name = "buttonGiveMePlaces";
            this.buttonGiveMePlaces.Size = new System.Drawing.Size(60, 60);
            this.buttonGiveMePlaces.TabIndex = 1006;
            this.buttonGiveMePlaces.UseVisualStyleBackColor = true;
            this.buttonGiveMePlaces.Click += new System.EventHandler(this.buttonGiveMePlaces_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::A16_Ex01_Shahaf_201381076_Liran_201664497.Properties.Resources.buttonLoginPicture;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(13, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(177, 49);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPictureBox.Location = new System.Drawing.Point(21, 81);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(145, 138);
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStatus.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 16;
            this.listBoxStatus.Location = new System.Drawing.Point(3, 3);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(397, 336);
            this.listBoxStatus.TabIndex = 12;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1080, 657);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.pictureBoxLoadingGif);
            this.Controls.Add(this.labelLastCheckinPlace);
            this.Controls.Add(this.checkBoxCheckin);
            this.Controls.Add(this.chartAvgLikesPerHour);
            this.Controls.Add(this.buttonAvgLikes);
            this.Controls.Add(this.textBoxKeyWord);
            this.Controls.Add(this.gridViewPlacesList);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonGiveMePlaces);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.tabControlUserData);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.UserPictureBox);
            this.Controls.Add(this.trackBarRadius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faecbook";
            this.tabControlUserData.ResumeLayout(false);
            this.tabWall.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).EndInit();
            this.tabFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlacesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgLikesPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TabControl tabControlUserData;
        private System.Windows.Forms.TabPage tabWall;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxFriend;
        private System.Windows.Forms.PictureBox pictureBoxFriendPic;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.Button buttonGiveMePlaces;
        private System.Windows.Forms.DataGridView gridViewPlacesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isOpenColumn;
        private System.Windows.Forms.TextBox textBoxKeyWord;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxEventPicture;
        private System.Windows.Forms.Label labelSelectedEventLocation;
        private System.Windows.Forms.Label labelSelectedEventDate;
        private System.Windows.Forms.Button buttonAvgLikes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAvgLikesPerHour;
        private System.Windows.Forms.Label labelEventDescription;
        private System.Windows.Forms.CheckBox checkBoxCheckin;
        private System.Windows.Forms.Label labelLastCheckinPlace;
        private System.Windows.Forms.PictureBox pictureBoxLoadingGif;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTipDescription;
        private System.Windows.Forms.ListBox listBoxStatus;
    }
}