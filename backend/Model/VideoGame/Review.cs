using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model
{
    public class Review
    {

        [Key]
        public int ReviewId { get; set; }

        [Required]
        [MaxLength(100)] 
        public string? Author { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [MaxLength(1000)] 
        public string? Content { get; set; }

        [Range(1, 5)] 
        public double Rating { get; set; } 

        [Required]
        public int GameId { get; set; } 
        
        public virtual Game? Game { get; set; }
            
    }
}