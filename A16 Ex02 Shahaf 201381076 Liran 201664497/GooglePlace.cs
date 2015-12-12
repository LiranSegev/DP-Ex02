using Newtonsoft.Json;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class GooglePlace
    {
        [JsonProperty(PropertyName = "name")]
        public string m_Name { get; set; }

        [JsonProperty(PropertyName = "vicinity")]
        public string m_Vicinity { get; set; }

        [JsonProperty(PropertyName = "opening_hours")]
        public OpeningHours m_OpeningHours { get; set; }
    }
}
