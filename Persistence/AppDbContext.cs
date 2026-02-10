using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<Student> Students { get; set; }
    public required DbSet<Teacher> Teachers { get; set; }
}
