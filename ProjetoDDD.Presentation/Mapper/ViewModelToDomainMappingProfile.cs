using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjectDDD.Domain.Entity;
using ProjectDDD.Presentation.ViewModels;

namespace ProjectDDD.Presentation.Mapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<ProductViewModel, Product>();
        }
    }

}