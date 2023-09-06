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
            // Seed data for Ratings
            var ratings = new List<Rating>
            {
                new Rating { RatingId = 1, Name = "E", Description = "Everyone" },
                new Rating { RatingId = 2, Name = "Mature", Description = "Mature Audience" },
                new Rating { RatingId = 3, Name = "Age15Plus", Description = "Mature 15+" },
                new Rating { RatingId = 4, Name = "Age12Plus", Description = "12+" }
            };
            
            builder.Entity<Rating>().HasData(ratings);

            // Seed data for Tags
            var tags = new List<Tag>
            {
                new Tag { TagId = 1, Name = "Fantasy" },
                new Tag { TagId = 2, Name = "Open-World" },
                new Tag { TagId = 3, Name = "Action" },
                new Tag { TagId = 4, Name = "Adventure" },
                new Tag { TagId = 5, Name = "RPG" },
                new Tag { TagId = 6, Name = "Strategy" },
                new Tag { TagId = 21, Name = "PC" },
                new Tag { TagId = 22, Name = "PS4" },
                new Tag { TagId = 23, Name = "PS5" },
                new Tag { TagId = 24, Name = "XboxOne" },
                new Tag { TagId = 25, Name = "XboxSeriesX" },
                new Tag { TagId = 26, Name = "Switch" },
                new Tag { TagId = 27, Name = "Mobile" }
                // ... Add more tags here...
            };

            builder.Entity<Tag>().HasData(tags);

            // Seed data for Games
            var games = new List<Game>
            {
                new Game
                {
                    GameId = 1,
                    Title = "The Witcher 3: Wild Hunt",
                    Description = "Embark on a journey as Geralt...",
                    Price = 29.99M,
                    GameGenre = Genre.RPG,
                    GamePlatform = Platform.PC,
                    Developer = "CD Projekt Red",
                    Publisher = "CD Projekt",
                    CoverImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1694016203/TimelineCovers.pro_video-game-the-witcher-3-wild-hunt-the-score-facebook-cover_sfined.jpg",
                    YoutubeTrailerId = "c0i88t0Kacs",
                    WebsiteUrl = "https://www.playstation.com/en-gb/games/the-witcher-3-wild-hunt/",
                    Rating = GameRating.Mature,
                    CreatedDate = DateTime.Now
                },
            };

            builder.Entity<Game>().HasData(games);

            // Seed data for GameImages
            var witcherGameImages = new List<GameImage>
            {
                new GameImage { ImageId = 1, GameId = 1, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1694016203/TimelineCovers.pro_video-game-the-witcher-3-wild-hunt-the-score-facebook-cover_sfined.jpg" },
                new GameImage { ImageId = 2, GameId = 1, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1694016203/TimelineCovers.pro_video-game-the-witcher-3-wild-hunt-the-score-facebook-cover_sfined.jpg" },
                // ... Add more game images here...
            };

            builder.Entity<GameImage>().HasData(witcherGameImages);

            // Seed data for Editions
            var editions = new List<Edition>
            {
                new Edition { EditionId = 1, Name = "Standard Edition", Price = 29.99M, GameId = 1 },
            };

            builder.Entity<Edition>().HasData(editions);

            // Seed data for DLCs
            var dlcs = new List<DLC>
            {
                new DLC { DLCId = 1, Name = "Blood and Wine", Description = "Geralt embarks on a brand-new and expansive 30+ hour adventure in the new region of Toussaint.", Price = 19.99M, ReleaseDate = new DateTime(2016, 5, 31), GameId = 1 },
                new DLC { DLCId = 2, Name = "Hearts of Stone", Description = "A new 10-hour single-player story-driven adventure.", Price = 9.99M, ReleaseDate = new DateTime(2015, 10, 13), GameId = 1 },
                new DLC { DLCId = 3, Name = "New Quest - 'Where the Cat and Wolf Play'", Description = "Explore a forgotten village and discover its terrifying secret.", Price = 0.00M, ReleaseDate = new DateTime(2015, 7, 3), GameId = 1 },
                new DLC { DLCId = 4, Name = "Skellige Armor Set", Description = "Enhance your close combat arsenal with a set of new gear.", Price = 0.00M, ReleaseDate = new DateTime(2015, 6, 3), GameId = 1 },
            };


            builder.Entity<DLC>().HasData(dlcs);

            // Seed data for GameTags
            var gameTags = new List<GameTag>
            {
                new GameTag { GameId = 1, TagId = 1 }, // Fantasy
                new GameTag { GameId = 1, TagId = 2 }, // Open-World
                new GameTag { GameId = 1, TagId = 3 }, // Action
                new GameTag { GameId = 1, TagId = 4 }, // Adventure
                new GameTag { GameId = 1, TagId = 5 }, // RPG
                new GameTag { GameId = 1, TagId = 21 }, // PC
            };


            builder.Entity<GameTag>().HasData(gameTags);
        }
    }
}
