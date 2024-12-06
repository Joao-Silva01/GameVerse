using BackGameVerse.Entities;

namespace BackGameVerse.DTO
{
    public class GameMinDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Score { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Platforms { get; set; }
        public string ImgUrl { get; set; }
        public string ShortDescription { get; set; }

        public GameMinDTO(Game entity) 
        {
            Id = entity.Id;
            Title = entity.Title;
            Score = entity.Score;
            Year = entity.Year;
            Genre = entity.Genre;
            Platforms = entity.Platforms;
            ImgUrl = entity.ImgUrl;
            ShortDescription = entity.ShortDescription;
        }
    }
}
