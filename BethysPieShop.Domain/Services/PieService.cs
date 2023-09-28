using BethysPieShop.Domain.Entities;
using BethysPieShop.Domain.Repositories;
using BethysPieShop.Domain.Services.Interfaces;

namespace BethysPieShop.Domain.Services;

public class PieService : IPieService
{
    private readonly IPieRepository _pieRepository;

    public PieService(IPieRepository pieRepository)
    {
        _pieRepository = pieRepository;
    }

    public async Task<List<Pie>> GetAllAsync()
    {
        return await _pieRepository.GetAllAsync();
    }

    public async Task<Pie?> GetByIdAsync(int pieId)
    {
        return await _pieRepository.GetByIdAsync(pieId);
    }

    public async Task<List<Pie>> GetPiesOfTheWeekAsync()
    {
        var pies = await _pieRepository.GetPiesOfTheWeekAsync();
        return pies ?? new List<Pie>();
    }

    public async Task<List<Pie>?> SearchAsync(string query)
    {
        return await _pieRepository.SearchAsync(query);
    }
}