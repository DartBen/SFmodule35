using Microsoft.AspNetCore.Mvc;
using SocialNetwork.ViewModels.Account;
using System.Diagnostics;

namespace SocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View(new MainViewModel());
        }
    }
}
