using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Context;

public class AppDbContext:DbContext
{
    DbSet<User> Users { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}