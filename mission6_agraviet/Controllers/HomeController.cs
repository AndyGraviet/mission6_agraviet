using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission6_agraviet.Models;

namespace mission6_agraviet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieSubmissionContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieSubmissionContext thisContext)
        {
            _logger = logger;
            blahContext = thisContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Baconsale()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = blahContext.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieSubmission submission)
        {
            if (submission.title == null)
            {
                return View();
            }
            else if (submission.director == null)
            {
                return View();
            }
            else if (submission.year == 0)
            {
                return View();
            }
            else if (submission.rating == null)
            {
                return View();
            }
            else
            {
                blahContext.Add(submission);
                blahContext.SaveChanges();
                return View("Confirmation", submission);
            }

        }

        public IActionResult ViewCollection()
        {
            var submissions = blahContext.responses
                .Include(x => x.Category)
                .ToList();
            return View(submissions);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


