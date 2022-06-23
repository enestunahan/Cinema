
namespace Cinema.Core.Models
{
    public class BaseEntity<T>
    {
       public T Id { get;set; }
       public DateTime? CreatedTime { get; set; }
       public bool IsDeleted { get; set; }
       
    }
}
