﻿using Microsoft.AspNetCore.Identity;
using ShopApplicationMVC.Models;
using System.Collections.Generic;

namespace ShopApplicationMVC.ViewModels
{
    public class RoleEditViewModel
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}
