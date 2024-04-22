namespace WebApplication3.Service
{
    using static WebApplication3.Models.CalculatorServiceContract;

    public class CalculatorService : ICalculatorService
    {
        public double addition(double op1, double op2)
        {
            return op1 + op2;
        }

        public double subtraction(double op1, double op2)
        {
            return op1 - op2;
        }

        public double division(double op1, double op2)
        {
            return op1 / op2;
        }

        public double multiplication(double op1, double op2)
        {
            return op1 * op2;
        }
    }
}
