﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseGrade> CourseGrades { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CourseGrade>(x => x.HasKey(p => new { p.CourseId, p.StudentId }));

            modelBuilder.Entity<CourseGrade>()
                .HasOne(u => u.Student)
                .WithMany(p => p.CourseGrades)
                .HasForeignKey(p => p.StudentId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<CourseGrade>()
                .HasOne(s => s.Course)
                .WithMany(p => p.CourseGrades)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserRole>(x => x.HasKey(p => new { p.StudentId, p.RoleName }));
            modelBuilder.Entity<UserRole>()
                .HasOne(u => u.Student)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(p => p.StudentId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserRole>()
                .HasOne(s => s.Role)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(s => s.RoleName)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
