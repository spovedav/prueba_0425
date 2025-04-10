using CORE.CORs;
using CORE.Interfaces.Http;
using Newtonsoft.Json;
using System.Text.Json;

namespace HTTP.API.Service
{
    public class ApiInterna : IApiInterna
    {
        private HttpClient _httpClient;
        private string _urlBase = "https://localhost:7218/";
        public ApiInterna() {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(50);
        }

        public (List<ProductoSPResult>? lista, string? mensaje) GetAll()
        {
            string URL = _urlBase + "api/Producto/Get-All";
            var response = _httpClient.GetAsync(URL).GetAwaiter().GetResult();

            if (!response.IsSuccessStatusCode)
            {
                return (null, $"Error en la api {response.StatusCode}");
            }

            string jsonString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            return (JsonConvert.DeserializeObject<List<ProductoSPResult>>(jsonString), null);
        }
    }
}
