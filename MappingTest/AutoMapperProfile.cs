using AutoMapper;

namespace MappingTest
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            //CreateMap<ProductDto, Product>();
        }
    }
}
