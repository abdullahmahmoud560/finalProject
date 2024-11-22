using finalProject.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject.Data
{
    public class DB :DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options) { }
        public DbSet<Register> registers { get; set; }
        public DbSet<General_Compulsory> general_Compulsories { get; set; }
        public DbSet<General_Electives> general_Electives { get; set; }
        public DbSet<Faculty_Compulsory> faculty_Compulsories { get; set; }
        public DbSet<Faculty_Electives> faculty_Electives { get; set; }
        public DbSet<CS_Compulsory> cS_Compulsories { get; set; }
        public DbSet<CS_Electives> cS_Electives { get; set; }
        public DbSet<IS_Compulsory> iS_Compulsories { get; set; }
        public DbSet<IS_Electives> iS_Electives { get; set; }
        public DbSet<IT_Compulsory> iT_Compulsories { get; set; }
        public DbSet<IT_Electives> iT_Electives { get; set; }
        public DbSet<AI_Compulsory> aI_Compulsories { get; set; }
        public DbSet<AI_Electives> aI_Electives { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>()
                .HasIndex(u => u.Email)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<General_Compulsory>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<General_Compulsory>().HasNoKey();

              modelBuilder.Entity<General_Electives>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<General_Electives>().HasNoKey();

             modelBuilder.Entity<Faculty_Compulsory>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Faculty_Compulsory>().HasNoKey();

             modelBuilder.Entity<Faculty_Electives>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Faculty_Electives>().HasNoKey();

             modelBuilder.Entity<CS_Compulsory>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CS_Compulsory>().HasNoKey();

             modelBuilder.Entity<CS_Electives>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CS_Electives>().HasNoKey();

             modelBuilder.Entity<IS_Compulsory>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IS_Compulsory>().HasNoKey();

             modelBuilder.Entity<IS_Electives>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IS_Electives>().HasNoKey();

             modelBuilder.Entity<IT_Compulsory>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IT_Compulsory>().HasNoKey();

             modelBuilder.Entity<IT_Electives>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IT_Electives>().HasNoKey();


           modelBuilder.Entity<AI_Compulsory>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AI_Compulsory>().HasNoKey();

             modelBuilder.Entity<AI_Electives>()
                .HasIndex(u => u.code)
                .IsUnique(); 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AI_Electives>().HasNoKey();
        }

    }
}
