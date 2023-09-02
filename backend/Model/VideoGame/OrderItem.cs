using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Model
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Range(0, double.MaxValue)]  
        public double UnitPrice { get; set; }

        [Required]
        public int GameId { get; set; }

        public virtual Game? Game { get; set; }

        [Required]
        public int OrderId { get; set; }

        public virtual Order? Order { get; set; }
    }
}
