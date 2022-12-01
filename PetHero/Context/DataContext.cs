using Microsoft.EntityFrameworkCore;
using PetHero.Mappings;
using PetHero.Models;

namespace PetHero.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PetMap());
        }
        public DbSet<Pet> Pets { get; set; }
    }
}
