using System;
using System.Collections.Generic;
using backend.Model;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.SeedData
{
    public class GameSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            var witcher3 = new Game
            {
                GameId = 1,
                Title = "The Witcher 3: Wild Hunt",
                Description = "Embark on a dark and epic journey as Geralt of Rivia, a monster hunter for hire, in a world filled with political intrigue, dangerous creatures, and captivating stories.",
                Price = 29.99M,
                GameGenre = Genre.RPG,
                GamePlatform = Platform.PC,
                Developer = "CD Projekt Red",
                Publisher = "CD Projekt",
                CoverImageUrl = "https://example.com/witcher_3_cover.jpg",
                YoutubeTrailerId = "https://www.youtube.com/watch?v=c0i88t0Kacs",
                WebsiteUrl = "https://www.playstation.com/en-gb/games/the-witcher-3-wild-hunt/",
            };
            
            var witcher3Images = new List<GameImage>
            {
                new GameImage { ImageId = 1, GameId = 1, ImageUrl = "https://example.com/witcher_3_image1.jpg" },
                new GameImage { ImageId = 2, GameId = 1, ImageUrl = "https://example.com/witcher_3_image2.jpg" }
            };

            var cyberpunk2077 = new Game
            {
                GameId = 2,
                Title = "Cyberpunk 2077",
                Description = "Navigate through the dystopian metropolis of Night City as V, a mercenary outlaw on a mission to find a unique implant that holds the key to immortality.",
                Price = 59.99M,
                GameGenre = Genre.RPG,
                GamePlatform = Platform.PC,
                Developer = "CD Projekt Red",
                Publisher = "CD Projekt",
                CoverImageUrl = "https://example.com/cyberpunk_cover.jpg",
                YoutubeTrailerId = "https://www.youtube.com/watch?v=UnA7tepsc7s",
                WebsiteUrl = "https://www.cyberpunk.net/",
            };

           var cyberpunk2077Images = new List<GameImage>
            {
                new GameImage { ImageId = 3, GameId = 2, ImageUrl = "https://example.com/cyberpunk_image1.jpg" },
                new GameImage { ImageId = 4, GameId = 2, ImageUrl = "https://example.com/cyberpunk_image2.jpg" }
            };

            var redDead2 = new Game
            {
                GameId = 3,
                Title = "Red Dead Redemption 2",
                Description = "Journey through the rugged heartland of America as Arthur Morgan, a member of the Van der Linde gang, and experience the end of the Wild West era.",
                Price = 49.99M,
                GameGenre = Genre.Action,
                GamePlatform = Platform.PC,
                Developer = "Rockstar Games",
                Publisher = "Rockstar Games",
                CoverImageUrl = "https://example.com/reddead2_cover.jpg",
                YoutubeTrailerId = "https://www.youtube.com/watch?v=gmA6MrX81z4",
                WebsiteUrl = "https://www.rockstargames.com/reddeadredemption2/",
            };

            var redDead2Images = new List<GameImage>
            {
                new GameImage { ImageId = 5, GameId = 3, ImageUrl = "https://example.com/reddead2_image1.jpg" },
                new GameImage { ImageId = 6, GameId = 3, ImageUrl = "https://example.com/reddead2_image2.jpg" }
            };
            // You would continue with this structure for other games...
            // ...

            builder.Entity<Game>().HasData(witcher3, cyberpunk2077, redDead2 /*, and other game objects...*/);
            builder.Entity<GameImage>().HasData(witcher3Images, cyberpunk2077Images, redDead2Images /*, and similar lists for other games...*/);
        }
    }
}
