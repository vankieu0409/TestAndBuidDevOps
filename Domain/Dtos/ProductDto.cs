using Domain.Entities;

namespace Domain.Dtos;

public class ProductDto
{
    public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();
    public int Pages { get; set; }
    public int CurrentPage { get; set; }
}