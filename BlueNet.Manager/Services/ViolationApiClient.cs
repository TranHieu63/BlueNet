using BlueNet.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public class ViolationApiClient : IViolationApiClient
    {
        public HttpClient _httpClient;

        public ViolationApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Get Violation
        public async Task<List<ViolationParameter>> GetViolations()
        {
            string url = $"/api/Violation";
            var result = await _httpClient.GetFromJsonAsync<List<ViolationParameter>>(url);
            return result;
        }
    }
}
