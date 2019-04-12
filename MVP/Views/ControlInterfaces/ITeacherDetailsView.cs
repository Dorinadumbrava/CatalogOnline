using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views.ControlInterfaces
{
    public interface ITeacherDetailsView: IControlView
    {
        string TeacherName { get; set; }
        string TeacherSurname { get; set; }
        string TeacherGrade { get; set; }
    }
}
