using BethysPieShop.Domain.Services.Interfaces;
using BethysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethysPieShop.Controllers;

public class PieController : Controller
{
    private readonly IPieService _pieService;

    public PieController(IPieService pieService)
    {
        _pieService = pieService;
    }

    public async Task<IActionResult> List()
    {
        var pies = await _pieService.GetAllAsync();

        var viewModels = new PieListViewModel("Cheese cakes", pies.Select(p => new PieViewModel(p.Name, p.ImageThumbnailUrl, p.Price, p.PieId)).ToList());

        return View(viewModels);
    }

    public async Task<IActionResult> Details(int id)
    {
        var pie = await _pieService.GetByIdAsync(id);

        if (pie is null)
            return NotFound();

        var viewModel = new PieDetailsViewModel(pie.Name, pie.ImageUrl, pie.ShortDescription, pie.LongDescription, pie.Price);

        return View(viewModel);
    }
}