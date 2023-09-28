using BethysPieShop.Domain.Entities;

namespace BethysPieShop.Domain.Repositories;

public interface IPieRepository
{
    Task<List<Pie>> GetAllAsync();
    Task<List<Pie>?> GetPiesOfTheWeekAsync();
    Task<Pie?> GetByIdAsync(int pieId);
    Task<List<Pie>?> SearchAsync(string query);
}