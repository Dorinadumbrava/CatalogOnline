using System.Collections.Generic;

namespace Domain.Entities
{
    public class Discipline
    {
        public int DisciplineId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StudentDisciplines> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }

    }
}