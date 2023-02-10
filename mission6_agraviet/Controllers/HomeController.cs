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
            if (ModelState.IsValid)
            {
                blahContext.Add(submission);
                blahContext.SaveChanges();
                return View("Confirmation", submission);
            } else
            {
                ViewBag.Categories = blahContext.categories.ToList();
                return View(submission);
            }
        }

        public IActionResult ViewCollection()
        {
            var submissions = blahContext.responses
                .Include(x => x.Category)
                .ToList();
            return View(submissions);
        }

        [HttpGet]
        public IActionResult Edit(int submissionId)
        {
            ViewBag.Categories = blahContext.categories.ToList();
            var submission = blahContext.responses.Single(x => x.submissionId == submissionId);
            return View("Movies", submission);
        }

        [HttpPost]
        public IActionResult Edit(MovieSubmission blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();

            return RedirectToAction("ViewCollection");
        }


        [HttpGet]
        public IActionResult Delete(int submissionId)
        {
            var submission = blahContext.responses.Single(x => x.submissionId == submissionId);
            
            return View(submission);
        }

        [HttpPost]
        public IActionResult Delete(MovieSubmission submission)
        {
            blahContext.responses.Remove(submission);
            blahContext.SaveChanges();
            return RedirectToAction("ViewCollection");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


