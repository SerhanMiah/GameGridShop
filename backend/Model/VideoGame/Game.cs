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

    public enum GameRating
    {
        E,          // Everyone
        Mature,     // Mature
        Age15Plus,  // Mature 15+
        Age12Plus   // 12+
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

        public GameRating? Rating { get; set; }

        // Audit fields
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Navigation properties
        public virtual ICollection<GameImage> Images { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }

        // In your Game class
        public virtual ICollection<GameTag> GameTags { get; set; }

        public ICollection<DLC> Dlcs { get; set; } 

         public ICollection<Edition> Editions { get; set; } 



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

        public class Edition
    {
        [Key]
        public int EditionId { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int GameId { get; set; }
        public virtual Game Game { get; set; }

        // Assuming an Edition can have multiple DLCs bundled with it
        public virtual ICollection<DLC> DLCs { get; set; }
    }

        public class DLC
    {
        [Key]
        public int DLCId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }

    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        public string Name { get; set; } // E.g., E (Everyone), M (Mature), etc.
        public string Description { get; set; } // Description of the rating
    }

    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GameTag> GameTags { get; set; }
    }



        public class GameTag
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }


}
