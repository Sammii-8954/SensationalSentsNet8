using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SensationalScentsWeb.Models
{
    public class ProductTypeVM
    {
    public int Id { get; set; }
        [Display(Name = " Flavour ")]
        [Required]
        public string Name { get; set; }

    [Display(Name =" Products ")]
        [Required]
    public string Description { get; set; }

    }
}
