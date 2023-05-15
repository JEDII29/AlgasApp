using AlgasApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace AlgasApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Errand> Errands { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
