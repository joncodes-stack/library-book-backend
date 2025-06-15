using Microsoft.EntityFrameworkCore;
using PersonalLibrary.Domain.Entities;

namespace PersonalLibrary.EF.Context
{
    public class PersonalLibraryContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public PersonalLibraryContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public PersonalLibraryContext(DbContextOptions<PersonalLibraryContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
