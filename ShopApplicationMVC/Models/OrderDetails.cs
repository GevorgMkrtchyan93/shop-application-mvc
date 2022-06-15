using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopApplicationMVC.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public int Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int PaymentId { get; set; }
        public virtual PaymentDetails PaymentDetails { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
