namespace CalcLibrary
{
    // logic separated from the controllers
    public class CalculatorLogicService
    {
        public decimal Add(decimal number1, decimal number2)
        {
            decimal addResult  = number1+ number2;
            return addResult;
        }

        public decimal Subtract(decimal number1, decimal number2)
        {
            decimal subractResult = number1 - number2;
            return subractResult;
        }
        public decimal Multiply(decimal number1, decimal number2)
        {
            decimal MulResult = number1 * number2;
            return MulResult;
        }
        public decimal Divide(decimal number1, decimal number2)
        {
            decimal DivResult = number1 / number2;
            return DivResult;
        }
        public decimal Modulo(decimal number1, decimal number2)
        {
            decimal ModResult = number1 % number2;
            return ModResult;
        }
    }
}
