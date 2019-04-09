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
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Degree { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public List<Student> Students { get; set; }
        public List<StudentClass> Classes { get; set; }

    }
}
