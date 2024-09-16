using System;

namespace HabitTracker.src.Domain;

public class User
{
    public Guid Id { get; init; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public DateTime CreatedAt { get; init; }

    public User(Guid id, string name, string email, DateTime createdAt)
    {
        Id = id;
        Name = name;
        Email = email;
        CreatedAt = createdAt;
    }
}
