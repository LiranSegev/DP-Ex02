using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497.CostumControls
{
    public class ControlConfiguration
    {
        public Font m_Font { get; set; }

        public Color m_BackColor { get; set; }
        
        public Size m_Size { get; set; }

        public ControlConfiguration()
        {
            m_Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)177);
            m_BackColor = Color.Blue;
            m_Size = Size.Empty;
        }
    }
}
