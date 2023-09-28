using BethysPieShop.Domain.Entities;
using BethysPieShop.Domain.Repositories;
using BethysPieShop.Domain.Services.Interfaces;

namespace BethysPieShop.Domain.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await _categoryRepository.GetAll();
    }
}