using MVP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Services.Services.Interfaces
{
    public interface IStupidTeacherService
    {
        TeacherDetailsModel GetMockTeacherDetails(string username);
    }
}
