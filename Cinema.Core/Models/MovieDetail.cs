
namespace Cinema.Core.Models
{
    public class MovieDetail : BaseEntity<int>
    {
        public DateTime? ReleaseDate { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public  decimal Budget { get; set; }
        public decimal BoxOffice { get; set; }
        public ushort RunningTime { get; set; }     
        public int MovieId { get; set; }
        public Movie Movie { get; set; }    
    }
}
