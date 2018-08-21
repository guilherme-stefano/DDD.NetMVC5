using ProjectDDD.App.Interface;
using ProjectDDD.Domain.Entity;
using ProjectDDD.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.App
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _ProductService;
        public ProductAppService(IProductService ProductService) : base(ProductService)
        {
            this._ProductService = ProductService;
        }
    }
}


