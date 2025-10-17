using System.Net.Http.Json;
using StockDamageBlazor.Models;

namespace StockDamageBlazor.Services
{
    public class StockDamageService
    {
        private readonly HttpClient _http;

        public StockDamageService(HttpClient http)
        {
            _http = http;
        }

        public async Task SaveStockDamageAsync(List<StockDamageDto> items)
        {
            await _http.PostAsJsonAsync("StockDamage", items);
        }
    }
}
