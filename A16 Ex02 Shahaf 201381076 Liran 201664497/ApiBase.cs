using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public abstract class ApiBase<T>
    {
        public string m_Host { get; set; }

        public string m_Key { get; set; }

        public abstract T get(String i_KeyWord);
    }
}
