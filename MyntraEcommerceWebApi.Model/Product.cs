

using System.ComponentModel.DataAnnotations;

namespace MyntraEcommerceWebApi.Model;

public class Product
{
    [Key] public int ProductId { get; set; }

    [Required]
    public required  string ProductName { get; set; }


    public string ProductDesciption { get; set; } = string.Empty;

    [Required]
    public decimal Price { get; set; }

    public int StockQuantity { get; set; } = 0;

    public  List<Category>? Category { get; set; }
}
