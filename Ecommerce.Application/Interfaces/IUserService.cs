using Ecommerce.Core.Models;

namespace Ecommerce.Application.Interfaces;

public interface IUserService
{
    Task<bool> SignUp(User user);
    Task<bool> SignIn(string phoneNumber, string password);
}