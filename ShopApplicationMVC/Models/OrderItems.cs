using System;
using System.ComponentModel.DataAnnotations;

namespace ShopApplicationMVC.Models
{
    public class OrderItems
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int OrderDetailsId { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }
    }
}
