using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DailyJournalApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : Controller
    {
        // GET: EntryController/Details/5
        public ActionResult Index(int id)
        {
            return View();
        }

        // POST: EntryController/Create
        [HttpPost("entry")]
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
    }
}
