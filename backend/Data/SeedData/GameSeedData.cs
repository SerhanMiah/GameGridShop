using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                    Title = "Sample Game 1",
                    Price = 29.99M,
                    GameGenre = Genre.Action,
                    GamePlatform = Platform.PC,
                    Developer = "Developer A",
                    Publisher = "Publisher A",
                    CoverImageUrl = "https://example.com/sample_game_1_cover.jpg",
                    YoutubeTrailerId = "sampleTrailerId1"
                },
                new Game 
                {
                    GameId = 2,
                    Title = "Sample Game 2",
                    Price = 49.99M,
                    GameGenre = Genre.RPG,
                    GamePlatform = Platform.PS5,
                    Developer = "Developer B",
                    Publisher = "Publisher B",
                    CoverImageUrl = "https://example.com/sample_game_2_cover.jpg",
                    YoutubeTrailerId = "sampleTrailerId2"
                }
            };

            builder.Entity<Game>().HasData(games);
        }
    }
}
