using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using livraria.DAL;
using livraria.Models;

namespace livraria.Controllers
{
    public class PageController : Controller
    {
        private LivroContext db = new LivroContext();

        // GET: Page
        public ActionResult Index()
        {
            return View(db.Livros.ToList());
        }

        // GET: Page/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.LivroId = id;
            return View();
        }

        // GET: Page/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Page/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LivroId = id;
            return View();
        }

        // GET: Page/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LivroId = id;
            return View();
        }
    }
}
