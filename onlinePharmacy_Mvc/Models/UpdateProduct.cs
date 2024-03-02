using System.ComponentModel.DataAnnotations;

namespace onlinePharmacy_Mvc.Models
{
    public class UpdateProduct
    {
        [Key]
        public Guid ProductID { get; set; }
        public string? ProductName { get; set; }
       
        public string? ProductDescription { get; set; }
        
        public string? ProductCategory { get; set; }
        
        public string? Brand { get; set; }
        
        [Range(0, int.MaxValue)]
        public double? Price { get; set; }
        [Range(0, int.MaxValue)]
        public int? QuantityInStock { get; set; }
        public string? ImageUrl { get; set; }

        public string? SpecialTag { get; set; }
        [Required]
        public IFormFile ImageFile { get; set; }

    }
}
