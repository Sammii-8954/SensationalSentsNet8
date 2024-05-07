using BankApplication.Data;
using SensationalScentsWeb.Contracts;
using SensationalScentsWeb.Data;

namespace SensationalScentsWeb.Repositories
{
    public class ProductTypeRepository : GenericRepository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
