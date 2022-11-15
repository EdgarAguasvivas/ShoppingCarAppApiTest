using AutoMapper;
using ShoppingCarApp.Bussines.Dtos;
using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Profiles
{
    public class CutomerProfile : Profile
    {
        public CutomerProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}