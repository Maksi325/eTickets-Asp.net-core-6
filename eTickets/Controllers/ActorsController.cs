using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        //Declare AppDbContent
        private readonly AppDbContent _context;

        public ActorsController(AppDbContent context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Actors.ToListAsync();

            return View(data);
        }
    }
}
