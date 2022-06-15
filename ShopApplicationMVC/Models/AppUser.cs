using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ShopApplicationMVC.Models
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
