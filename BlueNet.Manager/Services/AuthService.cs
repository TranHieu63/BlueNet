using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using BlueNet.Models;
using BlueNet.Manager;
using BlueNet.Manager.Services;

namespace BlueNet.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/login", loginRequest);
            
            //lấy string
            var content = await result.Content.ReadAsStringAsync();
            //Chuyen Json
            var loginResponse = JsonSerializer.Deserialize<LoginResponse>(content,
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

            if (!result.IsSuccessStatusCode)
            {
                return loginResponse;
            }

            await _localStorage.SetItemAsync("authToken", loginResponse.Token);
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginRequest.UserName);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", loginResponse.Token);

            await GetCurrentLoginUser();

            return loginResponse;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            await _localStorage.RemoveItemAsync("UserId");
            await _localStorage.RemoveItemAsync("UserRole");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<UserDto> GetCurrentLoginUser()
        {
            UserDto userDto = null;

            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();

            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                string url = $"/api/User/UserName/{user.Identity.Name}";
                //lấy thông tin người dùng đang đăng nhập theo userName 
                userDto = await _httpClient.GetFromJsonAsync<UserDto>(url);
                await _localStorage.SetItemAsync("UserId", userDto.Id);
                //await _localStorage.SetItemAsync("UserName", userDto.UserName);
                await _localStorage.SetItemAsync("UserRole", userDto.RoleName);
            }

            return userDto;
        }

    }
}
