using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smusic.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Smusic.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public AlbumsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;   
        }
        // GET: AlbumsController1
        public async Task<ActionResult> Index()
        {
            var allAlbums =await _dbContext.Albums.ToListAsync();
            return View(allAlbums);
        }

        // GET: AlbumsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlbumsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlbumsController1/Create
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

        // GET: AlbumsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlbumsController1/Edit/5
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

        // GET: AlbumsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlbumsController1/Delete/5
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
