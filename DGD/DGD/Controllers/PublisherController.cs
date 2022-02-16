using Microsoft.AspNetCore.Mvc;

namespace DGD.Controllers
{
    public class PublisherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
