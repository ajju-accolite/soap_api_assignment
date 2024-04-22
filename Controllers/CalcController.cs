using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace soap_api_calc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly IMathService service;
        public CalcController()
        {
            service = new MathServiceClient(MathServiceClient.EndpointConfiguration.BasicHttpBinding_IMathService);
        }

        [HttpGet("PerformAddition")]
        public async Task<double> PerformAdditionAsync(double Operand1, double Operand2)
        {
            return await service.AddAsync(Operand1, Operand2);
        }

        [HttpGet("PerformSubtraction")]
        public async Task<double> PerformSubtractionAsync(double Operand1, double Operand2)
        {
            return await service.SubtractAsync(Operand1, Operand2);
        }

        [HttpGet("PerformDivision")]
        public async Task<IActionResult> PerformDivisionAsync(double Operand1, double Operand2)
        {
            if (Operand2 == 0)
            {
                return BadRequest("The divisor cannot be zero.");
            }
            double data = await service.DivideAsync(Operand1, Operand2);
            return Ok(data);
        }

        [HttpGet("PerformMultiplication")]
        public async Task<double> PerformMultiplicationAsync(double Operand1, double Operand2)
        {
            return await service.MultiplyAsync(Operand1, Operand2);
        }       
    }
}
