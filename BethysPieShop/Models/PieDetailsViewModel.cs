namespace BethysPieShop.Models;

public record PieDetailsViewModel(string Name, string? ImageUrl, string? ShortDescription, string? LongDescription, decimal Price);