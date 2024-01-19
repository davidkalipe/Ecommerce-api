using Ecommerce.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Data;

public class EcommerceDbContext : DbContext
{
    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options){}

    public DbSet<User> Users { get; set; }
}