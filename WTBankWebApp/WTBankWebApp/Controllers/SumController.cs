using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonetaryService.Abstractions;
using WTBankWebApp.ViewModels;

namespace WTBankWebApp.Controllers
{
    public class SumController : Controller
    {
        IRomanNumeralService _romanNumeralService;

        public SumController(IRomanNumeralService romanNumeralService)
        {
            _romanNumeralService = romanNumeralService;
        }

        [HttpGet]
        public IActionResult Index(SumRomanViewModel vm)
        {
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(SumRomanViewModel vm)
        {
            int RomanNumeralNumericValue1 = _romanNumeralService.ConvertRomanToNumeric(vm.RomanNumeral1);
            int RomanNumeralNumericValue2 = _romanNumeralService.ConvertRomanToNumeric(vm.RomanNumeral2);

            string sumRomanNumeral = 
                _romanNumeralService.ConvertNumericToRoman(RomanNumeralNumericValue1 + RomanNumeralNumericValue2);

            vm.SumRomanNumerals = sumRomanNumeral;

            return RedirectToAction("Index", "Sum", vm);
        }
    }
}