using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Repository;
using Ecommerce.Core.Models;

namespace Ecommerce.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repo;

    public UserService(IUserRepository repo)
    {
        _repo = repo;
    }

    public async Task<bool> SignUp(User user)
    {
        await _repo.SignUp(user);
        return true;
    }

    public async Task<bool> SignIn(string phoneNumber, string password)
    {
        await _repo.SignIn(phoneNumber, password);
        return true;
    }
}