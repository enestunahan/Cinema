
namespace Cinema.Core.Models
{
    public class MoviePoster : BaseEntity<int>
    {
        public string Url { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}
