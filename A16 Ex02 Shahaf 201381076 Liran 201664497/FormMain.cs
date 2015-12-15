using System;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool loginSuccess = Controller.Login();

            if (loginSuccess)
            {
                labelUserName.Text = Controller.GetUserName();
                labelUserName.Visible = true;
                setButtonsVisible();
                fetchUserPicture();
                listBoxPostsFilling();
                listBoxEventsFilling();
                listBoxFriendsFilling();
            }
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

        private void fetchUserPicture()
        {
            UserPictureBox.LoadAsync(Controller.GetUserProfilePicture());
        }

        private void listBoxEventsFilling()
        {
            listBoxEvents.DisplayMember = "Name";
            eventBindingSource.DataSource = Controller.GetUserEvents();

        }

        private void listBoxPostsFilling()
        {
            FacebookObjectCollection<Post> posts = Controller.GetUnEmptyUserPosts();
            int top = 0;

            foreach (Post post in posts)
            {
                StatusComponent statusComponent = new StatusComponent(new Size(tabWall.Width, 50));
                tabWall.Controls.Add(statusComponent);
                statusComponent.Top = top;
                statusComponent.m_LabelStatus.Text = post.Message;
                statusComponent.m_LabelLikes.Text = post.LikedBy.Count.ToString();
                statusComponent.m_LabelDate.Text = post.CreatedTime.ToString();
                

                top = statusComponent.Bottom + 5;
            }
        }

        private void listBoxFriendsFilling()
        {
            listBoxFriend.DisplayMember = "Name";
            listBoxFriend.DataSource = Controller.GetUserFriends();
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFriendPicture();
        }

        //private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Event selectedEvent = listBoxEvents.SelectedItem as Event;
        //    pictureBoxEventPicture.LoadAsync(selectedEvent.PictureNormalURL);
        //    labelSelectedEventDate.Text = string.Format("Date : {0}", selectedEvent.StartTime.ToString());
        //    labelSelectedEventLocation.Text = string.Format("Location : {0}", selectedEvent.Location);
        //    labelEventDescription.Text = string.Format("Description : {0}", selectedEvent.Description);
        //}

        private void ShowFriendPicture()
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
                List<GooglePlace> recPlaces = Controller.GetRecommendedPlaces(textBoxKeyWord.Text, trackBarRadius.Value);
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

        private void addPlaceToGridView(List<GooglePlace> i_Places)
        {
            foreach (GooglePlace googlePlace in i_Places)
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
            MustLikesStatisticsHourUtils MustLikedPostHour = new MustLikesStatisticsHourUtils();
            SortedDictionary<int, UserPostsForDictionary> avgLikes = Controller.GetAvgLikesPerHour();
            this.Invoke((MethodInvoker)delegate
            {
                if (chartAvgLikesPerHour.Series[chartName].Points.Count != 0)
                {
                    chartAvgLikesPerHour.Series[chartName].Points.Clear();
                }

                foreach (KeyValuePair<int, UserPostsForDictionary> entry in avgLikes)
                {
                    chartAvgLikesPerHour.Series[chartName].Points.AddXY(entry.Key, entry.Value.m_AvrageLikesPerPost);
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
