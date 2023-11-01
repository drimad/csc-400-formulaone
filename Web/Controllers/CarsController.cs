using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class CarsController : Controller
{
    public static List<string> Cars { get; set; } = new();

    public CarsController()
    {
        Cars.Add("Ferrari");
        Cars.Add("BMW");
        Cars.Add("Mercedes");
    }

    public IActionResult Index()
    {
        ViewBag.Cars = Cars;
        return View();
    }

    public IActionResult Delete(int id)
    {
        // delete the selected car from Cars
        Cars.RemoveAt(id);
        return RedirectToAction("Index");
    }
}