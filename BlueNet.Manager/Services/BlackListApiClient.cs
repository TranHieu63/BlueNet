using BlueNet.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public class BlackListApiClient : IBlackListApiClient
    {
        public HttpClient _httpClient;

        public BlackListApiClient(HttpClient httpClient)
        {
           _httpClient = httpClient;
        }


        //public async Task<List<BlackListDto>> GetBlackList()
        //{
        //    string url = $"/api/BlackList";
        //    var result = await _httpClient.GetFromJsonAsync<List<BlackListDto>>(url);
        //    return result;
        //}

        public async Task<List<BlackListDto>> GetBlackList(BlackListSearch blackListSearch)
        {
            string url = $"/api/BlackList?url={blackListSearch.Url}&userId={blackListSearch.UserId}";
            var result = await _httpClient.GetFromJsonAsync<List<BlackListDto>>(url);
            return result;
        }

        //GetDetail
        public async Task<BlackListDto> GetBlackListDetail(string id)
        {
            string url = $"/api/BlackList/{id}";
            var result = await _httpClient.GetFromJsonAsync<BlackListDto>(url);
            return result;
        }

        //Create
        public async Task<bool> CreateBlackList(BlackListCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/BlackList", request);
            return result.IsSuccessStatusCode;

        }

        //Update
        public async Task<bool> UpdateBlackList(Guid id, BlackListUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/BlackList/{id}", request);
            return result.IsSuccessStatusCode;
        }

        //Delete
        public async Task<bool> DeleteBlackList(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/BlackList/{id}");
            return result.IsSuccessStatusCode;
        }

        //GetMyBlackList
        public async Task<List<BlackListDto>> GetMyBlackList(BlackListSearch blackListSearch)
        {
            
            string url = $"/api/BlackList/me?url={blackListSearch.Url}&userId={blackListSearch.UserId}";
            var result = await _httpClient.GetFromJsonAsync<List<BlackListDto>>(url);
            return result;
            
        }
    }
}
