using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Repositories.Interfaces
{
    public interface ITeacherRepository
    {
        Task<TeacherLogin> Get(string username, string password);
    }
}