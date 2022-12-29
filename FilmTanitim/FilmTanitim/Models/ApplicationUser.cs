using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmTanitim.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string NameSurname { get; set; }
        [NotMapped]
        public string Role { get; set; }

    }
}
