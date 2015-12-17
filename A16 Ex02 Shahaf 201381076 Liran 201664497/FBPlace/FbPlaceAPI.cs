using System;
using System.Text;
using System.Net;
using System.Collections.Generic;
using FacebookWrapper;
using Newtonsoft.Json;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public static class FbPlaceAPI
    {
        private static string r_GraphFacebookSearchHost = @"https://graph.facebook.com/search?";

        public static FbPlacePageID getPlacePage(string i_KeyWord, LoginResult i_LoginResult)
        {
            string urlRequest = r_GraphFacebookSearchHost + string.Format("limit=1&type=place&q={0}&access_token={1}", i_KeyWord.Replace(" ", "+"), i_LoginResult.AccessToken);
            string jsonResponse = new WebClient().DownloadString(urlRequest);
            dynamic apiResponse = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
            FbPlacePageID placePageID = JsonConvert.DeserializeObject<FbPlacePageID>(apiResponse.data[0].ToString());

            return placePageID;
        }
    }
}
