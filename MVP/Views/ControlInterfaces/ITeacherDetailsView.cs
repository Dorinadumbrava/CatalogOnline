using MVP.Views.ControlInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views.Views.Interfaces
{
    public interface ITeacherDetailsView : IControlView
    {
        void SetTeacherName(string teacherName);
        void SetTeacherSurname(string teacherName);
        void SetTeacherGrade(string teacherName);
    }
}
