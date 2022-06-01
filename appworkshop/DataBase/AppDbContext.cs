using appworkshop.Features.Users;
using Microsoft.EntityFrameworkCore;

namespace appworkshop.DataBase;

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions options) : base(options) {} //constructorul primeste optiunile de baza
    public DbSet<User> Users { get; set; }
}