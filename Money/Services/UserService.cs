using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Money.Data;

namespace Money.Services;

public class UserService:IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public UserService(UserManager<ApplicationUser> userManager, AuthenticationStateProvider authenticationStateProvider)
    {
        _userManager = userManager;
        _authenticationStateProvider = authenticationStateProvider;
    }

    private string UserId { get; set; } = string.Empty;
    public async Task<string> GetUserId()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if(user.Identity.IsAuthenticated)
        {
            var appUser = await _userManager.GetUserAsync(user);

            if(appUser != null)
            {
                UserId = appUser.Id;
            }
        }
        return UserId;
    }
}
