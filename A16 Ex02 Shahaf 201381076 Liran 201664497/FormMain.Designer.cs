using System.Windows.Forms;
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
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label linkToFacebookLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.tabControlUserData = new System.Windows.Forms.TabControl();
            this.tabWall = new System.Windows.Forms.TabPage();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lableName = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lableEndTime = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLableLink = new System.Windows.Forms.LinkLabel();
            this.labelLocation = new System.Windows.Forms.Label();
            this.lableStartTime = new System.Windows.Forms.Label();
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
            this.checkBoxCheckin = new System.Windows.Forms.CheckBox();
            this.labelLastCheckinPlace = new System.Windows.Forms.Label();
            this.toolTipDescription = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxPlaceToolTip = new System.Windows.Forms.PictureBox();
            this.pictureBoxGraphTooltip = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoadingGif = new System.Windows.Forms.PictureBox();
            this.buttonAvgLikes = new System.Windows.Forms.Button();
            this.buttonGiveMePlaces = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.chartAvgLikesPerHour = new System.Windows.Forms.DataVisualization.Charting.Chart();
            endTimeLabel = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            this.tabControlUserData.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.tabFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlacesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaceToolTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphTooltip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgLikesPerHour)).BeginInit();
            this.SuspendLayout();
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(19, 89);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(83, 19);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.Font = new System.Drawing.Font("Tahoma", 8F);
            linkToFacebookLabel.Location = new System.Drawing.Point(9, 144);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(93, 13);
            linkToFacebookLabel.TabIndex = 6;
            linkToFacebookLabel.Text = "Link To Facebook:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(19, 66);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(89, 19);
            startTimeLabel.TabIndex = 12;
            startTimeLabel.Text = "Start Time:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(19, 14);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(56, 19);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(19, 37);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(74, 19);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
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
            this.tabControlUserData.Location = new System.Drawing.Point(13, 322);
            this.tabControlUserData.Name = "tabControlUserData";
            this.tabControlUserData.SelectedIndex = 0;
            this.tabControlUserData.Size = new System.Drawing.Size(413, 402);
            this.tabControlUserData.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlUserData.TabIndex = 13;
            // 
            // tabWall
            // 
            this.tabWall.AutoScroll = true;
            this.tabWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.tabWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabWall.Location = new System.Drawing.Point(4, 34);
            this.tabWall.Name = "tabWall";
            this.tabWall.Padding = new System.Windows.Forms.Padding(3);
            this.tabWall.Size = new System.Drawing.Size(405, 364);
            this.tabWall.TabIndex = 0;
            this.tabWall.Text = "Wall";
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.lableName);
            this.panel1.Controls.Add(endTimeLabel);
            this.panel1.Controls.Add(this.lableEndTime);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(linkToFacebookLabel);
            this.panel1.Controls.Add(this.linkLableLink);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.Controls.Add(startTimeLabel);
            this.panel1.Controls.Add(this.lableStartTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 166);
            this.panel1.TabIndex = 1026;
            // 
            // lableName
            // 
            this.lableName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.lableName.Location = new System.Drawing.Point(122, 14);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(100, 23);
            this.lableName.TabIndex = 15;
            this.lableName.Text = "Name";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // lableEndTime
            // 
            this.lableEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.lableEndTime.Location = new System.Drawing.Point(122, 89);
            this.lableEndTime.Name = "lableEndTime";
            this.lableEndTime.Size = new System.Drawing.Size(100, 23);
            this.lableEndTime.TabIndex = 3;
            this.lableEndTime.Text = "EndTime";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(255, 14);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(120, 120);
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // linkLableLink
            // 
            this.linkLableLink.AutoSize = true;
            this.linkLableLink.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkLableLink.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linkLableLink.Location = new System.Drawing.Point(108, 144);
            this.linkLableLink.Name = "linkLableLink";
            this.linkLableLink.Size = new System.Drawing.Size(25, 13);
            this.linkLableLink.TabIndex = 7;
            this.linkLableLink.TabStop = true;
            this.linkLableLink.Text = "Link";
            // 
            // labelLocation
            // 
            this.labelLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.labelLocation.Location = new System.Drawing.Point(122, 37);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(100, 23);
            this.labelLocation.TabIndex = 9;
            this.labelLocation.Text = "Location";
            // 
            // lableStartTime
            // 
            this.lableStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.lableStartTime.Location = new System.Drawing.Point(122, 66);
            this.lableStartTime.Name = "lableStartTime";
            this.lableStartTime.Size = new System.Drawing.Size(100, 23);
            this.lableStartTime.TabIndex = 13;
            this.lableStartTime.Text = "StartTime";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxEvents.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(3, 3);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(399, 192);
            this.listBoxEvents.TabIndex = 13;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPlacesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewPlacesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPlacesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeNameColumn,
            this.addressColumn,
            this.isOpenColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPlacesList.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewPlacesList.EnableHeadersVisualStyles = false;
            this.gridViewPlacesList.GridColor = System.Drawing.Color.Gray;
            this.gridViewPlacesList.Location = new System.Drawing.Point(482, 428);
            this.gridViewPlacesList.MultiSelect = false;
            this.gridViewPlacesList.Name = "gridViewPlacesList";
            this.gridViewPlacesList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPlacesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewPlacesList.RowHeadersVisible = false;
            this.gridViewPlacesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewPlacesList.Size = new System.Drawing.Size(554, 212);
            this.gridViewPlacesList.TabIndex = 1007;
            this.gridViewPlacesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridViewPlacesList_CellFormatting);
            // 
            // placeNameColumn
            // 
            this.placeNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.placeNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.isOpenColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            // pictureBoxPlaceToolTip
            // 
            this.pictureBoxPlaceToolTip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlaceToolTip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlaceToolTip.Image")));
            this.pictureBoxPlaceToolTip.Location = new System.Drawing.Point(972, 368);
            this.pictureBoxPlaceToolTip.Name = "pictureBoxPlaceToolTip";
            this.pictureBoxPlaceToolTip.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPlaceToolTip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlaceToolTip.TabIndex = 1025;
            this.pictureBoxPlaceToolTip.TabStop = false;
            this.toolTipDescription.SetToolTip(this.pictureBoxPlaceToolTip, "Press for near places.");
            // 
            // pictureBoxGraphTooltip
            // 
            this.pictureBoxGraphTooltip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGraphTooltip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGraphTooltip.Image")));
            this.pictureBoxGraphTooltip.Location = new System.Drawing.Point(486, 127);
            this.pictureBoxGraphTooltip.Name = "pictureBoxGraphTooltip";
            this.pictureBoxGraphTooltip.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxGraphTooltip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGraphTooltip.TabIndex = 1024;
            this.pictureBoxGraphTooltip.TabStop = false;
            this.toolTipDescription.SetToolTip(this.pictureBoxGraphTooltip, "Press to get your likes statictics");
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
            // chartAvgLikesPerHour
            // 
            this.chartAvgLikesPerHour.BackColor = System.Drawing.Color.Transparent;
            this.chartAvgLikesPerHour.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            this.chartAvgLikesPerHour.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea";
            chartArea1.Visible = false;
            this.chartAvgLikesPerHour.ChartAreas.Add(chartArea1);
            this.chartAvgLikesPerHour.Location = new System.Drawing.Point(601, 100);
            this.chartAvgLikesPerHour.Name = "chartAvgLikesPerHour";
            this.chartAvgLikesPerHour.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Name = "AvgLikesPerHour";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series1.YValuesPerPoint = 2;
            this.chartAvgLikesPerHour.Series.Add(series1);
            this.chartAvgLikesPerHour.Size = new System.Drawing.Size(435, 226);
            this.chartAvgLikesPerHour.TabIndex = 1019;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1100, 728);
            this.Controls.Add(this.pictureBoxPlaceToolTip);
            this.Controls.Add(this.pictureBoxGraphTooltip);
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
            this.tabEvents.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.tabFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlacesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaceToolTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphTooltip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgLikesPerHour)).EndInit();
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
        private System.Windows.Forms.Button buttonAvgLikes;
        private System.Windows.Forms.CheckBox checkBoxCheckin;
        private System.Windows.Forms.Label labelLastCheckinPlace;
        private System.Windows.Forms.PictureBox pictureBoxLoadingGif;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxGraphTooltip;
        private System.Windows.Forms.PictureBox pictureBoxPlaceToolTip;
        private System.Windows.Forms.ToolTip toolTipDescription;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAvgLikesPerHour;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lableEndTime;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.LinkLabel linkLableLink;
        private System.Windows.Forms.Label lableStartTime;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Label labelLocation;
    }
}