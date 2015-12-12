using System.Collections.Generic;
using System;
using System.Net;
using System.Text;
using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Newtonsoft.Json;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class FbPlacePageID
    {
        [JsonProperty(PropertyName = "name")]
        public string m_Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string m_ID { get; set; }
    }
}
