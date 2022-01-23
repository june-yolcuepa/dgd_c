using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DGD.Controllers
{
    public class Accounting : Controller
    {
        // GET: Accounting
        public ActionResult Index()
        {
            return View();
        }

        // GET: Accounting/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Accounting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accounting/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Accounting/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Accounting/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Accounting/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Accounting/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
