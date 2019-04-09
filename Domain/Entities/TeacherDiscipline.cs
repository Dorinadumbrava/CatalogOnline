namespace Domain.Entities
{
    public class TeacherDiscipline
    {
        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}