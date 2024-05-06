using System.ComponentModel.DataAnnotations.Schema;

namespace SensationalScentsWeb.Data.Migrations
{
    public class Product : BaseEntity
    {
        
        public string Name { get; set; }

        [ForeignKey("ProductTypeId")]
        public  ProductType ProductType {get; set; } //reference the product type to  get the relevant values based on type of prodct
        public int ProductTypeId { get; set; }

        public float Cost { get; set; }
    }
}
