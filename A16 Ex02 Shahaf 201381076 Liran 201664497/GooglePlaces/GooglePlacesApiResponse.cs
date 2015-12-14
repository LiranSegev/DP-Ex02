using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public class GooglePlacesApiResponse
    {
        [JsonProperty(PropertyName = "results")]
        public List<GooglePlace> m_Places { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string m_ResponseStatus { get; set; }

        public void ChangeEncodingResponseToUTF8()
        {
            foreach (GooglePlace googlePlace in m_Places)
            {
                googlePlace.m_Name = convertToUTF8(googlePlace.m_Name);
                googlePlace.m_Vicinity = convertToUTF8(googlePlace.m_Vicinity);
            }
        }

        private string convertToUTF8(string i_StringToConvert)
        {
            Encoding encoding = Encoding.GetEncoding("utf-8");

            return encoding.GetString(Encoding.Default.GetBytes(i_StringToConvert));
        }
    }
}
