using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Data.Entity
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Platform { get; set; }
        public decimal Rating { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
