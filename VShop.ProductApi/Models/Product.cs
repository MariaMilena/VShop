namespace VShop.ProductApi.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public long Stock { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }

    // Um produto está relacionado a uma categoria 
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
}
