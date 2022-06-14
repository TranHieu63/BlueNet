using BlueNet.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public class UserApiClient : IUserApiClient
    {
        public HttpClient _httpClient;

        public UserApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //GetUser
        public async Task<List<UserDto>> GetUsers(UserSearch userSearch)
        {
            string url = $"/api/User?userName={userSearch.UserName}&email={userSearch.Email}";
            var result = await _httpClient.GetFromJsonAsync<List<UserDto>>(url);
            return result;
        }

        //GetDetail
        public async Task<UserDto> GetUserDetail(string id)
        {
            string url = $"/api/User/{id}";
            var result = await _httpClient.GetFromJsonAsync<UserDto>(url);
            return result;
        }

        //Create
        public async Task<bool> CreateUser(UserCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync($"/api/User", request);
            return result.IsSuccessStatusCode;

        }

        //Update
        public async Task<bool> UpdateUser(Guid id, UserUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/User/{id}", request);
            return result.IsSuccessStatusCode;
        }

        //Delete
        public async Task<bool> DeleteUser(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/User/{id}");
            return result.IsSuccessStatusCode;
        }

        //GetByUserName
        public async Task<UserDto> GetUserByUserName(string userName)
        {
            string url = $"/api/User/UserName/{userName}";
            var result = await _httpClient.GetFromJsonAsync<UserDto>(url);
            return result;
        }
    }
}
