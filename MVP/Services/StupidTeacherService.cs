using MVP.Services.Services.Interfaces;
using MVP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Services
{
    public class StupidTeacherService : IStupidTeacherService
    {
        public TeacherDetailsModel GetMockTeacherDetails(string username)
        {
            return new TeacherDetailsModel() { Name = "Prof", Surname = "Test", Grade = "Superior" };
        }
    }
}
