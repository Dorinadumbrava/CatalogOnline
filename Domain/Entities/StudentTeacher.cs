using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StudentTeacher
    {
        public int TeachersId { get; set; }
        public Teacher Teacher { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
