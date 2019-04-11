using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICatalogContext
    {
        DbSet<Discipline> Disciplines { get; set; }
        DbSet<StudentMark> StudentMarks { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Student> Students { get; set; } 
        DbSet<Teacher> Teachers { get; set; }


        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void AddRange(IEnumerable<object> entities);
        void Migrate();
    }
}
