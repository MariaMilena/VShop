namespace VShop.ProductApi.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }

    // Uma categoria pode possuir vários produtos
    public ICollection<Product>? Products { get; set;} 
}
