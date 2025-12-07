using Microsoft.AspNetCore.Mvc;
using Calculatrice.Services;

namespace Calculatrice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController(CalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        // GET: api/calculator/add?a=5&b=7
        [HttpGet("add")]
        public IActionResult Add([FromQuery] int a, [FromQuery] int b)
        {
            int result = _calculatorService.Add(a, b);
            return Ok(new { a, b, result });
        }
    }
}
