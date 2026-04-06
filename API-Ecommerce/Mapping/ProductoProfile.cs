using System;
using API_Ecommerce.Model;
using API_Ecommerce.Model.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace API_Ecommerce.Mapping;

public class ProductoProfile:Profile
{
    public ProductoProfile()
    {
        CreateMap<Product, ProductDto>()
        .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
        .ReverseMap();
        CreateMap<Product, CreateProductDto>().ReverseMap();
        CreateMap<Product, UpdateProductDto>().ReverseMap();
    }
}
