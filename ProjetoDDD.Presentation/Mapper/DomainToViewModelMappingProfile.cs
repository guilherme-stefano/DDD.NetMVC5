using AutoMapper;
using ProjectDDD.Domain.Entity;
using ProjectDDD.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDDD.Presentation.Mapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}