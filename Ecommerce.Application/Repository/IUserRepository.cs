using Ecommerce.Core.Models;

namespace Ecommerce.Application.Repository;

public interface IUserRepository
{
    Task<bool> SignUp(User user);
    Task<bool> SignIn(string phoneNumber, string password);
}