using BethysPieShop.Domain.Entities;

namespace BethysPieShop.Domain.Services.Interfaces;

public interface ICategoryService
{
    Task<List<Category>> GetAllAsync();
}