using A16_Ex01_Shahaf_201381076_Liran_201664497.CostumControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class StatusPanel : Panel
    {
        public Label m_LabelStatus { get; set; }
        
        public Label m_LabelDate { get; set; }
        
        public Label m_LabelLikes { get; set; }

        public PictureBox m_pictureBoxLikes { get; set; }

        public string m_PictureName { get; set; }

        public StatusPanel()
            : this(new Size(400, 150))
        {
        }

        public StatusPanel(Size i_Size)
        {
            m_LabelStatus = new Label();
            m_LabelDate = new Label();
            m_LabelLikes = new Label();
            m_pictureBoxLikes = new PictureBox();

            setDefaultProperties(i_Size);
        }

        private void setDefaultProperties(Size i_Size)
        {
            this.BackColor = Color.FromArgb(75, Color.White);
            this.BorderStyle = BorderStyle.None;
            this.Size = i_Size;

            setLableStatus(i_Size);
            setPictureBoxLikes();
            setLableLikes();
            setLableDate();

            this.Controls.AddRange(new Control[] { m_LabelStatus, m_LabelDate, m_LabelLikes, m_pictureBoxLikes });
        }

        private void setLableStatus(Size i_Size)
        {
            this.m_LabelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_LabelStatus.AutoSize = true;
            this.m_LabelStatus.MaximumSize = i_Size;
            this.m_LabelStatus.BackColor = Color.Transparent;
        }

        private void setPictureBoxLikes()
        {
            int pictureBoxSize = this.Size.Height / 4;
            this.m_pictureBoxLikes.Anchor = (AnchorStyles)(AnchorStyles.Bottom | AnchorStyles.Left);
            this.m_pictureBoxLikes.Size = new Size(pictureBoxSize, pictureBoxSize);
            this.m_pictureBoxLikes.Location = new Point(this.Left + 5, this.Bottom - pictureBoxSize - 10);
            this.m_pictureBoxLikes.BackColor = Color.Transparent;
            this.m_pictureBoxLikes.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void setLableLikes()
        {
            this.m_LabelLikes.AutoSize = true;
            this.m_LabelLikes.Anchor = (AnchorStyles)(AnchorStyles.Bottom | AnchorStyles.Left);
            this.m_LabelLikes.Location = new Point(this.m_pictureBoxLikes.Right + 5, (m_pictureBoxLikes.Top + m_pictureBoxLikes.Bottom) / 2);
            this.m_LabelLikes.BackColor = Color.Transparent;
        }

        private void setLableDate()
        {
            this.m_LabelDate.AutoSize = true;
            this.m_LabelDate.Anchor = (AnchorStyles)(AnchorStyles.Bottom | AnchorStyles.Right);
            this.m_LabelDate.Location = new Point(this.Right - m_LabelDate.Width, this.Bottom - m_LabelDate.Height);
            this.m_LabelDate.BackColor = Color.Transparent;
        }

        private void setDefaultProperties(Control i_Control)
        {
            i_Control.BackColor = Color.Transparent;
        }

        public void Fit()
        {
            this.Size = new Size(this.Width, m_LabelLikes.Height + m_LabelStatus.Height + 50);
            this.m_LabelLikes.Location = new Point(this.m_pictureBoxLikes.Right + 5, (m_pictureBoxLikes.Top + m_pictureBoxLikes.Bottom) / 2);
            this.m_LabelDate.Location = new Point(this.Right - m_LabelDate.Width, this.Bottom - m_LabelDate.Height);
        }
    }
}
