using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend.Model
{
    public enum Genre
    {
        Action,
        Adventure,
        RPG,
        Strategy,
        Simulation,
        Racing,
        Sports,
        Horror,
        Puzzle,
    }

    public enum Platform
    {
        PC,
        PS4,
        PS5,
        XboxOne,
        XboxSeriesX,
        Switch,
        Mobile,
    }

    public class GameImage
    {
        [Key]
        public int ImageId { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public int GameId { get; set; }

        public virtual Game Game { get; set; }
    }

    public class Game
    {
        [Key]
        public int GameId {get; set;}

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public decimal Price { get; set; }

        public Genre GameGenre { get; set; }

        public Platform GamePlatform { get; set; }

        public string? Developer { get; set; }

        public string? Publisher { get; set; }

        public string? CoverImageUrl { get; set; }

        public string? YoutubeTrailerId { get; set; }

        public virtual ICollection<GameImage> Images { get; set; }

        public ICollection<Review>? Reviews { get; set; }
    }
}
