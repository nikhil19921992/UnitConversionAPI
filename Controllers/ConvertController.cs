using Microsoft.AspNetCore.Mvc;
using UnitConversionAPI.Models;
using UnitConversionAPI.Services;

namespace UnitConversionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConvertController : ControllerBase
    {
        private readonly ConversionService _conversionService;

        public ConvertController(ConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        [HttpPost]
        public IActionResult Convert([FromBody] ConversionRequest request)
        {
            try
            {
                var result = _conversionService.Convert(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = ex.Message
                });
            }
        }
    }
}