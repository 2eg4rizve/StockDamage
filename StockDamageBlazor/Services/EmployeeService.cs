using System.Net.Http.Json;
using StockDamageBlazor.Models;

namespace StockDamageBlazor.Services
{
    public class EmployeeService
    {
        private readonly HttpClient _http;

        public EmployeeService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Employee>>("Employee") ?? new List<Employee>();
        }
    }
}
