using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Degree { get; set; }

        public ICollection<TeacherDiscipline> Disciplines { get; set; }

        public ICollection<StudentTeacher> Students { get; set; }

        public ICollection<CourseTeacher> Classes { get; set; }

        public virtual ICollection<StudentMark> Marks { get; set; }

    }
}
