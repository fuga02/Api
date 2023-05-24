using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Context;

public class AppDbContext:DbContext
{
    public DbSet<User> Users { get; set; }
    private readonly IConfiguration builder;

    public AppDbContext(IConfiguration builder)
    {
        this.builder = builder;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(builder.GetValue<string>("DataBase:ConnectionStrings"));
    }
}