using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MappingTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Post(List<ProductDto> prdctDto)
        {
            //Product product = new()
            //{ 
            //Name = prdctDto.Name,
            //UnitPrice = prdctDto.UnitPrice,
            //};
            List<Product> productList = _mapper.Map<List<ProductDto>, List<Product>>(prdctDto);
            return Ok(productList);
        }
    }
}
