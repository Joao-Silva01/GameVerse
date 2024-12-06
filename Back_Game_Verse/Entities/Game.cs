using System.ComponentModel.DataAnnotations;

namespace BackGameVerse.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public double Score { get; set; }

        [MaxLength(4)]
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Platforms { get; set; }
        public string ImgUrl { get; set; }

        [MaxLength(120)]
        public string ShortDescription { get; set; }
        [MaxLength(400)]
        public string LongDescription { get; set; }

        public Game(int id, string title, double score, int year,
            string genre, string platforms, string imgUrl, 
            string shortDescription, string longDescription)
        {
            Id = id;
            Title = title;
            Score = score;
            Year = year;
            Genre = genre;
            Platforms = platforms;
            ImgUrl = imgUrl;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
        }

        public override bool Equals(object? obj)
        {
            return obj is Game game &&
                   Id == game.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
