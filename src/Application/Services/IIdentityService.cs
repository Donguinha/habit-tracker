using System;
using HabitTracker.Application.DTOs;

namespace HabitTracker.Application.Services;

public interface IIdentityService
{
    Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request);
    // Task<LoginResponse> Login(LoginRequest request);
}
