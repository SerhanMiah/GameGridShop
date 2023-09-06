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
            SeedRatings(builder);
            SeedTags(builder);
            SeedGames(builder);
            SeedGameImages(builder);
            SeedEditions(builder);
            SeedDLCs(builder);
            SeedGameTags(builder);
        }

        private static void SeedRatings(ModelBuilder builder)
        {
            var ratings = new List<Rating>
            {
                new Rating { RatingId = 1, Name = "E", Description = "Everyone" },
                new Rating { RatingId = 2, Name = "Mature", Description = "Mature Audience" },
                new Rating { RatingId = 3, Name = "Age15Plus", Description = "Mature 15+" },
                new Rating { RatingId = 4, Name = "Age12Plus", Description = "12+" }
            };
            
            builder.Entity<Rating>().HasData(ratings);
        }

        private static void SeedTags(ModelBuilder builder)
        {
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
            };

            builder.Entity<Tag>().HasData(tags);
        }

// ...

        private static void SeedGames(ModelBuilder builder)
        {
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
                new Game
                {
                    GameId = 2,
                    Title = "Red Dead Redemption 2",
                    Description = "An epic tale of life in America’s unforgiving heartland.",
                    Price = 49.99M,
                    GameGenre = Genre.Action,
                    GamePlatform = Platform.PS4,
                    Developer = "Rockstar Games",
                    Publisher = "Rockstar Games",
                    CoverImageUrl = "https://example.com/red-dead-redemption-2.jpg",
                    YoutubeTrailerId = "QXN_sVMJsSk",
                    WebsiteUrl = "https://www.rockstargames.com/reddeadredemption2/",
                    Rating = GameRating.Mature,
                    CreatedDate = DateTime.Now
                },
                new Game
                {
                    GameId = 3,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Description = "Explore the vast open world of Hyrule in this action-adventure game.",
                    Price = 59.99M,
                    GameGenre = Genre.Action,
                    GamePlatform = Platform.Switch,
                    Developer = "Nintendo",
                    Publisher = "Nintendo",
                    CoverImageUrl = "https://example.com/zelda-breath-of-the-wild.jpg",
                    YoutubeTrailerId = "1rPxiXXxftE",
                    WebsiteUrl = "https://www.zelda.com/breath-of-the-wild/",
                    Rating = GameRating.Age12Plus,
                    CreatedDate = DateTime.Now
                },
                new Game
                {
                    GameId = 4,
                    Title = "Cyberpunk 2077",
                    Description = "Enter the dark future of Night City in this sci-fi RPG.",
                    Price = 39.99M,
                    GameGenre = Genre.RPG,
                    GamePlatform = Platform.PC,
                    Developer = "CD Projekt Red",
                    Publisher = "CD Projekt",
                    CoverImageUrl = "https://example.com/cyberpunk-2077.jpg",
                    YoutubeTrailerId = "8X2kIfS6fb8",
                    WebsiteUrl = "https://www.cyberpunk.net/",
                    Rating = GameRating.Mature,
                    CreatedDate = DateTime.Now
                },
                new Game
                {
                    GameId = 5,
                    Title = "FIFA 22",
                    Description = "Experience the excitement of soccer in FIFA 22.",
                    Price = 49.99M,
                    GameGenre = Genre.Sports,
                    GamePlatform = Platform.XboxSeriesX,
                    Developer = "EA Sports",
                    Publisher = "Electronic Arts",
                    CoverImageUrl = "https://example.com/fifa-22.jpg",
                    YoutubeTrailerId = "nT9xG4k6sJ0",
                    WebsiteUrl = "https://www.ea.com/games/fifa/fifa-22/",
                    Rating = GameRating.E,
                    CreatedDate = DateTime.Now
                },
                new Game
                {
                    GameId = 6,
                    Title = "Assassin's Creed Valhalla",
                    Description = "Become a legendary Viking raider in Assassin's Creed Valhalla.",
                    Price = 44.99M,
                    GameGenre = Genre.Action,
                    GamePlatform = Platform.PS5,
                    Developer = "Ubisoft",
                    Publisher = "Ubisoft",
                    CoverImageUrl = "https://example.com/assassins-creed-valhalla.jpg",
                    YoutubeTrailerId = "ssrOz7CbjkA",
                    WebsiteUrl = "https://www.ubisoft.com/en-us/game/assassins-creed/valhalla/",
                    Rating = GameRating.Age15Plus,
                    CreatedDate = DateTime.Now
                },
                new Game
                {
                    GameId = 7,
                    Title = "Minecraft",
                    Description = "Explore a blocky, procedurally-generated 3D world with infinite terrain in Minecraft.",
                    Price = 19.99M,
                    GameGenre = Genre.Sandbox,
                    GamePlatform = Platform.PS4,
                    Developer = "Mojang Studios",
                    Publisher = "Microsoft Studios",
                    CoverImageUrl = "https://example.com/minecraft.jpg",
                    YoutubeTrailerId = "MmB9b5njVbA",
                    WebsiteUrl = "https://www.minecraft.net/",
                    Rating = GameRating.E,
                    CreatedDate = DateTime.Now
                },
                new Game
                {
                    GameId = 8,
                    Title = "Halo Infinite",
                    Description = "Join Master Chief in the next chapter of the legendary Halo saga.",
                    Price = 59.99M,
                    GameGenre = Genre.Shooter,
                    GamePlatform = Platform.XboxSeriesX,
                    Developer = "343 Industries",
                    Publisher = "Xbox Game Studios",
                    CoverImageUrl = "https://example.com/halo-infinite.jpg",
                    YoutubeTrailerId = "HZtc5-syeAk",
                    WebsiteUrl = "https://www.halowaypoint.com/",
                    Rating = GameRating.Mature,
                    CreatedDate = DateTime.Now
                },
            };

            builder.Entity<Game>().HasData(games);
        }

        private static void SeedGameImages(ModelBuilder builder)
        {
            var witcherGameImages = new List<GameImage>
            {
                new GameImage { ImageId = 1, GameId = 1, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1694016203/TimelineCovers.pro_video-game-the-witcher-3-wild-hunt-the-score-facebook-cover_sfined.jpg" },
                new GameImage { ImageId = 2, GameId = 1, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1694016203/TimelineCovers.pro_video-game-the-witcher-3-wild-hunt-the-score-facebook-cover_sfined.jpg" },
            };

            builder.Entity<GameImage>().HasData(witcherGameImages);
        }

        private static void SeedEditions(ModelBuilder builder)
        {
            var editions = new List<Edition>
            {
                new Edition { EditionId = 1, Name = "Standard Edition", Price = 29.99M, GameId = 1 },
                new Edition { EditionId = 2, Name = "Ultimate Edition", Price = 59.99M, GameId = 2 },
                new Edition { EditionId = 3, Name = "Special Edition", Price = 39.99M, GameId = 4 },
                new Edition { EditionId = 4, Name = "Gold Edition", Price = 49.99M, GameId = 5 },
                new Edition { EditionId = 5, Name = "Deluxe Edition", Price = 54.99M, GameId = 6 },
                new Edition { EditionId = 6, Name = "Standard Edition", Price = 19.99M, GameId = 7 },
                new Edition { EditionId = 7, Name = "Collector's Edition", Price = 79.99M, GameId = 8 },
            };

            builder.Entity<Edition>().HasData(editions);
        }

        private static void SeedDLCs(ModelBuilder builder)
        {
            var dlcs = new List<DLC>
            {
                new DLC { DLCId = 1, Name = "Blood and Wine", Description = "Geralt embarks on a brand-new and expansive 30+ hour adventure in the new region of Toussaint.", Price = 19.99M, ReleaseDate = new DateTime(2016, 5, 31), GameId = 1 },
                new DLC { DLCId = 2, Name = "Hearts of Stone", Description = "A new 10-hour single-player story-driven adventure.", Price = 9.99M, ReleaseDate = new DateTime(2015, 10, 13), GameId = 1 },
                new DLC { DLCId = 3, Name = "New Quest - 'Where the Cat and Wolf Play'", Description = "Explore a forgotten village and discover its terrifying secret.", Price = 0.00M, ReleaseDate = new DateTime(2015, 7, 3), GameId = 1 },
                new DLC { DLCId = 4, Name = "Skellige Armor Set", Description = "Enhance your close combat arsenal with a set of new gear.", Price = 0.00M, ReleaseDate = new DateTime(2015, 6, 3), GameId = 1 },
                // ... Add DLCs for other games here...
            };

            builder.Entity<DLC>().HasData(dlcs);

            // Seed data for DLC images
            var dlcImages = new List<DLCImage>
            {
                new DLCImage { ImageId = 1, DLCId = 1, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg" },
                new DLCImage { ImageId = 2, DLCId = 1, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg" },
                new DLCImage { ImageId = 3, DLCId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg" },
                // ... Add DLC images for other DLCs here...
            };

            builder.Entity<DLCImage>().HasData(dlcImages);
        }

        private static void SeedGameTags(ModelBuilder builder)
        {
            var gameTags = new List<GameTag>
            {
                new GameTag { GameId = 1, TagId = 1 },  // Fantasy
                new GameTag { GameId = 1, TagId = 2 },  // Open-World
                new GameTag { GameId = 1, TagId = 3 },  // Action
                new GameTag { GameId = 1, TagId = 4 },  // Adventure
                new GameTag { GameId = 1, TagId = 5 },  // RPG
                new GameTag { GameId = 1, TagId = 21 }, // PC


                new GameTag { GameId = 2, TagId = 3 },  // Action
                new GameTag { GameId = 2, TagId = 4 },  // Adventure
                new GameTag { GameId = 2, TagId = 22 }, // PS4


                new GameTag { GameId = 3, TagId = 1 },  // Fantasy
                new GameTag { GameId = 3, TagId = 2 },  // Open-World
                new GameTag { GameId = 3, TagId = 4 },  // Adventure
                new GameTag { GameId = 3, TagId = 26 }, // Switch

                new GameTag { GameId = 4, TagId = 5 },  // RPG
                new GameTag { GameId = 4, TagId = 21 }, // PC
                new GameTag { GameId = 4, TagId = 27 }, // Mobile

                new GameTag { GameId = 5, TagId = 6 },  // Strategy
                new GameTag { GameId = 5, TagId = 25 }, // XboxSeriesX
            };

            builder.Entity<GameTag>().HasData(gameTags);
        }
    }
}
