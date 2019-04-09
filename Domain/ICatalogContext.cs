using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICatalogContext
    {
        DbSet<Discipline> Disciplines { get;}
        DbSet<StudentMark> StudentMarks { get;}
        DbSet<StudentClass> StudentClasses { get;}
        DbSet<Student> Students { get;}
        DbSet<Teacher> Teachers { get; }


        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void AddRange(IEnumerable<object> entities);
        void Migrate();
    }
}
