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
            var games = new List<Game>
            {
                new Game
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
                },
                new Game
                {
                    GameId = 2,
                    Title = "Cyberpunk 2077",
                    Description = "Navigate through the dystopian metropolis of Night City as V, a mercenary outlaw on a mission to find a unique implant that holds the key to immortality.",
                    Price = 59.99M,
                    GameGenre = Genre.RPG,
                    GamePlatform = Platform.PC,
                    Developer = "CD Projekt Red",
                    Publisher = "CD Projekt",
                    CoverImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547902/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-game-of-the-year-edition-scaled-e1670012903149_jpzcd6.webp",
                    YoutubeTrailerId = "https://www.youtube.com/watch?v=UnA7tepsc7s",
                    WebsiteUrl = "https://www.cyberpunk.net/",
                },
                new Game
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
                },
                new Game
                {
                    GameId = 4,
                    Title = "The Elder Scrolls V: Skyrim",
                    Description = "Embark on an epic fantasy journey as the Dragonborn in the open world of Skyrim, filled with dragons, magic, and adventure.",
                    Price = 39.99M,
                    GameGenre = Genre.RPG,
                    GamePlatform = Platform.PC,
                    Developer = "Bethesda Game Studios",
                    Publisher = "Bethesda Softworks",
                    CoverImageUrl = "https://example.com/skyrim_cover.jpg",
                    YoutubeTrailerId = "https://www.youtube.com/watch?v=JSRtYpNRoN0",
                    WebsiteUrl = "https://elderscrolls.bethesda.net/en/skyrim",
                },
                new Game
                {
                    GameId = 5,
                    Title = "The Last of Us Part II",
                    Description = "Join Ellie in her journey for survival and revenge in a post-apocalyptic world filled with danger, emotion, and intense storytelling.",
                    Price = 49.99M,
                    GameGenre = Genre.Adventure,
                    GamePlatform = Platform.PS5,
                    Developer = "Naughty Dog",
                    Publisher = "Sony Interactive Entertainment",
                    CoverImageUrl = "https://example.com/lastofus2_cover.jpg",
                    YoutubeTrailerId = "https://www.youtube.com/watch?v=II5UsqP2JAk",
                    WebsiteUrl = "https://www.thelastofus.playstation.com/",
                },
                    new Game
                {
                    GameId = 6,
                    Title = "Halo Infinite",
                    Description = "Join Master Chief in his latest adventure to save humanity from the threats of the Halo universe in this highly anticipated first-person shooter.",
                    Price = 59.99M,
                    GameGenre = Genre.Adventure,
                    GamePlatform = Platform.XboxOne,
                    Developer = "343 Industries",
                    Publisher = "Xbox Game Studios",
                    CoverImageUrl = "https://example.com/haloinfinite_cover.jpg",
                    YoutubeTrailerId = "https://www.youtube.com/watch?v=ZtgzKBrU1GY",
                    WebsiteUrl = "https://www.halowaypoint.com/en-us/games/halo-infinite",
                },
                new Game
                {
                    GameId = 7,
                    Title = "Animal Crossing: New Horizons",
                    Description = "Create your own island paradise and enjoy a relaxing life simulation game where you can fish, catch bugs, and decorate your surroundings.",
                    Price = 49.99M,
                    GameGenre = Genre.Simulation,
                    GamePlatform = Platform.Switch,
                    Developer = "Nintendo",
                    Publisher = "Nintendo",
                    CoverImageUrl = "https://example.com/animalcrossing_cover.jpg",
                    YoutubeTrailerId = "https://www.youtube.com/watch?v=_3YNL0OWio0",
                    WebsiteUrl = "https://www.animal-crossing.com/new-horizons/",
                },
                new Game
                {
                    GameId = 8,
                    Title = "Mass Effect Legendary Edition",
                    Description = "Experience the epic space opera trilogy with updated visuals and gameplay, as Commander Shepard fights to save the galaxy from impending doom.",
                    Price = 49.99M,
                    GameGenre = Genre.RPG,
                    GamePlatform = Platform.PC,
                    Developer = "BioWare",
                    Publisher = "Electronic Arts",
                    CoverImageUrl = "https://example.com/masseffect_legendary_cover.jpg",
                    YoutubeTrailerId = "https://www.youtube.com/watch?v=n8i53TtQ6IQ",
                    WebsiteUrl = "https://www.ea.com/games/mass-effect/mass-effect-legendary-edition",
                },
                new Game
                {
                    GameId = 9,
                    Title = "FIFA 23",
                    Description = "Experience the latest iteration of the world's most popular soccer simulation game, featuring updated teams, graphics, and gameplay.",
                    Price = 59.99M,
                    GameGenre = Genre.Sports,
                    GamePlatform = Platform.PS4,
                    Developer = "EA Vancouver",
                    Publisher = "Electronic Arts",
                    CoverImageUrl = "https://example.com/fifa23_cover.jpg",
                    YoutubeTrailerId = "https://www.youtube.com/watch?v=o3V-GvvzjE4",
                    WebsiteUrl = "https://www.ea.com/games/fifa",
                },
                new Game
                {
                    GameId = 10,
                    Title = "Destiny 2",
                    Description = "Embark on an online multiplayer first-person shooter experience set in a mythic science fiction world filled with exploration, epic quests, and intense battles.",
                    Price = 0M,
                    GameGenre = Genre.Adventure,
                    GamePlatform = Platform.PC,
                    Developer = "Bungie",
                    Publisher = "Bungie",
                    CoverImageUrl = "https://example.com/destiny2_cover.jpg",
                    YoutubeTrailerId = "https://www.youtube.com/watch?v=SEn-HzPaLOo",
                    WebsiteUrl = "https://www.bungie.net/7/en/Destiny/NewLight",
                },
                // Add more game entries here...

            };
            


            var gameImages = new List<List<GameImage>>
            {
                new List<GameImage>
                {
                    // The Witcher 3
                    new GameImage { ImageId = 1, GameId = 1, ImageUrl = "https://example.com/witcher_3_image1.jpg" },
                    new GameImage { ImageId = 2, GameId = 1, ImageUrl = "https://example.com/witcher_3_image2.jpg" },
                    new GameImage { ImageId = 3, GameId = 1, ImageUrl = "https://example.com/witcher_3_image1.jpg" },
                    new GameImage { ImageId = 4, GameId = 1, ImageUrl = "https://example.com/witcher_3_image2.jpg" },
                    new GameImage { ImageId = 5, GameId = 1, ImageUrl = "https://example.com/witcher_3_image1.jpg" },
                    new GameImage { ImageId = 6, GameId = 1, ImageUrl = "https://example.com/witcher_3_image2.jpg" },
                    new GameImage { ImageId = 7, GameId = 1, ImageUrl = "https://example.com/witcher_3_image1.jpg" },
                    new GameImage { ImageId = 8, GameId = 1, ImageUrl = "https://example.com/witcher_3_image2.jpg" }
                },
                new List<GameImage>
                {
                    // Cyberpunk 2077
                    new GameImage { ImageId = 9, GameId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    new GameImage { ImageId = 10, GameId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    new GameImage { ImageId = 11, GameId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    new GameImage { ImageId = 12, GameId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    new GameImage { ImageId = 13, GameId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    new GameImage { ImageId = 14, GameId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    new GameImage { ImageId = 15, GameId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    new GameImage { ImageId = 16, GameId = 2, ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" }
                },
                new List<GameImage>
                {
                    // Red Dead Redemption 2
                    new GameImage { ImageId = 17, GameId = 3, ImageUrl = "https://example.com/reddead2_image1.jpg" },
                    new GameImage { ImageId = 18, GameId = 3, ImageUrl = "https://example.com/reddead2_image2.jpg" },
                    new GameImage { ImageId = 19, GameId = 3, ImageUrl = "https://example.com/reddead2_image1.jpg" },
                    new GameImage { ImageId = 20, GameId = 3, ImageUrl = "https://example.com/reddead2_image2.jpg" },
                    new GameImage { ImageId = 21, GameId = 3, ImageUrl = "https://example.com/reddead2_image1.jpg" },
                    new GameImage { ImageId = 22, GameId = 3, ImageUrl = "https://example.com/reddead2_image2.jpg" },
                    new GameImage { ImageId = 23, GameId = 3, ImageUrl = "https://example.com/reddead2_image1.jpg" },
                    new GameImage { ImageId = 24, GameId = 3, ImageUrl = "https://example.com/reddead2_image2.jpg" }
                },
                new List<GameImage>
                {
                    // The Elder Scrolls V: Skyrim
                    new GameImage { ImageId = 25, GameId = 4, ImageUrl = "https://example.com/skyrim_image1.jpg" },
                    new GameImage { ImageId = 26, GameId = 4, ImageUrl = "https://example.com/skyrim_image2.jpg" },
                    new GameImage { ImageId = 27, GameId = 4, ImageUrl = "https://example.com/skyrim_image1.jpg" },
                    new GameImage { ImageId = 28, GameId = 4, ImageUrl = "https://example.com/skyrim_image2.jpg" },
                    new GameImage { ImageId = 29, GameId = 4, ImageUrl = "https://example.com/skyrim_image1.jpg" },
                    new GameImage { ImageId = 30, GameId = 4, ImageUrl = "https://example.com/skyrim_image2.jpg" },
                    new GameImage { ImageId = 31, GameId = 4, ImageUrl = "https://example.com/skyrim_image1.jpg" },
                    new GameImage { ImageId = 32, GameId = 4, ImageUrl = "https://example.com/skyrim_image2.jpg" }
                },
                new List<GameImage>
                {
                    // The Last of Us Part II
                    new GameImage { ImageId = 33, GameId = 5, ImageUrl = "https://example.com/lastofus2_image1.jpg" },
                    new GameImage { ImageId = 34, GameId = 5, ImageUrl = "https://example.com/lastofus2_image2.jpg" },
                    new GameImage { ImageId = 35, GameId = 5, ImageUrl = "https://example.com/lastofus2_image1.jpg" },
                    new GameImage { ImageId = 36, GameId = 5, ImageUrl = "https://example.com/lastofus2_image2.jpg" },
                    new GameImage { ImageId = 37, GameId = 5, ImageUrl = "https://example.com/lastofus2_image1.jpg" },
                    new GameImage { ImageId = 38, GameId = 5, ImageUrl = "https://example.com/lastofus2_image2.jpg" },
                    new GameImage { ImageId = 39, GameId = 5, ImageUrl = "https://example.com/lastofus2_image1.jpg" },
                    new GameImage { ImageId = 40, GameId = 5, ImageUrl = "https://example.com/lastofus2_image2.jpg" }
                },
                new List<GameImage>
                {
                    // Halo Infinite
                    new GameImage { ImageId = 41, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image1.jpg" },
                    new GameImage { ImageId = 42, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image2.jpg" },
                    new GameImage { ImageId = 43, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image1.jpg" },
                    new GameImage { ImageId = 44, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image2.jpg" },
                    new GameImage { ImageId = 45, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image1.jpg" },
                    new GameImage { ImageId = 46, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image2.jpg" },
                    new GameImage { ImageId = 47, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image1.jpg" },
                    new GameImage { ImageId = 48, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image2.jpg" }
                },
                new List<GameImage>
                {
                    // Animal Crossing: New Horizons
                    new GameImage { ImageId = 49, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image1.jpg" },
                    new GameImage { ImageId = 50, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image2.jpg" },
                    new GameImage { ImageId = 51, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image1.jpg" },
                    new GameImage { ImageId = 52, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image2.jpg" },
                    new GameImage { ImageId = 53, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image1.jpg" },
                    new GameImage { ImageId = 54, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image2.jpg" },
                    new GameImage { ImageId = 55, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image1.jpg" },
                    new GameImage { ImageId = 56, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image2.jpg" }
                },
                new List<GameImage>
                {
                    // Mass Effect Legendary Edition
                    new GameImage { ImageId = 57, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image1.jpg" },
                    new GameImage { ImageId = 58, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image2.jpg" },
                    new GameImage { ImageId = 59, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image1.jpg" },
                    new GameImage { ImageId = 60, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image2.jpg" },
                    new GameImage { ImageId = 61, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image1.jpg" },
                    new GameImage { ImageId = 62, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image2.jpg" },
                    new GameImage { ImageId = 63, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image1.jpg" },
                    new GameImage { ImageId = 64, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image2.jpg" }
                },
                new List<GameImage>
                {
                    // FIFA 23
                    new GameImage { ImageId = 65, GameId = 9, ImageUrl = "https://example.com/fifa23_image1.jpg" },
                    new GameImage { ImageId = 66, GameId = 9, ImageUrl = "https://example.com/fifa23_image2.jpg" },
                    new GameImage { ImageId = 67, GameId = 9, ImageUrl = "https://example.com/fifa23_image1.jpg" },
                    new GameImage { ImageId = 68, GameId = 9, ImageUrl = "https://example.com/fifa23_image2.jpg" },
                    new GameImage { ImageId = 69, GameId = 9, ImageUrl = "https://example.com/fifa23_image1.jpg" },
                    new GameImage { ImageId = 70, GameId = 9, ImageUrl = "https://example.com/fifa23_image2.jpg" },
                    new GameImage { ImageId = 71, GameId = 9, ImageUrl = "https://example.com/fifa23_image1.jpg" },
                    new GameImage { ImageId = 72, GameId = 9, ImageUrl = "https://example.com/fifa23_image2.jpg" }
                },
                new List<GameImage>
                {
                    // Destiny 2
                    new GameImage { ImageId = 73, GameId = 10, ImageUrl = "https://example.com/destiny2_image1.jpg" },
                    new GameImage { ImageId = 74, GameId = 10, ImageUrl = "https://example.com/destiny2_image2.jpg" },
                    new GameImage { ImageId = 75, GameId = 10, ImageUrl = "https://example.com/destiny2_image1.jpg" },
                    new GameImage { ImageId = 76, GameId = 10, ImageUrl = "https://example.com/destiny2_image2.jpg" },
                    new GameImage { ImageId = 77, GameId = 10, ImageUrl = "https://example.com/destiny2_image1.jpg" },
                    new GameImage { ImageId = 78, GameId = 10, ImageUrl = "https://example.com/destiny2_image2.jpg" },
                    new GameImage { ImageId = 79, GameId = 10, ImageUrl = "https://example.com/destiny2_image1.jpg" },
                    new GameImage { ImageId = 80, GameId = 10, ImageUrl = "https://example.com/destiny2_image2.jpg" }
                },
                // Add image lists for other games...
            };

            // ... Loop ...


            for (int i = 0; i < games.Count; i++)
            {
                builder.Entity<Game>().HasData(games[i]);
            }

            for (int i = 0; i < gameImages.Count; i++)
            {
                foreach (var image in gameImages[i])
                {
                    builder.Entity<GameImage>().HasData(image);
                }
            }
        }
    }
}
