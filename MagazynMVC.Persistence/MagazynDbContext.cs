using MagazynMVC.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace MagazynMVC.Persistence
{
    public class MagazynDbContext : DbContext
    {
        public MagazynDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarBrand> CarBrand { get; set; }
        public DbSet<Oil> Oil { get; set; }
        public DbSet<Filter> Filter { get; set; }
        public DbSet<Suspension> Suspension { get; set; }
    }
}