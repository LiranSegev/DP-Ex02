using System;
using System.Net;
using Newtonsoft.Json;

namespace A16_Ex01_Shahaf_201381076_Liran_201664497
{
    public static class GooglePlaceApiWrapper
    {
        private static string r_GoogleApiHost = @"https://maps.googleapis.com/maps/api/place/nearbysearch/json?";
        private static string r_GoogleApiKey = "AIzaSyBcEF9Ykwlh_trZKeCbO5FHsPi7Z-LOri8";

        public static GooglePlacesApiResponse GetPlaces(double? i_Latitude, double? i_Logtitude, double i_Radius, string i_keyword)
        {
            string urlRequest = r_GoogleApiHost + string.Format("key={0}&location={1},{2}&radius={3}&keyword={4}", r_GoogleApiKey, i_Latitude, i_Logtitude, i_Radius.ToString(), i_keyword.Replace(" ", "+"));
            string jsonResponse = new WebClient().DownloadString(urlRequest);

            GooglePlacesApiResponse apiResponse = JsonConvert.DeserializeObject<GooglePlacesApiResponse>(jsonResponse);

            return apiResponse;
        }
    }
}
