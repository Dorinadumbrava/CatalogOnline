using System.Collections.Generic;

namespace Domain.Entities
{
    public class StudentClass
    {
        public int Id { get; set; }

        public string ClassName { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}