using Microsoft.AspNetCore.Mvc;

namespace DGD.Models
{
    public class Publisher : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
