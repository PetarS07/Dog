using System.ComponentModel.DataAnnotations;

namespace Dog.Models
{
    public class Dog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Breed { get; set; }

        public int Age { get; set; }

        [Required]
        public string MainDescription { get; set; }

        [Required]
        public string DetailedDescription { get; set; }

        public string FavoriteFood { get; set; }
        public string FavoriteToy { get; set; }
        public string SpecialSkills { get; set; }
    }
}