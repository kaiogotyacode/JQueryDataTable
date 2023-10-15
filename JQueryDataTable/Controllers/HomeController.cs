using Microsoft.AspNetCore.Mvc;

namespace JQueryDataTable.Controllers
{
    public class HomeController : Controller
    {     public IActionResult Index()
        {
            return View();
        }       

        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Edit()
        {
            return View();
        }
    }
}