using finalProject.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject.Data
{
    public class DB: IdentityDbContext
    {
        public DB(DbContextOptions<DB> options) : base(options) { }
        public DbSet<Register> registers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>()
                .HasIndex(u => u.Email)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
        }

    }
}
