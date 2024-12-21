using Microsoft.AspNetCore.Mvc;

namespace InvenFlow_MVC.Controllers
{
    public class ItemsController : Controller
    {
        // GET: /Items
        public IActionResult Index()
        {
            return View();
        }

        // GET: Items/Welcome
        public string Welcome()
        {
            return "This is the Welcome action method";
        }
    }
}