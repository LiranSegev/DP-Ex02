using System;
using System.Drawing;
using System.Windows.Forms;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class StatusComponent : Panel
    {
        public Label m_LabelStatus { get; set; }
        public Label m_LabelDate { get; set; }
        public Label m_LabelLikes { get; set; }
        public PictureBox m_pictureBoxLikes { get; set; }
        public Font m_Font { get; set; }
        public string m_PictureName { get; set; }

        public StatusComponent()
            : this(new Size(400, 150))
        {
        }

        public StatusComponent(Size i_Size)
        {
            this.Size = i_Size;
            m_Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, ((byte)(177)));
            m_LabelStatus = new Label();
            m_LabelDate = new Label();
            m_LabelLikes = new Label();
            m_pictureBoxLikes = new PictureBox();
            m_PictureName = "Likes";

            setupProperties();
        }

        private void setupProperties()
        {
            this.BackColor = Color.FromArgb(75, Color.White);
            this.BorderStyle = BorderStyle.None;

            setLableStatus();
            setPictureBoxLikes();
            setLableLikes();
            setLableDate();

            this.m_LabelStatus.TextChanged += m_LabelStatus_TextChanged;
            this.Controls.Add(this.m_LabelStatus);
            this.Controls.Add(this.m_LabelDate);
            this.Controls.Add(this.m_LabelLikes);
            this.Controls.Add(this.m_pictureBoxLikes);
        }

        private void m_LabelStatus_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, this.Height + (sender as Label).Height);
        }

        private void setLableStatus()
        {
            this.m_LabelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_LabelStatus.AutoSize = true;
            this.m_LabelStatus.MaximumSize = this.Size;
            this.m_LabelStatus.Font = m_Font;
            this.m_LabelStatus.BackColor = Color.Transparent;
        }

        private void setPictureBoxLikes()
        {
            int pictureBoxSize = 35;
            this.m_pictureBoxLikes.Anchor = (AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left));
            this.m_pictureBoxLikes.Image = (System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject(m_PictureName));
            this.m_pictureBoxLikes.Size = new Size(pictureBoxSize, pictureBoxSize);
            this.m_pictureBoxLikes.Location = new Point(this.Left + 5, this.Bottom - pictureBoxSize - 10);
            this.m_pictureBoxLikes.BackColor = Color.Transparent;
            this.m_pictureBoxLikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void setLableLikes()
        {
            this.m_LabelLikes.AutoSize = true;
            this.m_LabelLikes.Anchor = AnchorStyles.Bottom;
            this.m_LabelLikes.Location = new Point(this.m_pictureBoxLikes.Right + 5, this.m_pictureBoxLikes.Top + (this.m_pictureBoxLikes.Top / 2));
            this.m_LabelLikes.BackColor = Color.Transparent;
        }

        private void setLableDate()
        {
            this.m_LabelDate.AutoSize = true;
            this.m_LabelDate.Anchor = (AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right));
            this.m_LabelDate.Location = new System.Drawing.Point(this.Width / 2, this.m_LabelLikes.Top);
            this.m_LabelDate.BackColor = Color.Transparent;
        }

        private void setDefaultProperties(Control i_Control)
        {
            i_Control.Font = m_Font;
            i_Control.BackColor = Color.Transparent;
        }
    }
}
