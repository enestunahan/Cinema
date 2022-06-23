
namespace Cinema.Core.Models
{
    public class MovieCategory : BaseEntity<ushort>
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; set;}
    }
}
