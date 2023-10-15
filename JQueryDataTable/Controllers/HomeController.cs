using JQueryDataTable.Database;
using JQueryDataTable.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JQueryDataTable.Controllers
{   
    public class HomeController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        public HomeController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<IActionResult> Index()
        {
            
            IEnumerable<People> peoples = await _databaseContext.Peoples.ToListAsync();
                        

            return View(peoples);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]People people)
        {   
            _databaseContext.Peoples.Add(people);
            await _databaseContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}