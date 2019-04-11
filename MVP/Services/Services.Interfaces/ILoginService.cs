using System.Threading.Tasks;

namespace MVP.Services.Services.Interfaces
{
    public interface ILoginService
    {
        Task<bool> Login(string username, string password);
    }
}
