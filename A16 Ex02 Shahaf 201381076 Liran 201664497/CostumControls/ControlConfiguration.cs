using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497.CostumControls
{
    public class ControlConfiguration
    {
        public Font Font { get; set; }

        public Color BackColor { get; set; }
        
        public Size Size { get; set; }

        public ControlConfiguration()
        {
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)177);
            BackColor = Color.FromArgb(75, Color.White);
            Size = Size.Empty;
        }
    }
}
