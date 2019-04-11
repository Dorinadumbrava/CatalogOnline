using Domain.DTO;
using Domain.Entities;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DbSet<Teacher> _teachers;
        private ICatalogContext _context;
        public TeacherRepository(ICatalogContext context)
        {
            _context = context;
            _teachers = context.Teachers;
        }

        public async Task<Teacher> Get(string username)
        {
            return await _teachers.Where(t => t.Username == username)
                .FirstOrDefaultAsync();
        }

        public async Task<TeacherLogin> GetCredentials(string username, string password)
        {
            var teacher = await _teachers.Where(t => t.Username == username & t.Password == password)
                .Select(t => new TeacherLogin
                {
                    Username = t.Username,
                    Password = t.Password
                })
                .FirstOrDefaultAsync();

            return teacher;
        }
    }
}