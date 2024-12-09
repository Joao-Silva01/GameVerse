namespace BackGameVerse.Entities
{
    public class Belonging
    {

        public int GameId { get; set; }
        public int GameListId { get; set; }
        public int Position { get; set; }

        public Belonging(int gameId, int gameListId, int position)
        {
            GameId = gameId;
            GameListId = gameListId;
            Position = position;
        }
    }
}
