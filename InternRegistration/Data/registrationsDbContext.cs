
using Microsoft.EntityFrameworkCore;

using InternRegistration.Models;


public class registrationsDbContext : DbContext
{
    public registrationsDbContext(DbContextOptions<registrationsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Intern> Interns { get; set; }
    public DbSet<User> Users { get; set; }
}


