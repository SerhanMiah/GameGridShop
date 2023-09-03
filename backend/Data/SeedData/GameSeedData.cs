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
            var ElderScroll = new Game
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
            };

            var ElderScrollImages = new List<GameImage>
            {
                new GameImage { ImageId = 7, GameId = 4, ImageUrl = "https://example.com/skyrim_image1.jpg" },
                new GameImage { ImageId = 8, GameId = 4, ImageUrl = "https://example.com/skyrim_image2.jpg" }
            };

            var LastOfUsII = new Game
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
            };

            var LastOfUsIIImages = new List<GameImage>
            {
                new GameImage { ImageId = 9, GameId = 5, ImageUrl = "https://example.com/lastofus2_image1.jpg" },
                new GameImage { ImageId = 10, GameId = 5, ImageUrl = "https://example.com/lastofus2_image2.jpg" }
            };

            var HaloInfinite = new Game
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
            };

            var HaloInfiniteImages = new List<GameImage>
            {
                new GameImage { ImageId = 11, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image1.jpg" },
                new GameImage { ImageId = 12, GameId = 6, ImageUrl = "https://example.com/haloinfinite_image2.jpg" }
            };

            var AnimalCrossing = new Game
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
                YoutubeTrailerId = "https://www.youtube.com/watch?v=pU2U8x0Gczo",
                WebsiteUrl = "https://www.animal-crossing.com/new-horizons/",
            };

            var AnimalCrossingImages = new List<GameImage>
            {
                new GameImage { ImageId = 13, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image1.jpg" },
                new GameImage { ImageId = 14, GameId = 7, ImageUrl = "https://example.com/animalcrossing_image2.jpg" }
            };

            var MassEffect = new Game
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
                YoutubeTrailerId = "https://www.youtube.com/watch?v=1HmBAGDwIis",
                WebsiteUrl = "https://www.ea.com/games/mass-effect/mass-effect-legendary-edition",
            };

            var MassEffectImages = new List<GameImage>
            {
                new GameImage { ImageId = 15, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image1.jpg" },
                new GameImage { ImageId = 16, GameId = 8, ImageUrl = "https://example.com/masseffect_legendary_image2.jpg" }
            };

            var Fifa = new Game
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
                YoutubeTrailerId = "https://www.youtube.com/watch?v=-_RB7GKjNBk",
                WebsiteUrl = "https://www.ea.com/games/fifa",
            };

            var FifaImages = new List<GameImage>
            {
                new GameImage { ImageId = 17, GameId = 9, ImageUrl = "https://example.com/fifa23_image1.jpg" },
                new GameImage { ImageId = 18, GameId = 9, ImageUrl = "https://example.com/fifa23_image2.jpg" }
            };

            var Destiny2 = new Game
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
                YoutubeTrailerId = "https://www.youtube.com/watch?v=2FtO2c4D1pE",
                WebsiteUrl = "https://www.bungie.net/7/en/Destiny/NewLight",
            };

            var DestinyImages = new List<GameImage>
            {
                new GameImage { ImageId = 19, GameId = 10, ImageUrl = "https://example.com/destiny2_image1.jpg" },
                new GameImage { ImageId = 20, GameId = 10, ImageUrl = "https://example.com/destiny2_image2.jpg" }
            };

            var DarkSouls = new Game
            {
                GameId = 11,
                Title = "Dark Souls III",
                Description = "Enter a dark and challenging fantasy world as the Ashen One, facing deadly enemies and intricate level design in this action RPG.",
                Price = 39.99M,
                GameGenre = Genre.RPG,
                GamePlatform = Platform.PC,
                Developer = "FromSoftware",
                Publisher = "Bandai Namco Entertainment",
                CoverImageUrl = "https://example.com/darksouls3_cover.jpg",
                YoutubeTrailerId = "https://www.youtube.com/watch?v=J6GRf7kOSIk",
                WebsiteUrl = "https://www.bandainamcoent.com/games/dark-souls-iii",
            };

            var DarkSoulsImages = new List<GameImage>
            {
                new GameImage { ImageId = 21, GameId = 11, ImageUrl = "https://example.com/darksouls3_image1.jpg" },
                new GameImage { ImageId = 22, GameId = 11, ImageUrl = "https://example.com/darksouls3_image2.jpg" }
            };

            var CallOfDutyWarzone = new Game
            {
                GameId = 12,
                Title = "Call of Duty: Warzone",
                Description = "Engage in fast-paced battle royale action in the popular free-to-play title from the Call of Duty franchise, featuring intense gunfights and tactical gameplay.",
                Price = 0M,
                GameGenre = Genre.Adventure,
                GamePlatform = Platform.PC,
                Developer = "Infinity Ward",
                Publisher = "Activision",
                CoverImageUrl = "https://example.com/warzone_cover.jpg",
                YoutubeTrailerId = "https://www.youtube.com/watch?v=PRGOUEUTLHM",
                WebsiteUrl = "https://www.callofduty.com/warzone",
            };

            var CallOfDutyWarzoneImages = new List<GameImage>
            {
                new GameImage { ImageId = 27, GameId = 12, ImageUrl = "https://example.com/warzone_image1.jpg" },
                new GameImage { ImageId = 28, GameId = 12, ImageUrl = "https://example.com/warzone_image2.jpg" }
            };

            var HorizonZeroDawn = new Game
            {
                GameId = 13,
                Title = "Horizon Zero Dawn",
                Description = "Experience a post-apocalyptic world as Aloy, a hunter in a world overrun by robotic creatures, and uncover the mysteries of her past.",
                Price = 39.99M,
                GameGenre = Genre.Adventure,
                GamePlatform = Platform.PC,
                Developer = "Guerrilla Games",
                Publisher = "Sony Interactive Entertainment",
                CoverImageUrl = "https://example.com/horizonzerodawn_cover.jpg",
                YoutubeTrailerId = "https://www.youtube.com/watch?v=nwW9JhZk8Jg",
                WebsiteUrl = "https://www.guerrilla-games.com/play/horizon",
            };

            var HorizonZeroDawnImages = new List<GameImage>
            {
                new GameImage { ImageId = 29, GameId = 13, ImageUrl = "https://example.com/horizonzerodawn_image1.jpg" },
                new GameImage { ImageId = 30, GameId = 13, ImageUrl = "https://example.com/horizonzerodawn_image2.jpg" }
            };

            var ResidentEvilVillage = new Game
            {
                GameId = 14,
                Title = "Resident Evil Village",
                Description = "Step into the shoes of Ethan Winters as he navigates a mysterious village filled with horror and danger, in the latest installment of the Resident Evil series.",
                Price = 49.99M,
                GameGenre = Genre.Horror,
                GamePlatform = Platform.PS5,
                Developer = "Capcom",
                Publisher = "Capcom",
                CoverImageUrl = "https://example.com/re8_cover.jpg",
                YoutubeTrailerId = "https://www.youtube.com/watch?v=8d4IG3w-wlU",
                WebsiteUrl = "https://www.residentevil.com/village/",
            };

            var ResidentEvilVillageImages = new List<GameImage>
            {
                new GameImage { ImageId = 31, GameId = 14, ImageUrl = "https://example.com/re8_image1.jpg" },
                new GameImage { ImageId = 32, GameId = 14, ImageUrl = "https://example.com/re8_image2.jpg" }
            };

            var GhostOfTsushima = new Game
            {
                GameId = 15,
                Title = "Ghost of Tsushima",
                Description = "Embark on a samurai adventure as Jin Sakai, fighting to save the island of Tsushima from the Mongol invasion, in this action-packed open-world game.",
                Price = 59.99M,
                GameGenre = Genre.Adventure,
                GamePlatform = Platform.PS4,
                Developer = "Sucker Punch Productions",
                Publisher = "Sony Interactive Entertainment",
                CoverImageUrl = "https://example.com/ghostoftsushima_cover.jpg",
                YoutubeTrailerId = "https://www.youtube.com/watch?v=hQEvP12hwNQ",
                WebsiteUrl = "https://www.suckerpunch.com/ghostoftsushima/",
            };

            var GhostOfTsushimaImages = new List<GameImage>
            {
                new GameImage { ImageId = 33, GameId = 15, ImageUrl = "https://example.com/ghostoftsushima_image1.jpg" },
                new GameImage { ImageId = 34, GameId = 15, ImageUrl = "https://example.com/ghostoftsushima_image2.jpg" }
            };



            builder.Entity<Game>().HasData(
                witcher3, cyberpunk2077, redDead2, ElderScroll, LastOfUsII, HaloInfinite, AnimalCrossing, MassEffect, Fifa, Destiny2, DarkSouls, HorizonZeroDawn, CallOfDutyWarzone, ResidentEvilVillage, GhostOfTsushima /* and more game objects... */
            );

            builder.Entity<GameImage>().HasData(
                witcher3Images, cyberpunk2077Images, redDead2Images, ElderScrollImages, LastOfUsIIImages, HaloInfiniteImages, AnimalCrossingImages, MassEffectImages, FifaImages, DestinyImages, DarkSoulsImages, CallOfDutyWarzoneImages, HorizonZeroDawnImages, ResidentEvilVillageImages, GhostOfTsushimaImages /* and more image lists... */
            );

        }
    }
}
