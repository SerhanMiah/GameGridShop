using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.VideoGame;

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
        Fighting,
        Platformer,
        Sandbox,
        Stealth,
        Music,
        VisualNovel,
        Survival,
        Tactical,
        Metroidvania,
        Educational,
        Card,
        MOBA,
        BattleRoyale,
        Rhythm,
        OpenWorld,
        PointAndClick,
        Roguelike,
        TurnBased,
        GrandStrategy,
        HackAndSlash,
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

    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        public Genre GameGenre { get; set; }

        [Required]
        public Platform GamePlatform { get; set; }
        [MaxLength(100)]
        public string? Developer { get; set; }

        [MaxLength(100)]
        public string? Publisher { get; set; }

        [MaxLength(500)]
        public string? CoverImageUrl { get; set; }

        [MaxLength(50)]
        public string? YoutubeTrailerId { get; set; }

        [MaxLength(100)]
        public string? WebsiteUrl { get; set; }

        // Audit fields
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Navigation properties
        public virtual ICollection<GameImage> Images { get; set; }
        public virtual ICollection<Review> Reviews { get; set; } // Assuming Review model exists in your codebase
        public virtual ICollection<CartItem> CartItems { get; set; } // Assuming CartItem model exists in your codebase

    }


    public class GameImage
    {
        [Key]
        public int ImageId { get; set; } 
        public string? ImageUrl { get; set; }

        [Required]
        public int GameId { get; set; }

        public virtual Game? Game { get; set; }
    }

}
