using System.Linq;
using System.Web.Mvc;
using livraria.DAL;

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
		public ActionResult Contact()
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
