using Microsoft.AspNetCore.Mvc;
using System;

namespace YourProject.Controllers
{
    public class InsureeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(InsureeViewModel model)
        {
            decimal quote = 50;

            if (model.Age <= 18)
                quote += 100;
            else if (model.Age >= 19 && model.Age <= 25)
                quote += 50;
            else if (model.Age >= 26)
                quote += 25;

            if (model.CarYear < 2000)
                quote += 25;
            else if (model.CarYear > 2015)
                quote += 25;

            if (model.CarMake == "Porsche")
            {
                quote += 25;

                if (model.CarModel == "911 Carrera")
                    quote += 25;
            }

            quote += model.SpeedingTickets * 10;

            if (model.HasDUI)
                quote += quote * 0.25m;

            if (model.CoverageType == "Full")
                quote += quote * 0.5m;

            model.Quote = quote; // Assign the calculated quote to the model property

            // Save the data to the database or perform other operations

            return RedirectToAction("Admin");
        }

        public IActionResult Admin()
        {
            // Retrieve quotes from the database and pass them to the Admin view
            var quotes = GetQuotesFromDatabase();
            return View(quotes);
        }

        private YourQuoteModel[] GetQuotesFromDatabase()
        {
            // Retrieve quotes from the database and return them as an array of YourQuoteModel objects
            // Implement your database retrieval logic here
            throw new NotImplementedException();
        }
    }
}
