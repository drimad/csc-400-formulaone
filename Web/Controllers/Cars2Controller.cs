using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class Cars2Controller : Controller
{
    private static List<Car> Cars { get; set; } = new()
    {
        new Car()
        {
            Id = 0,
            Brand = "BMW",
            Model = "X5",
            Year = 2020,
            Price = 120000
        },
        new Car()
        {
            Id = 1,
            Brand = "Porsche",
            Model = "Cayenne",
            Year = 2021,
            Price = 150000
        },
        new Car()
        {
            Id = 2,
            Brand = "Mercedes",
            Model = "GL",
            Year = 2009,
            Price = 50000
        }
    };
}