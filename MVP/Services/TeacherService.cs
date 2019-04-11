using Domain.DTO;
using Domain.Entities;
using Domain.Repositories.Interfaces;
using MVP.Services.Services.Interfaces;
using MVP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public async Task<Teacher> GetTeacherDetails(string username)
        {
            var teacherDetails = await _teacherRepository.Get(username);
            if (teacherDetails == null)
                throw new ArgumentException(nameof(username));
            else return teacherDetails;
        }
    }
}
