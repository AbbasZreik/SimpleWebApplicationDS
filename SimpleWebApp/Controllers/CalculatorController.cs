using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Services;
namespace SimpleWebApp.Controllers

    {
        [Route("api/[controller]")]
        [ApiController]
        public class CalculatorController : ControllerBase
        {
            private readonly ICalculatorService _calculatorService;

            public CalculatorController(ICalculatorService calculatorService)
            {
                _calculatorService = calculatorService;
            }

            [HttpGet("add")]
            public IActionResult Add(int a, int b) => Ok(_calculatorService.Add(a, b));

            [HttpGet("subtract")]
            public IActionResult Subtract(int a, int b) => Ok(_calculatorService.Subtract(a, b));

            [HttpGet("multiply")]
            public IActionResult Multiply(int a, int b) => Ok(_calculatorService.Multiply(a, b));

            [HttpGet("divide")]
            public IActionResult Divide(int a, int b)
            {
                try
                {
                    return Ok(_calculatorService.Divide(a, b));
                }
                catch (DivideByZeroException)
                {
                    return BadRequest("Cannot divide by zero.");
                }
            }
        }
    }



