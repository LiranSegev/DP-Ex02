using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497.CostumControls
{
    public interface IControlBuilder<T>
    {
         T AddConfiguration(ControlConfiguration i_ControlConfiguration);
    }
}
