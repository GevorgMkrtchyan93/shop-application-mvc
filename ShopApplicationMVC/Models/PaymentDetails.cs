using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopApplicationMVC.Models
{
    public class PaymentDetails
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
