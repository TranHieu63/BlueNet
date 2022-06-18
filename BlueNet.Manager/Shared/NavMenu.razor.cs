using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlueNet.Manager.Shared
{
    public partial class NavMenu
    {
        [Inject] private ILocalStorageService _localStorage { get; set; }

        private bool collapseNavMenu = true;

        private string _roleName;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        protected async override Task OnInitializedAsync()
        {
            _roleName = await _localStorage.GetItemAsync<string>("UserRole");

        }
    }
}
