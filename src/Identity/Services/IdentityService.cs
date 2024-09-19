using HabitTracker.Application.DTOs;
using HabitTracker.Application.Services;
using Microsoft.AspNetCore.Identity;

namespace HabitTracker.Identity.Services;

public class IdentityService : IIdentityService
{
    private readonly IIdentityService _identityService;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public IdentityService(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request)
    {
        var identity = new IdentityUser
        {
            UserName = request.Email,
            Email = request.Email,
            EmailConfirmed = true,
        };

        var createResult = await _userManager.CreateAsync(identity);

        if (createResult.Succeeded)
            await _userManager.SetLockoutEnabledAsync(identity, true);

        var response = new RegisterUserResponse(createResult.Succeeded);

        if (!createResult.Succeeded && createResult.Errors.Any())
            response.Errors.AddRange(createResult.Errors.Select(x => x.Code + ";" + x.Description));

        return response;
    }
}
