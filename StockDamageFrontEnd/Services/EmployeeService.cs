using System.Net.Http.Json;
using StockDamageFrontEnd.Models;

namespace StockDamageFrontEnd.Services
{
    public class EmployeeService
    {
        private readonly HttpClient _http;
        public EmployeeService(HttpClient http) => _http = http;

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Employee>>("Employee") ?? new List<Employee>();
        }
    }
}
