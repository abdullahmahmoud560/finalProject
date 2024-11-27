using finalProject.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject.Data
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options) { }
        public DbSet<Student> students { get; set; }
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
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasIndex(u => u.Email)
                .IsUnique();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentSubject>()
            .HasOne(ss => ss.Student)
            .WithMany(s => s.StudentSubjects)
            .HasForeignKey(ss => ss.StudentId);

            modelBuilder.Entity<StudentSubject>()
                .HasOne(ss => ss.Subject)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.SubjectCode);

            modelBuilder.Entity<StudentSubject>()
       .HasKey(ss => new { ss.StudentId, ss.SubjectCode });

        }

    }
}
