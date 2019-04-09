using System.Collections.Generic;

namespace Domain.Entities
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

    }
}