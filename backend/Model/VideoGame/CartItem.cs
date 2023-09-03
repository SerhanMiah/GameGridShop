using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace backend.Model.VideoGame
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }

        [Range(1, 10, ErrorMessage = "Quantity must be between 1 and 10.")]
        public int Quantity { get; set; }

        public double UnitPrice { get; set; }
        public int GameId { get; set; }
        
        public virtual Game Game { get; set; }
        
        public int ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
