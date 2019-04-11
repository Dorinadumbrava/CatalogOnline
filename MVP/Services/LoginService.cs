using MVP.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories.Interfaces;

namespace MVP.Services
{
    public class LoginService : ILoginService
    {
        private readonly ITeacherRepository _teacherRepository;

        public LoginService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public async Task<bool> Login(string username, string password)
        {
            var teacherCredentials = await _teacherRepository.Get(username, password);
            if (teacherCredentials == null)
            {
                return false;
            }

            return true;
        }
    }
}