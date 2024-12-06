using BackGameVerse.Entities;

namespace BackGameVerse.DTO
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Score { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Platforms { get; set; }
        public string ImgUrl { get; set; }
        public string LongDescription { get; set; }

        public GameDTO(Game entity)
        {
            Id = entity.Id;
            Title = entity.Title;
            Score = entity.Score;
            Year = entity.Year;
            Genre = entity.Genre;
            Platforms = entity.Platforms;
            ImgUrl = entity.ImgUrl;
            LongDescription = entity.LongDescription;
        }
    }
}
