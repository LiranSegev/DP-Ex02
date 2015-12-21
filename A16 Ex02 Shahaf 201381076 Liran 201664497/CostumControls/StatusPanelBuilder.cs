using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            StatusPanel statusPanel = new StatusPanel(m_ControlConfiguration.Size);
            setControlConfiguration(statusPanel);
            statusPanel.m_LabelStatus.Text = m_Status.Message;
            statusPanel.m_LabelLikes.Text = m_Status.LikedBy.Count.ToString();
            statusPanel.m_LabelDate.Text = m_Status.CreatedTime.ToString();
            statusPanel.m_pictureBoxLikes.Image = m_Image;

            return statusPanel;
        }

        private void setControlConfiguration(StatusPanel i_StatusPanel)
        {
            PropertyInfo[] properties = typeof(ControlConfiguration).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                setProperty(i_StatusPanel, property);
            }
        }

        private void setProperty(StatusPanel i_StatusPanel, PropertyInfo property)
        {
            try
            {
                var value = property.GetValue(m_ControlConfiguration, null);
                typeof(StatusPanel).GetProperty(property.Name).SetValue(i_StatusPanel, value, null);
            }
            catch (Exception)
            {
                System.Console.WriteLine("Can't set proprty [{0}], setting default.", property.Name);
            }
        }
    }
}