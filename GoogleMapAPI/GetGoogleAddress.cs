using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GoogleMapAPI.Model;
using Newtonsoft.Json;

namespace GoogleMapAPI
{
    public class GetGoogleAddress
    {
        public async static Task<GoogleModel> GoogleAddress(string address)
        {
            var googleApiUrl = ConfigurationManager.AppSettings["GoogleApiUrl"];

            using (var client = new HttpClient())
            {
                try
                {
                    var userAddress = address;
                    var url = string.Format(googleApiUrl + "{0}", userAddress);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(url);
                    if (!response.IsSuccessStatusCode) return null;
                    var result = await response.Content.ReadAsStringAsync();

                    //De-Serialize
                    var responses = JsonConvert.DeserializeObject<GoogleModel>(result);

                    return responses;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
              
            }
        }
    }
}
