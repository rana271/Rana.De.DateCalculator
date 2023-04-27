using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rana.De.DateCalculator.Models;
using Rana.De.DateCalculator.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Rana.De.DateCalculator.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IDateCaculatorRepo _dateCaculatorRepo;
        /// <summary>
        /// Controller Dependency Injection
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="dateCaculatorRepo"></param>
        public HomeController(IDateCaculatorRepo dateCaculatorRepo)
        {
            
            _dateCaculatorRepo= dateCaculatorRepo;
        }
      
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Post Reququest return no of Days push into viewBag
        /// </summary>
        /// <param name="SelectedStartDate"></param>
        /// <param name="SelectedEndDate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(string SelectedStartDate,string SelectedEndDate)
        {
            DateCalculatorViewModel model = new DateCalculatorViewModel();
            model.StartDate = SelectedStartDate;
            model.EndDate = SelectedEndDate;
            ViewBag.Result= _dateCaculatorRepo.doDaysCalculate(model);
            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
