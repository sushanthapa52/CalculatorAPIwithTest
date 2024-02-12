
using Microsoft.AspNetCore.Mvc;
using CalcLibrary; // Adjust this based on your actual namespace


[ApiController]
[Route("api/[controller]/[action]")]
public class CalculatorController : ControllerBase
{
    private readonly CalculatorLogicService _calculatorService;

    public CalculatorController(CalculatorLogicService calculatorService)
    {
        _calculatorService = calculatorService;
    }
    [HttpGet("add")]
    public decimal Add(decimal number1, decimal number2)
    {
        return _calculatorService.Add(number1, number2);

    }

    [HttpGet("subtract")]
    public decimal Subtract(decimal number1, decimal number2)
    {
        decimal subractResult = number1 - number2;
        return subractResult;
    }
    [HttpGet("multiply")]
    public decimal Multiply(decimal number1, decimal number2)
    {
        decimal MulResult = number1 * number2;
        return MulResult;
    }
    [HttpGet("divide")]
    public decimal Divide(decimal number1, decimal number2)
    {
        decimal DivResult = number1 / number2;
        return DivResult;
    }
    [HttpGet("modulo")]
    public decimal Modulo(decimal number1, decimal number2)
    {
        decimal ModResult = number1 % number2;
        return ModResult;
    }
}
