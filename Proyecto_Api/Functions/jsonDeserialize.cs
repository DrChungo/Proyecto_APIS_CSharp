using System;
using System.Text.Json;
using Models;

namespace Functions
{
    public class GetJson
    {

        public static async Task<AnimeResponse?> GetJsonAsync(string url)
        {
            try
            {

           
                  using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string contentString = await response.Content.ReadAsStringAsync();
                    var content = JsonSerializer.Deserialize<AnimeResponse>(contentString);

                    return content;

                }
                   
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
