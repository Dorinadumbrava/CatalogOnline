using System.Collections.Generic;

namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentClassId { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Discipline> Disciplines { get; set; }
    }
}