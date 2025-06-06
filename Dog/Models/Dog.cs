using System.ComponentModel.DataAnnotations;

namespace Dog.Models
{
    public class DogProfile
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
        public string ImageUrl { get; set; } = "https://www.vidavetcare.com/wp-content/uploads/sites/234/2022/04/golden-retriever-dog-breed-info.jpeg";
    }
}