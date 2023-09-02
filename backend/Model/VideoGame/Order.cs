using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using backend.Model.Auth;

namespace backend.Model
{
    public class Order 
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Range(0, double.MaxValue)] 
        public double TotalPrice { get; set; }

        public virtual ICollection<OrderItem>? OrderItems { get; set; }

        [StringLength(450)]  
        public string? ApplicationUserId { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
