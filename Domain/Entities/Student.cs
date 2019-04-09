using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentClassId { get; set; }
        public virtual ICollection<StudentTeachers> Teachers { get; set; }
        public virtual ICollection<StudentDisciplines> Disciplines { get; set; }
    }
}