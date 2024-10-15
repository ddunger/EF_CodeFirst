using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data
{
    public class EF_CodeFirstDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public EF_CodeFirstDbContext(DbContextOptions<EF_CodeFirstDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>() 
              .Property(s => s.Height)
              .HasColumnType("decimal");

            modelBuilder.Entity<Student>()
                .Property(s => s.Width)
                .HasColumnType("float");


            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, StudentName = "Marko Marić", DateOfBirth = new DateTime(1991, 2, 3), Height = 1.9m, Width = 50.35f },
                new Student() { StudentId = 2, StudentName = "Pero Perić", DateOfBirth = new DateTime(2001, 5, 6), Height = 1.7m, Width = 60.66f }
                 );

            modelBuilder.Entity<Grade>().HasData(
                new Grade() { GradeId = 1, GradeName = "Odličan", Section = "Matematika", StudentId = 1 },
                new Grade() { GradeId = 2, GradeName = "Vrlo dobar", Section = "Kemija", StudentId = 1 },
                new Grade() { GradeId = 3, GradeName = "Dobar", Section = "Fizika", StudentId = 2 },
                new Grade() { GradeId = 4, GradeName = "Dovoljan", Section = "Geografija", StudentId = 2 },
                new Grade() { GradeId = 5, GradeName = "Nedovoljan", Section = "Engleski", StudentId = 1 },
                new Grade() { GradeId = 6, GradeName = "Dobar", Section = "Hrvatski", StudentId = 2 },
                new Grade() { GradeId = 7, GradeName = "Odličan", Section = "Latinski", StudentId = 1 }
);

            base.OnModelCreating(modelBuilder);
        }
    }
}
