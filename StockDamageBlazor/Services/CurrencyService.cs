using System.Net.Http.Json;
using StockDamageBlazor.Models;

namespace StockDamageBlazor.Services
{
    public class CurrencyService
    {
        private readonly HttpClient _http;

        public CurrencyService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Currency>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Currency>>("Currency") ?? new List<Currency>();
        }
    }
}
