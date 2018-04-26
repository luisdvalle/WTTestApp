using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonetaryService.Abstractions;
using WTBankWebApp.ViewModels;

namespace WTBankWebApp.Controllers
{
    public class MonetaryController : Controller
    {
        private IMonetaryService _monetaryService;

        public MonetaryController(IMonetaryService monetaryService)
        {
            _monetaryService = monetaryService;
        }

        [HttpGet]
        public IActionResult Index(MonetaryFigureViewModel vm)
        {
            return View(vm);
        }

        [HttpPost]
        public IActionResult Convert(MonetaryFigureViewModel vm)
        {
            if (vm.NumericValue == null)
            {
                vm.NumericValue = 0.00;
            }

            var result = _monetaryService.ConvertNumericToText((double)vm.NumericValue);

            vm.EnglishTextValue = result;

            return RedirectToAction("Index", "Monetary", vm);
        }
    }
}