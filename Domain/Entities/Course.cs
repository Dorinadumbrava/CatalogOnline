using System.Collections.Generic;

namespace Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }

        public string ClassName { get; set; }

        public virtual ICollection<CourseTeacher> Teachers { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}