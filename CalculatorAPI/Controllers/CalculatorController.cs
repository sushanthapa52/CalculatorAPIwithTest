
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
        return _calculatorService.Subtract(number1,number2);
    }
    [HttpGet("multiply")]
    public decimal Multiply(decimal number1, decimal number2)
    {
        return _calculatorService.Multiply(number1, number2);
    }
    [HttpGet("divide")]
    public decimal Divide(decimal number1, decimal number2)
    {
        return _calculatorService.Divide(number1, number2);

    }
    [HttpGet("modulo")]
    public decimal Modulo(decimal number1, decimal number2)
    {
        return _calculatorService.Modulo(number1, number2);

    }
}
