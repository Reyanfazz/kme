using Elfie.Serialization;
using System.Drawing;

namespace kme.Models
{
    public class UserDetailsEntity
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int TelephoneNumber { get; set; }

        public DateTime RegistredOn { get; set; }

        public DateTime ValidTill { get; set; }

        public DateTime ValidFrom { get; set; }

        public string Source { get; set; }
    
    }
}
