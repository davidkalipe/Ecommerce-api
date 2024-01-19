using Ecommerce.Application.Repository;
using Ecommerce.Core.Models;
using Ecommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly EcommerceDbContext _dbContext;

    public UserRepository(EcommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> SignUp(User user)
    {
        var existUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.PhoneNumber == user.PhoneNumber);
        if (existUser is not null)
            return false;
        var pwdHash = BCrypt.Net.BCrypt.HashPassword(user.Password);
        user.Password = pwdHash;
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> SignIn(string phoneNumber, string password)
    {
        var user = await _dbContext.Users.Where(u => u.PhoneNumber == phoneNumber).FirstOrDefaultAsync();
        if (user is null)
            return false;
        var checkingPwd = BCrypt.Net.BCrypt.Verify(password, user.Password);
        if (!checkingPwd)
            return false;
        return true;
    }
}