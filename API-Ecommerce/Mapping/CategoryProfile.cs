using System;
using API_Ecommerce.Model.Dtos;
using AutoMapper;

namespace API_Ecommerce.Mapping;

public class CategoryProfile: Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
    }
}
