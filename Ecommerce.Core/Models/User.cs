﻿namespace Ecommerce.Core.Models;

public class User
{
    public Guid UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string ProfileImage { get; set; } = string.Empty;
    public bool IsSeller { get; set; } = false;

    public User()
    {
        UserId = Guid.NewGuid();
    }
}