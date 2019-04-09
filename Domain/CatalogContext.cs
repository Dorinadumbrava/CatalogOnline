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
            optionsBuilder.UseSqlServer(@"Server=.\\SQLEXPRESS;Database=CatalogDB;Trusted_Connection=True;");
        }

        public virtual DbSet<Discipline> Disciplines { get; }
        public virtual DbSet<StudentMark> StudentMarks { get; }
        public virtual DbSet<StudentClass> StudentClasses { get; }
        public virtual DbSet<Student> Students { get; }
        public virtual DbSet<Teacher> Teachers { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
              .HasMany(d=> d.Disciplines)
              .WithMany(s => s.)
              .Map(ca =>
              {
                  ca.MapLeftKey("BookId");
                  ca.MapRightKey("GenresId");
                  ca.ToTable("BookGenres");
              });
        }

        public void Migrate()
        {
            Database.Migrate();
        }
    }
}
