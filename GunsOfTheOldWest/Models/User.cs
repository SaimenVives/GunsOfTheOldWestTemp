using System.ComponentModel.DataAnnotations;

namespace GunsOfTheOldWest.Models
{
    public class User
    {
        public string Id { get; set; }

        public required string Voornaam { get; set; }
        public string Familienaam { get; set;}
        public string Email { get; set; }
        public long Telefoonnummer { get; set; }

        public User GetUser(User user)
        {
            return user;
        }

    }
}
