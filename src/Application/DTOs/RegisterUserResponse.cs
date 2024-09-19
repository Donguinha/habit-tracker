using System.Text.Json.Serialization;

namespace HabitTracker.Application.DTOs;

public class RegisterUserResponse
{
    public bool Success { get; private set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Token { get; private set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? ExpirationDate { get; private set; }

    public List<string> Errors { get; set; } = [];

    public RegisterUserResponse(bool success)
    {
        Success = success;
    }
}
