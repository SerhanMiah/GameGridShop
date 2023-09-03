using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Model.Auth;
using System.ComponentModel.DataAnnotations;

namespace backend.Model.VideoGame
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }
        public string UserId { get; set; }
        
        public virtual ApplicationUser User { get; set; }
        
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
