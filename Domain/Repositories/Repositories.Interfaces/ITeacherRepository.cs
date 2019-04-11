using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;

namespace Domain.Repositories.Interfaces
{
    public interface ITeacherRepository
    {
        Task<TeacherLogin> GetCredentials(string username, string password);
        Task<Teacher> Get(string username);
    }
}