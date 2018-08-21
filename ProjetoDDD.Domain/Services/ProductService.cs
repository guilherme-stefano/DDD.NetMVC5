using ProjectDDD.Domain.Entity;
using ProjectDDD.Domain.Interface.Repository;
using ProjectDDD.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _ProducteRepository;

        public ProductService(IProductRepository ProductRepository)
            : base(ProductRepository)
        {
            _ProducteRepository = ProductRepository;
        }
    }
}
