using System.Net.Http.Json;
using StockDamageBlazor.Models;

namespace StockDamageBlazor.Services
{
    public class SubItemService
    {
        private readonly HttpClient _http;

        public SubItemService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<SubItemCode>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<SubItemCode>>("SubItemCode") ?? new List<SubItemCode>();
        }
    }
}
