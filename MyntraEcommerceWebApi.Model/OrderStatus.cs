

using System.ComponentModel.DataAnnotations;

namespace MyntraEcommerceWebApi.Model;

public class OrderStatus
{
    [Key]
    public int StatusId { get; set; }

    [Required]
    public required string CategoryName { get; set; }
}
