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
                // Add more images with subsequent ImageIds and the same GameId of 1...
            };

            builder.Entity<Game>().HasData(witcher3);
            builder.Entity<GameImage>().HasData(witcher3Images);
        }
    }
}
