using System;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A16_Ex01_Shahaf_201381076_Liran_201664497.CostumControls;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public partial class formMain : Form
    {
        public formMain()
        {

            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool loginSuccess = Controller.Login();

            if (loginSuccess)
            {
                labelUserName.Text = Controller.GetUserName();
                labelUserName.Visible = true;
                setButtonsVisible();
                addUserPicture();
                new Thread(addTabsItems).Start();
            }
        }

        private void addTabsItems()
        {
            tabControlUserData.Invoke(new Action(
                () =>
                {
                    addStatuses();
                    addEvents();
                    addFriends();
                }
                        ));
        }

        private void setButtonsVisible()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    (control as Button).Enabled = true;
                }
            }
        }

        private void addUserPicture()
        {
            UserPictureBox.LoadAsync(Controller.GetUserProfilePicture());
        }

        private void addEvents()
        {
            listBoxEvents.DisplayMember = "Name";
            eventBindingSource.DataSource = Controller.GetUserEvents();

        }

        private void addStatuses()
        {
            List<Status> statuses = Controller.GetUserStatuses();
            int PanelTop = 0;
            Size panelSize = new Size(tabStatus.Size.Width - SystemInformation.VerticalScrollBarWidth, 135);
            string ImageFileName = "Likes";
            Image image = (Image)(Properties.Resources.ResourceManager.GetObject(ImageFileName));

            foreach (Status status in statuses)
            {
                StatusPanel statusPanel = new StatusPanelBuilder()
                        .AddConfiguration(new ControlConfiguration { Size = panelSize })
                        .AddImage(image)
                        .AddStatus(status)
                        .Build();

                tabStatus.Controls.Add(statusPanel);
                statusPanel.Top = PanelTop;
                PanelTop = statusPanel.Bottom + 5;
            }
        }

        private void addFriends()
        {
            listBoxFriend.DisplayMember = "Name";
            listBoxFriend.DataSource = Controller.GetUserFriends();
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedFriendPicture();
        }

        private void showSelectedFriendPicture()
        {
            if (listBoxFriend.SelectedItems.Count == 1)
            {
                User SelectedFriend = listBoxFriend.SelectedItem as User;
                if (SelectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriendPic.LoadAsync(SelectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriendPic.Image = pictureBoxFriendPic.ErrorImage;
                }
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (checkBoxCheckin.Checked)
            {
                postCheckin();
            }
            else
            {
                postStatus();
            }
        }

        private void textBoxStatus_Enter(object sender, EventArgs e)
        {
            textBoxStatus.Text = string.Empty;
            textBoxStatus.ForeColor = System.Drawing.Color.Black;
        }

        private void trackBarRadius_ValueChanged(object sender, EventArgs e)
        {
            labelRadius.Text = "Radius";
            if (trackBarRadius.Value != 0)
            {
                labelRadius.Text = string.Format("{0} meters", trackBarRadius.Value.ToString()).ToString();
            }
        }

        private void buttonGiveMePlaces_Click(object sender, EventArgs e)
        {
            gridViewPlacesList.Rows.Clear();
            try
            {
                List<Place> recPlaces = Controller.GetRecommendedPlaces(textBoxKeyWord.Text, trackBarRadius.Value);
                if (recPlaces.Count == 0)
                {
                    gridViewPlacesList.Rows.Add(" - ", "Places Not Found", " - ");
                }
                else
                {
                    addPlaceToGridView(recPlaces);
                }
            }
            catch (Exception ex)
            {
                gridViewPlacesList.Rows.Add(" - ", ex.Message, " - ");
            }
        }

        private void addPlaceToGridView(List<Place> i_Places)
        {
            foreach (Place googlePlace in i_Places)
            {
                string openingHours = "Unknown";
                if (googlePlace.m_OpeningHours != null)
                {
                    openingHours = googlePlace.m_OpeningHours.isOpen == "True" ? "Open" : "Close";
                }

                gridViewPlacesList.Rows.Add(googlePlace.m_Name, googlePlace.m_Vicinity, openingHours);
            }
        }

        private void gridViewPlacesList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell isOpenCell = gridViewPlacesList.Rows[e.RowIndex].Cells[2];

            if (isOpenCell.Value != null)
            {
                if (Convert.ToString(isOpenCell.Value.ToString()) == "Close")
                {
                    isOpenCell.Style.BackColor = Color.FromArgb(255, 255, 100, 70);
                }
                else
                {
                    isOpenCell.Style.BackColor = Color.FromArgb(255, 50, 205, 50);
                }
            }
        }

        private void buttonAvgLikes_Click(object sender, EventArgs e)
        {
            pictureBoxLoadingGif.Visible = true;
            buttonAvgLikes.Enabled = false;
            Thread thread = new Thread(threadChartUpdate);
            thread.Start();
        }

        private void threadChartUpdate()
        {
            string chartName = "AvgLikesPerHour";
            SortedDictionary<int, LikesAggregation> avgLikes = Controller.GetAvgLikesPerHour();
            this.Invoke((MethodInvoker)delegate
            {
                if (chartAvgLikesPerHour.Series[chartName].Points.Count != 0)
                {
                    chartAvgLikesPerHour.Series[chartName].Points.Clear();
                }

                foreach (KeyValuePair<int, LikesAggregation> entry in avgLikes)
                {
                    chartAvgLikesPerHour.Series[chartName].Points.AddXY(entry.Key, entry.Value.GetAvrageLikes());
                }

                pictureBoxLoadingGif.Visible = false;
                buttonAvgLikes.Enabled = true;
                chartAvgLikesPerHour.ChartAreas[0].Visible = true;
                chartAvgLikesPerHour.Visible = true;
            });
        }

        private void postCheckin()
        {
            try
            {
                Checkin placePageId = Controller.PostCheckin(textBoxStatus.Text);
                textBoxStatus.Text = string.Format("Checking : {0}", placePageId.Name);
                labelLastCheckinPlace.Text = string.Format("Your last place : {0}", placePageId.Name);
            }
            catch (Exception ex)
            {
                textBoxStatus.Text = ex.Message;
            }
        }

        private void postStatus()
        {
            Controller.PostStatus(textBoxStatus.Text);
            textBoxStatus.Text = "Sent";
        }

        private void checkBoxCheckin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckin.Checked)
            {
                textBoxStatus.Text = "Where are you now ? ";
            }
            else
            {
                textBoxStatus.Text = "What's on your mind...?";
            }
        }
    }
}
