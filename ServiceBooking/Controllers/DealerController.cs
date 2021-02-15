using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceBooking.Controllers
{
    public class DealerController : Controller
    {
        // GET: DealerController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: DealerController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DealerController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DealerController1/Create
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

        // GET: DealerController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DealerController1/Edit/5
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

        // GET: DealerController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DealerController1/Delete/5
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
