using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonetaryService.Abstractions;
using WTBankWebApp.ViewModels;

namespace WTBankWebApp.Controllers
{
    public class RomanController : Controller
    {
        IRomanNumeralService _romanNumeralService;

        public RomanController(IRomanNumeralService romanNumeralService)
        {
            _romanNumeralService = romanNumeralService;
        }

        [HttpGet]
        public IActionResult Index(RomanNumeralViewModel vm)
        {
            return View(vm);
        }

        [HttpPost]
        public IActionResult Convert(RomanNumeralViewModel vm)
        {
            string resultRomanNumeral = _romanNumeralService.ConvertNumericToRoman((int) vm.NumericValue);

            vm.RomanNumeralValue = resultRomanNumeral;

            return RedirectToAction("Index", "Roman", vm);
        }
    }
}