namespace SensationalScentsWeb.Data
{
    public class ProductType : BaseEntity // This is to model the types of products found on the website.
    {
     
        public string Name { get; set; }
        public string? Description { get; set; }
        
    }
}
