using Domain.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.ApplicationDbContext
{
    public class DB:DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasIndex(u => u.Email)
                .IsUnique();
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AI_Compulsory_Configurations());
            modelBuilder.ApplyConfiguration(new AI_Electives_Configurations());
            modelBuilder.ApplyConfiguration(new CS_Compulsory_Configurations());
            modelBuilder.ApplyConfiguration(new CS_Electives_Configurations());
            modelBuilder.ApplyConfiguration(new F_Compulsory_Configurations());
            modelBuilder.ApplyConfiguration(new F_Elective_Configurations());
            modelBuilder.ApplyConfiguration(new IS_Compulsory_Configurations());
            modelBuilder.ApplyConfiguration(new IS_Electives_Configurations());
            modelBuilder.ApplyConfiguration(new IT_Compulsory_Configurations());
            modelBuilder.ApplyConfiguration(new IT_Electives_Configurations());
            modelBuilder.ApplyConfiguration(new G_Compulsory_Configurations());
            modelBuilder.ApplyConfiguration(new G_Elective_Configurations());
            modelBuilder.ApplyConfiguration(new Subjects_Configurations());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
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
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<ChatHistory> ChatHistories { get; set; }
        public DbSet<ChatMessagePDF> chatMessagePDFs { get; set; }
        public DbSet<FilePDF> Files { get; set; }
        public DbSet<ChatHistoryPDF> ChatHistoriesPDF {get; set;}
    }
}
