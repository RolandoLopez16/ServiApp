using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ServiApp.Services // Usa el espacio de nombres adecuado
{
    public class ConductoresService
    {
        private readonly HttpClient _httpClient;

        public ConductoresService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

       public async Task<List<Conductor>> GetConductoresAsync()
{
        return await _httpClient.GetFromJsonAsync<List<Conductor>>("Conductores");
}

       
    }
}
