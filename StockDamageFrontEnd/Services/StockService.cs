using System.Net.Http.Json;
using StockDamageFrontEnd.Models;

namespace StockDamageFrontEnd.Services
{
    public class StockService
    {
        private readonly HttpClient _http;
        public StockService(HttpClient http) => _http = http;

        public async Task<List<Stock>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Stock>>("Stock") ?? new List<Stock>();
        }
    }
}
