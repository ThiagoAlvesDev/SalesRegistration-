using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using SalesWebMVC.Models.ViewModels;
using SalesWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordsController : Controller
    {

        private readonly SalesRecordService _salesRecordsService;
        private readonly SellerService _sellerService;

        public SalesRecordsController(SalesRecordService salesRecordsService, SellerService sellerService)
        {
            _salesRecordsService = salesRecordsService;
            _sellerService = sellerService;
        }

        public IActionResult Index()

        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _salesRecordsService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _salesRecordsService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }


        public async Task<IActionResult> Create()
        {
            List<Seller> sellers = await _sellerService.FindAllAsync();
            List<string> status = Enum.GetNames(typeof(SalesStatus)).ToList();
            var viewModel = new SalesFormViewModels { Sellers = sellers, SalesStatuses = status };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SalesRecords sales)
        {
            if (!ModelState.IsValid)
            {
                List<Seller> sellers = await _sellerService.FindAllAsync();
                List<string> status = Enum.GetNames(typeof(SalesStatus)).ToList();
                var viewModel = new SalesFormViewModels { Sales = sales, Sellers = sellers, SalesStatuses = status };
                return View(viewModel);
            }

            await _salesRecordsService.InsertAsync(sales);

            return Redirect(nameof(Index));
        }
    }
}
