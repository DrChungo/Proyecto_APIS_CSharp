using System.Text.Json;

namespace Functions
{
    public class GetJson
    {
        // Realiza una solicitud HTTP GET y deserializa la respuesta JSON en el tipo indicado.
        // @param url   Dirección URL desde donde se obtendrá el JSON.
        // @return      Objeto del tipo T deserializado. Devuelve null si ocurre un error.
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
