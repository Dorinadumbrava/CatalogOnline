using System.Collections.Generic;

namespace Domain.Entities
{
    public class StudentClass
    {
        public int Id { get; set; }

        public string ClassName { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }
    }
}