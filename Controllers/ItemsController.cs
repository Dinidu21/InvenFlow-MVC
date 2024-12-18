using Microsoft.AspNetCore.Mvc;

namespace InvenFlow_MVC.Controllers;

public class ItemsController : Controller
{
    // GET :/Item
    public IActionResult Index()
    {
        return View();
    }

    // GET : Item/Welcome
    public string Welcome()
    {
        return "This is the Welcome action method";
    }
}