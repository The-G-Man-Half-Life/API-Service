using API_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Service.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Vehicle> Vehicles {get; set;}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}