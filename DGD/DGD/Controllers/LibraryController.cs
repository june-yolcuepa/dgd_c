﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DGD.Controllers
{
    public class LibraryController : Controller
    {
        // GET: LibraryController
        public IActionResult Index()
        {
            return View();
        }

        // GET: LibraryController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: LibraryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibraryController/Create
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

        // GET: LibraryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LibraryController/Edit/5
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

        // GET: LibraryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LibraryController/Delete/5
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
