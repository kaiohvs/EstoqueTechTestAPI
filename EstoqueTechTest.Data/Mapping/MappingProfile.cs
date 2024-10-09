using AutoMapper;
using EstoqueTechTest.Domain.DTOs;
using EstoqueTechTest.Domain.Entities;

namespace EstoqueTechTest.Data.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<CreateProductDTO, Product>().ReverseMap();
            CreateMap<UpdateProductDTO, Product>().ReverseMap();
        }
    }
}
