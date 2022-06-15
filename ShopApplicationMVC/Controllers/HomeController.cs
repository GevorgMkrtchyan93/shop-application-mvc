using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopApplicationMVC.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace ShopApplicationMVC.Controllers
{
    [Authorize]   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View(GetData(nameof(Index)));
        }

        [Authorize(Roles = "User")]
        public IActionResult OtherAction()
        {
            return View("Index", GetData(nameof(OtherAction)));
        }

        private Dictionary<string, object> GetData(string actionName)
        {
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>
            {
                ["Action"] = actionName,
                ["User"] = HttpContext.User.Identity.Name,
                ["Authenticated"] = HttpContext.User.Identity.IsAuthenticated,
                ["Auth Type"]= HttpContext.User.Identity.AuthenticationType,
            };

            return keyValuePairs;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
