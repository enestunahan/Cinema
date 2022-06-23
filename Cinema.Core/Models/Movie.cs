

namespace Cinema.Core.Models
{
    public class Movie :BaseEntity<int>
    {
        public string Name { get; set; }
        public ushort ImdbRating { get; set; }
        public List<MovieCategory> Categories { get; set; }
        public List<MoviePoster> Posters { get; set; }
        public List<EmployeeRole> Roles { get; set; }
        public MovieDetail MovieDetail { get; set; }  
    }
}
