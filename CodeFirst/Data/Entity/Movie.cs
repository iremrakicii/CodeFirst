using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Data.Entity
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public List<Game> Games { get; set; }
    }
}
