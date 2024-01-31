using System.ComponentModel.DataAnnotations;
 

namespace MyntraEcommerceWebApi.Model
{
    public class Address
    {

        [Key]
        public int AddressId { get; set; }


        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

       
        public virtual Customer? Customer { get; set; }


    }
}