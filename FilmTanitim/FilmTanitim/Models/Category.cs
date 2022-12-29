using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmTanitim.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public  List<Movie> Movie { get; set; }
    }
}
