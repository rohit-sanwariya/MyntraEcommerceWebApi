 
using System.ComponentModel.DataAnnotations;
 

namespace MyntraEcommerceWebApi.Model;

public class Category
{
    [Key] public int CategoryId { get; set; }

    [Required]
    public required string  CategoryName { get; set; }

    public List<Product>? Products { get; set; }
}
