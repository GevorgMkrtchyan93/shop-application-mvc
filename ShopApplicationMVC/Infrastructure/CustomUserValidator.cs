using Microsoft.AspNetCore.Identity;
using ShopApplicationMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplicationMVC.Infrastructure
{
    public class CustomUserValidator : UserValidator<AppUser>
    {
        //public override async Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        //{
        //    var result = await base.ValidateAsync(manager, user);
        //    List<IdentityError> errors = result.Succeeded ?
        //        new List<IdentityError>() : result.Errors.ToList();

        //    if (user.Email.ToLower().EndsWith(".com"))
        //    {
        //        errors.Add(new IdentityError
        //        {
        //            Code = "EmailDomainError",
        //            Description = "Only .com email addresses are allowed"
        //        });
        //    }

        //    return errors.Count == 0 ?
        //       IdentityResult.Success : IdentityResult.Failed(errors.ToArray());
        //}
    }
}
