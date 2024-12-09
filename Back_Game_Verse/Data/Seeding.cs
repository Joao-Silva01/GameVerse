using BackGameVerse.Entities;

namespace BackGameVerse.Data
{
    public class Seeding(GameVerseContext context)
    {
        private readonly GameVerseContext _context = context;

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if(_context.TGamesList.Any() || _context.TGames.Any())
            {
                return;
            }

            GameList gl1 = new GameList("Aventura e RPG");
            GameList gl2 = new GameList("Jogos de plataforma");

            Game g1 = new Game("Mass Effect Trilogy", 4.8, 2012, "Role-playing (RPG), Shooter", "XBox, Playstation, PC", 
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/1.png", 
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!", 
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g2 = new Game("Red Dead Redemption 2", 4.7, 2018, "Role-playing (RPG), Adventure", "XBox, Playstation, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/2.png",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!", 
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g3 = new Game("The Witcher 3: Wild Hunt", 4.7, 2014, "Role-playing (RPG), Adventure", "XBox, Playstation, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/3.png",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g4 = new Game("Sekiro: Shadows Die Twice", 3.8, 2019, "Role-playing (RPG), Adventure", "XBox, Playstation, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/4.png",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g5 = new Game("Ghost of Tsushima", 4.6, 2012, "Role-playing (RPG), Adventure", "XBox, Playstation, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/5.png",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g6 = new Game("Super Mario World", 4.7, 1990, "Platform", "Super Ness, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/6.png",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g7 = new Game("Hollow Knight", 4.6, 2017, "Platform", "XBox, Playstation, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/7.png",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g8 = new Game("Ori and the Blind Forest", 4, 2015, "Platform", "XBox, Playstation, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/8.png",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g9 = new Game("Cuphead", 4.6, 2017, "Platform", "XBox, Playstation, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/9.png",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur. " +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");

            Game g10 = new Game("Sonic CD", 4, 1993, "Platform", "Sega CD, PC",
                "https://raw.githubusercontent.com/devsuperior/java-spring-dslist/main/resources/10.png", 
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit esse officiis corrupti unde repellat non quibusdam! Id nihil itaque ipsum!",
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Delectus dolorum illum placeat eligendi, quis maiores veniam. Incidunt dolorum, " +
                "nisi deleniti dicta odit voluptatem nam provident temporibus reprehenderit blanditiis consectetur tenetur." +
                "Dignissimos blanditiis quod corporis iste, aliquid perspiciatis architecto quasi tempore ipsam voluptates ea ad distinctio, sapiente qui, amet quidem culpa.");


            Belonging b1 = new Belonging(1, 1, 0);
            Belonging b2 = new Belonging(1, 2, 1);
            Belonging b3 = new Belonging(1, 3, 2);
            Belonging b4 = new Belonging(1, 4, 3);
            Belonging b5 = new Belonging(1, 5, 4);

            Belonging b6 = new Belonging(2, 6, 0);
            Belonging b7 = new Belonging(2, 7, 1);
            Belonging b8 = new Belonging(2, 8, 2);
            Belonging b9 = new Belonging(2, 9, 3);
            Belonging b10 = new Belonging(2, 10, 4);

            _context.TGamesList.AddRangeAsync(gl1, gl2);
            _context.TGames.AddRangeAsync(g1, g2, g3, g4, g5, g6, g7, g8, g9, g10);
            _context.Belongings.AddRangeAsync(b1, b2, b3, b4, b5, b6, b7, b8, b9, b10);
            _context.SaveChangesAsync();

        }
    }
    
}
