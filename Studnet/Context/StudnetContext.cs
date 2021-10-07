using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Studnet.Models;

#nullable disable

namespace Studnet.Context
{
    public partial class StudnetContext : DbContext
    {
        public StudnetContext(DbContextOptions<StudnetContext> options): base(options) { }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<Discussions> Discussions { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FileSubject> FileSubjects { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Name=ConnectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "C");

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Fileid });

                entity.HasOne(d => d.File)
                    .WithMany(p => p.Complaints)
                    .HasForeignKey(d => d.Fileid);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Complaints)
                    .HasForeignKey(d => d.Userid);
            });

            modelBuilder.Entity<Discussions>(entity =>
            {
                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Discussions)
                    .HasForeignKey(d => d.Facultyid);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Discussions)
                    .HasForeignKey(d => d.Groupid);

                entity.HasOne(d => d.University)
                    .WithMany(p => p.Discussions)
                    .HasForeignKey(d => d.Universityid);
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasOne(d => d.University)
                    .WithMany(p => p.Faculties)
                    .HasForeignKey(d => d.Universityid);
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.Userid);
            });

            modelBuilder.Entity<FileSubject>(entity =>
            {
                entity.HasKey(e => new { e.Fileid, e.Subjectid })
                    .HasName("file_subject_pkey");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.FileSubjects)
                    .HasForeignKey(d => d.Fileid);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.FileSubjects)
                    .HasForeignKey(d => d.Subjectid);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.Facultyid);
            });

            modelBuilder.Entity<Like>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Fileid })
                    .HasName("Like_pkey");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.Fileid);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.Userid);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasOne(d => d.From)
                    .WithMany(p => p.MessageFrom)
                    .HasForeignKey(d => d.FromId);

                entity.HasOne(d => d.To)
                    .WithMany(p => p.MessageTo)
                    .HasForeignKey(d => d.ToId);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasOne(d => d.Discussions)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.Discusionid);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.Userid);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasOne(d => d.Discussions)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.Discusionid);
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.HasOne(d => d.City)
                    .WithMany(p => p.Universities)
                    .HasForeignKey(d => d.CityId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Login).IsUnique();

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Facultyid);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Groupid);

                entity.HasOne(d => d.University)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Universityid);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
