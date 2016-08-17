using NumericSequenceCalculator.Models;
using NumericSequenceCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumericSequenceCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(InputNumber input)
        {
            if (ModelState.IsValid)
            {
                var sequenceStrings = new Dictionary<string,string>();
                sequenceStrings.Add("Number Sequence", NumericSequenceGenerator.GenerateNumberSequence((uint)input.Num));
                sequenceStrings.Add("Odd Number Sequence",NumericSequenceGenerator.GenerateOddNumberSequence((uint)input.Num));
                sequenceStrings.Add("Even Number Sequence", NumericSequenceGenerator.GenerateEvenNumberSequence((uint)input.Num));
                sequenceStrings.Add("Encoded Sequence", NumericSequenceGenerator.GenerateEncodedNumberSequence((uint)input.Num));
                sequenceStrings.Add("Fibonacci Sequence",NumericSequenceGenerator.GenerateFibonacciNumberSequence((uint)input.Num));

                ViewData["SequenceStrings"] = sequenceStrings;
            }
            return View(input);
        }

    }
}