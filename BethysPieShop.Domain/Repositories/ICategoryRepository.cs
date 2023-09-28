using BethysPieShop.Domain.Entities;

namespace BethysPieShop.Domain.Repositories;

public interface ICategoryRepository
{
    Task<List<Category>> GetAll();
}