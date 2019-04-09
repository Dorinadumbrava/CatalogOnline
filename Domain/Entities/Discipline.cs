using System.Collections.Generic;

namespace Domain.Entities
{
    public class Discipline
    {
        public int DisciplineId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<StudentDiscipline> Students { get; set; }

        public virtual ICollection<TeacherDiscipline> Teachers { get; set; }

        public virtual ICollection<StudentMark> Marks { get; set; }

    }
}