

using System.ComponentModel.DataAnnotations;

namespace MyntraEcommerceWebApi.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public required string Email { get; set; }
        
        public required string Password { get; set; }


        public virtual Address? Address { get; set; }
    }
}
