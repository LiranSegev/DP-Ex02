using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497.CostumControls
{
    class PanelFavoriteHourForGraph 
    {
        public Panel m_Panel = new Panel(); 

        public Label m_labelFavoriteHour { get; set; }

        public Label m_labelFavoriteHourShow { get; set; }

        public PanelFavoriteHourForGraph()
        {
            this.m_Panel.Size = new Size(400, 150);
            this.m_Panel.BackColor = Color.FromArgb(255, 245, 238);
            this.m_Panel.Controls.Add(m_labelFavoriteHour = new Label());
            m_labelFavoriteHour.Text = "Favorite Hour :";
            this.m_Panel.Controls.Add(m_labelFavoriteHourShow = new Label());
            m_labelFavoriteHourShow.Text = "--:--";
        }

        public void PositionLabelFavoriteHour()
        {
            m_labelFavoriteHour.Location = new Point(this.m_Panel.Left + 10, this.m_Panel.Top - 10);
            m_labelFavoriteHour.BackColor = Color.FromArgb(165, 42, 42);
            m_labelFavoriteHour.Font = new Font("Times New Roman", 50);
        }

        public void PositionFavoriteHourShow()
        {
            m_labelFavoriteHourShow.Location = new Point(this.m_Panel.Left + 10, this.m_Panel.Top - m_labelFavoriteHour.Height - 10);
            m_labelFavoriteHourShow.Font = new Font("Times New Roman", 50);
            m_labelFavoriteHourShow.BackColor = Color.FromArgb(165, 42, 42);
        }
    }
}
