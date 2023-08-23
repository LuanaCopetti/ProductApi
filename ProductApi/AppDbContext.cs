    using Microsoft.EntityFrameworkCore;
    using ProductApi.NovaPasta;
    using System.Collections.Generic;

    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }

