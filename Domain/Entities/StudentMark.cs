using System;

namespace Domain.Entities
{
    public class StudentMark
    {
        public int Id { get; set; }

        public byte MarkValue { get; set; }

        public DateTime Date { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}