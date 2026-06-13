using UnitConversionAPI.Models;

namespace UnitConversionAPI.Services
{
    public class ConversionService
    {
        public ConversionResponse Convert(ConversionRequest request)
        {
            double result = 0;

            if (request.Category.ToLower() == "length")
            {
                if (request.FromUnit.ToLower() == "meter" &&
                    request.ToUnit.ToLower() == "feet")
                {
                    result = request.Value * 3.28084;
                }
                else if (request.FromUnit.ToLower() == "feet" &&
                         request.ToUnit.ToLower() == "meter")
                {
                    result = request.Value / 3.28084;
                }
            }
            else if (request.Category.ToLower() == "weight")
            {
                if (request.FromUnit.ToLower() == "kilogram" &&
                    request.ToUnit.ToLower() == "pound")
                {
                    result = request.Value * 2.20462;
                }
                else if (request.FromUnit.ToLower() == "pound" &&
                         request.ToUnit.ToLower() == "kilogram")
                {
                    result = request.Value / 2.20462;
                }
            }
            else if (request.Category.ToLower() == "temperature")
            {
                if (request.FromUnit.ToLower() == "celsius" &&
                    request.ToUnit.ToLower() == "fahrenheit")
                {
                    result = (request.Value * 9 / 5) + 32;
                }
                else if (request.FromUnit.ToLower() == "fahrenheit" &&
                         request.ToUnit.ToLower() == "celsius")
                {
                    result = (request.Value - 32) * 5 / 9;
                }
            }

            return new ConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedValue = result
            };
        }
    }
}