using System.ComponentModel.DataAnnotations;

namespace BackGameVerse.Entities
{
    public class GameList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public GameList(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            return obj is GameList list &&
                   Id == list.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
