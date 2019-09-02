using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TiresController : Controller
    {
        public IActionResult Tires()
        {
            var tires = new List<Tire>();
            tires.Add(new Tire
            {
                Name = "TestTire1", 
                Type = "Winter",
                Producer = "Dunlop",
                VMax = 195,
                WarrantyInYears = 3
            });
            tires.Add(new Tire
            {
                Name = "TestTire2",
                Type = "Winter",
                Producer = "Dunlop",
                VMax = 195,
                WarrantyInYears = 3
            });
            tires.Add(new Tire
            {
                Name = "TestTire3",
                Type = "Winter",
                Producer = "Dunlop",
                VMax = 195,
                WarrantyInYears = 3
            });
            return View(tires);
        }

        public IActionResult Manufacturers()
        {
            return View();
        }

    }
}