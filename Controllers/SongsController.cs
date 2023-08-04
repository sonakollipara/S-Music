using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smusic.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Smusic.Controllers
{
    public class SongsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public SongsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;           
        }
        // GET: SongsController1
        public async Task<ActionResult> Index()
        {
            var allSongs = await _dbContext.Songs.ToListAsync();
            return View(allSongs);
        }

        // GET: SongsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SongsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SongsController1/Create
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

        // GET: SongsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SongsController1/Edit/5
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

        // GET: SongsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SongsController1/Delete/5
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
