using Microsoft.AspNetCore.Mvc;

namespace DGD.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
