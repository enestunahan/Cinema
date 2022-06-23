using Microsoft.AspNetCore.Identity;
using static Cinema.Core.Models.Enum;

namespace Cinema.Core.Models
{
    public class User :IdentityUser
    {
        public string City { get; set; }
        public string Picture { get; set; }
        public DateTime? BirthDay { get; set; }
        public Gender Gender { get; set; }
    }
}
