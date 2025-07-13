namespace SampleConsoleApp.Data;

using Microsoft.EntityFrameworkCore;
using SampleConsoleApp.Models;
public class AppDbContext:DbContext
{
    public DbSet<Dev> Devs => Set<Dev>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
    
}