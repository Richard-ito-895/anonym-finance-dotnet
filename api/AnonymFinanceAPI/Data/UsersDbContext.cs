using Microsoft.EntityFrameworkCore;
using AnonymFinance.Models;

namespace AnonymFinanceAPI.Data;

public class UsersDbContext : DbContext
{
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
}
