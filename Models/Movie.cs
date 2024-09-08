using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Moive_finder.Models
{
    public class Movie
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        [DisplayName("Dispay Order")]
        [Range(1,100,ErrorMessage ="Dispaly order must be between 1-100")]
        public int DisplayOrder { get; set; }

        [DisplayName("Name")]
        [MaxLength(30)]
        public string? Name { get; set; }
        [DisplayName("Genre")]
        public string? Genre { get; set; }











    }
}
