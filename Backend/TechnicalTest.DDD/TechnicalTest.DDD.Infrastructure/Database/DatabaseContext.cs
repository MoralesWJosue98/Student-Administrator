using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.Entities;
using TechnicalTest.DDD.Domain.ValueObjects;

namespace TechnicalTest.DDD.Infrastructure.Database
{
    public class DatabaseContext :  DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PermissionEnitityStudentConfig());
            modelBuilder.ConfigureStudent();
        }
    }
    public static class ModelBuilderExtensions
    {
        public static void ConfigureStudent(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Student>()
                .Property(s => s.Name)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .HasConversion(name => name.ToString(), nameString => StudentName.For(nameString));

            modelBuilder
                .Entity<Student>()
                .Property(s => s.LastName)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .HasConversion(lastName => lastName.ToString(), lastNameString => StudentLastName.For(lastNameString));

            modelBuilder
                .Entity<Student>()
                .Property(s => s.Career)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .HasConversion(career => career.ToString(), careerString => StudentCareer.For(careerString));

            modelBuilder
                .Entity<Student>()
                .Property(s => s.AdmissionDate)
                .HasColumnType("date")
                .HasConversion(date => DateTime.Parse(date.ToString()), dateDate => StudentAdmissionDate.For(dateDate));


        }
    }

}
