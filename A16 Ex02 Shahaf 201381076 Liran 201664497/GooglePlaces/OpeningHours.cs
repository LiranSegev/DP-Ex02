using Newtonsoft.Json;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class OpeningHours
    {
        [JsonProperty(PropertyName = "open_now")]
        public string isOpen { get; set; }

        [JsonProperty(PropertyName = "weekday_text")]
        public string[] weekDays { get; set; }
    }
}
