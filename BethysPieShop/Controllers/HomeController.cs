using BethysPieShop.Domain.Services.Interfaces;
using BethysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieService _pieService;

        public HomeController(IPieService pieService)
        {
            _pieService = pieService;
        }

        public async Task<IActionResult> Index()
        {
            var pies = await _pieService.GetPiesOfTheWeekAsync();
            var pieViewModels = pies.Select(x => new PieViewModel(x.Name, x.ImageThumbnailUrl, x.Price, x.PieId)).ToList();

            return View(new HomeViewModel(pieViewModels));
        }
    }
}
