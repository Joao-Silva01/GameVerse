namespace BackGameVerse.Entities
{
    public class Belonging
    {

        public int GameId { get; set; }
        public int GameListId { get; set; }
        public int Position { get; set; }

        public Belonging(int gameListId ,int gameId, int position)
        {
            GameId = gameId;
            GameListId = gameListId;
            Position = position;
        }
    }
}
