using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497.CostumControls
{
    public class StatusPanelBuilder : IControlBuilder<StatusPanelBuilder>
    {
        public ControlConfiguration m_ControlConfiguration { get; set; }

        public Status m_Status { get; set; }
        
        public Image m_Image { get; set; }

        public StatusPanelBuilder AddConfiguration(ControlConfiguration i_ControlConfiguration)
        {
            this.m_ControlConfiguration = i_ControlConfiguration;

            return this;
        }

        public StatusPanelBuilder AddStatus(Status i_Status)
        {
            this.m_Status = i_Status;

            return this;
        }

        public StatusPanelBuilder AddImage(Image i_Image)
        {
            this.m_Image = i_Image;

            return this;
        }

        public StatusPanel Build()
        {
            StatusPanel statusPanel = new StatusPanel(m_ControlConfiguration.m_Size);
            statusPanel.m_LabelStatus.Text = m_Status.Message;
            statusPanel.m_LabelLikes.Text = m_Status.LikedBy.Count.ToString();
            statusPanel.m_LabelDate.Text = m_Status.CreatedTime.ToString();
            statusPanel.m_pictureBoxLikes.Image = m_Image;
           
            return statusPanel;
        }
    }
}