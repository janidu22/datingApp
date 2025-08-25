using System;
using DatingAppAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{

    public DbSet<AppUser> Users { get; set; }
}
