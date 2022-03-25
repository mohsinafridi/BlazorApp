using BlazorApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp.Services.AppContext
{
    public class BlazorAppDbContext : DbContext
    {
        public BlazorAppDbContext(DbContextOptions<BlazorAppDbContext> options) : base(options)
        {

        }

        public DbSet<Cake> Cake { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
