using Microsoft.EntityFrameworkCore;
using ProductosAPI.Models;
using System;

namespace ProductosAPI.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
