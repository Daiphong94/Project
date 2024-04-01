using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Exam> Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            modelBuilder.Entity<Question>()
                .HasOne(q => q.Competition)
                .WithMany(c => c.Questions)
                .HasForeignKey(q => q.CompetitionID)
                .OnDelete(DeleteBehavior.Cascade);

            

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Competition)
                .WithMany(c => c.Exams)
                .HasForeignKey(e => e.CompetitionID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Exams)
                .HasForeignKey(e => e.StudentID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(a => a.QuestionID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Student)
                .WithMany(s => s.Answers)
                .HasForeignKey(a => a.StudentID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentID);
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(200);
                entity.Property(e => e.StudentNumber).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Class).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Department).IsRequired().HasMaxLength(100);
                entity.Property(e => e.AdmissionDate).IsRequired().HasColumnType("datetime");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.FacultyID);
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(200);
                entity.Property(e => e.FacultyNumber).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Department).IsRequired().HasMaxLength(100);
                entity.Property(e => e.JoiningDate).IsRequired().HasColumnType("datetime");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.AdminID);
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(200);
                entity.Property(e => e.AdminNumber).IsRequired().HasMaxLength(50);
                
                entity.Property(e => e.JoiningDate).IsRequired().HasColumnType("datetime");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.HasKey(e => e.SurveyID);
                entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Description).IsRequired().HasColumnType("text");
                entity.Property(e => e.TargetRole).IsRequired();
                entity.Property(e => e.StartDate).IsRequired().HasColumnType("datetime");
                entity.Property(e => e.EndDate).IsRequired().HasColumnType("datetime");
            });

            modelBuilder.Entity<Response>(entity =>
            {
                entity.HasKey(e => e.ResponseID);
                entity.Property(e => e.Answers).IsRequired().HasColumnType("text");
                entity.Property(e => e.SubmissionDate).IsRequired().HasColumnType("datetime");
            });

            modelBuilder.Entity<FAQ>(entity =>
            {
                entity.HasKey(e => e.FAQID);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Question).IsRequired().HasColumnType("text");
                entity.Property(e => e.Answer).IsRequired().HasColumnType("text");
            });

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.HasKey(e => e.CompetitionID);
                entity.Property(e => e.CompetitionName).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Description).IsRequired().HasColumnType("text");
                entity.Property(e => e.StartDate).IsRequired().HasColumnType("datetime");
                entity.Property(e => e.EndDate).IsRequired().HasColumnType("datetime");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventID);
                entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Description).IsRequired().HasColumnType("text");
                entity.Property(e => e.Location).IsRequired().HasMaxLength(200);
                entity.Property(e => e.ParticipantCount).IsRequired();
                entity.Property(e => e.StartDate).IsRequired().HasColumnType("datetime");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.QuestionID);
                entity.Property(e => e.File).IsRequired(false).HasMaxLength(200);
                entity.Property(e => e.Writing).IsRequired(false).HasColumnType("text");
                
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => e.AnswerID);
                entity.Property(e => e.File).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Writing).IsRequired(false).HasColumnType("text");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.ExamID);
                entity.Property(e => e.Score).IsRequired();
                entity.Property(e => e.Rank).IsRequired();
            });
        }
    }
}
