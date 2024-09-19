using System;
using System.ComponentModel.DataAnnotations;

namespace HabitTracker.Application.DTOs;

public class RegisterUserRequest
{
    [Required(ErrorMessage = "Required information")]
    [EmailAddress(ErrorMessage = "Invalid information")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password required")]
    [StringLength(50, MinimumLength = 8, ErrorMessage = "Invalid password")]
    public string Password { get; set; }

    [Compare(nameof(Password), ErrorMessage = "Passwords do not match!")]
    public string PasswordConfirmation { get; set; }
}
