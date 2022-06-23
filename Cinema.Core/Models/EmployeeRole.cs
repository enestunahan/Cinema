
namespace Cinema.Core.Models
{
    public class EmployeeRole : BaseEntity<ushort>
    {
        public string Name { get;set; }
        public List<Movie> Movies { get; set; } 
        public List<Employee> Employees { get; set; }   
    }
}
