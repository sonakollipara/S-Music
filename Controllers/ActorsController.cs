using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smusic.Data;
using Smusic.Data.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Smusic.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        // GET: ActorsController
        public async Task<ActionResult> Index()
        {
            var allActors = await _service.GetAll();
            return View(allActors);
        }

        // GET: ActorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActorsController/Create
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

        // GET: ActorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActorsController/Edit/5
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

        // GET: ActorsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActorsController/Delete/5
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
