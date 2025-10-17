using System.Net.Http.Json;
using StockDamageFrontEnd.Models;

namespace StockDamageFrontEnd.Services
{
    public class StockDamageService
    {
        private readonly HttpClient _http;
        public StockDamageService(HttpClient http) => _http = http;

        public async Task<HttpResponseMessage> SaveAsync(List<StockDamageDto> items)
        {
            return await _http.PostAsJsonAsync("StockDamage", items);
        }

        public async Task<List<StockDamageDto>> GetAllAsync()
        {
            // optional: map from StockDamage server entities if endpoint returns them
            var list = await _http.GetFromJsonAsync<List<StockDamageDto>>("StockDamage");
            return list ?? new List<StockDamageDto>();
        }
    }
}
