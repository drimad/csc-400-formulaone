using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class CarsController : Controller
{
    private static List<string> Cars { get; set; } = new()
    {
        "Ferrari", "BMW", "Mercedes"
    };

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Cars = Cars;
        return View();
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        // delete the selected car from Cars
        Cars.RemoveAt(id);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(string newCarName)
    {
        Cars.Add(newCarName);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        // retrieve the car with the specified index
        // send both the id & name of the specified car to the edit form using ViewBag
        return View();
    }

    [HttpPost]
    public IActionResult Edit(int id, string updatedCarName)
    {
        // update the car name of the car of the specified id 
        return RedirectToAction("Index");
    }
}