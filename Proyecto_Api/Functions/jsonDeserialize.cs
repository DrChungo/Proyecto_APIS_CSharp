using System.Text.Json;


namespace Functions
{
    public class GetJson
    {

        public static async Task<T?> GetJsonAsync<T>(string url) where T : class
        {
            try
            {
                  using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string contentString = await response.Content.ReadAsStringAsync();
                    var content = JsonSerializer.Deserialize<T>(contentString);

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