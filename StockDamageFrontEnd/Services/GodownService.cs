using System.Net.Http.Json;
using StockDamageFrontEnd.Models;

namespace StockDamageFrontEnd.Services
{
    public class GodownService
    {
        private readonly HttpClient _http;
        public GodownService(HttpClient http) => _http = http;

        public async Task<List<Godown>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Godown>>("Godown") ?? new List<Godown>();
        }
    }
}
