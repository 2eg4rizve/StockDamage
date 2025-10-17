using System.Net.Http.Json;
using StockDamageFrontEnd.Models;

namespace StockDamageFrontEnd.Services
{
    public class SubItemService
    {
        private readonly HttpClient _http;
        public SubItemService(HttpClient http) => _http = http;

        public async Task<List<SubItemCode>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<SubItemCode>>("SubItemCode") ?? new List<SubItemCode>();
        }

        public async Task<SubItemCode?> GetByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<SubItemCode>($"SubItemCode/{id}");
        }
    }
}
