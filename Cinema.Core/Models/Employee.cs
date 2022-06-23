using static Cinema.Core.Models.Enum;

namespace Cinema.Core.Models
{
    public class Employee : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public float Height { get; set; }
        public short Weight { get; set; }
        public Gender Gender { get; set; }
        public string Photo { get; set; }    
        public List<EmployeeRole> Roles { get; set; }   
    }
}
