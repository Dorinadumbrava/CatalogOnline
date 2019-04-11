using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class CatalogContext : DbContext, ICatalogContext
    {

        public CatalogContext()
        {
        }
        public CatalogContext(DbContextOptions<CatalogContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CatalogDB;Trusted_Connection=True;");
        }

        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<StudentMark> StudentMarks { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Student>()
           .HasOne<Course>(s => s.Course)
           .WithMany(g => g.Students)
           .HasForeignKey(s => s.StudentClassId);

            modelBuilder.Entity<CourseTeacher>().HasKey(sc => new { sc.CourseId, sc.TeacherId });

            modelBuilder.Entity<CourseTeacher>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(s => s.Teachers)
                .HasForeignKey(sc => sc.TeacherId);


            modelBuilder.Entity<CourseTeacher>()
                .HasOne<Teacher>(sc => sc.Teacher)
                .WithMany(s => s.Classes)
                .HasForeignKey(sc => sc.CourseId);
            
            modelBuilder.Entity<StudentDiscipline>().HasKey(sc => new { sc.StudentId, sc.DisciplineId });

            modelBuilder.Entity<StudentDiscipline>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.Disciplines)
                .HasForeignKey(sc => sc.StudentId);


            modelBuilder.Entity<StudentDiscipline>()
                .HasOne<Discipline>(sc => sc.Discipline)
                .WithMany(s => s.Students)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<TeacherDiscipline>().HasKey(sc => new { sc.TeacherId, sc.DisciplineId });

            modelBuilder.Entity<TeacherDiscipline>()
                .HasOne<Teacher>(sc => sc.Teacher)
                .WithMany(s => s.Disciplines)
                .HasForeignKey(sc => sc.TeacherId);


            modelBuilder.Entity<TeacherDiscipline>()
                .HasOne<Discipline>(sc => sc.Discipline)
                .WithMany(s => s.Teachers)
                .HasForeignKey(sc => sc.DisciplineId);

            modelBuilder.Entity<StudentTeacher>().HasKey(sc => new { sc.StudentId, sc.TeachersId });

            modelBuilder.Entity<StudentTeacher>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.Teachers)
                .HasForeignKey(sc => sc.StudentId);


            modelBuilder.Entity<StudentTeacher>()
                .HasOne<Teacher>(sc => sc.Teacher)
                .WithMany(s => s.Students)
                .HasForeignKey(sc => sc.TeachersId);

            modelBuilder.Entity<StudentMark>()
           .HasOne<Student>(s => s.Student)
           .WithMany(g => g.Marks)
           .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<StudentMark>()
           .HasOne<Teacher>(s => s.Teacher)
           .WithMany(g => g.Marks)
           .HasForeignKey(s => s.TeacherId);

            modelBuilder.Entity<StudentMark>()
           .HasOne<Discipline>(s => s.Discipline)
           .WithMany(g => g.Marks)
           .HasForeignKey(s => s.DisciplineId);


        }

        public void Migrate()
        {
            Database.Migrate();
        }
    }
}
