using System.ComponentModel.DataAnnotations;

namespace ShopApplicationMVC.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        [UIHint("email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [UIHint("password")]
        public string Password { get; set; }
    }
}
