using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using SoapCore.ServiceModel;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("Calculator")]
    public class Calculator : Controller
    {
        [HttpGet("Addition")]
        public async Task<double> additionAsync(double op1 , double op2)
        {
            ICalculatorService calculatorService = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService);
            return await calculatorService.additionAsync(op1, op2);
        }

        [HttpGet("Subtraction")]
        public async Task<double> subtractionAsync(double op1 , double op2)
        {
            ICalculatorService calculatorService = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService);
            return await calculatorService.subtractionAsync(op1, op2);
        }

        [HttpGet("Division")]
        public async Task<double> divisionAsync(double op1 , double op2)
        {
            ICalculatorService calulatorService = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService);
            return await calulatorService.divisionAsync(op1, op2);
        }

        [HttpGet("Multiplication")]
        public async Task<double> multiplicationAsync(double op1 , double op2)
        {
            ICalculatorService calculatorService = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService);
            return await calculatorService.multiplicationAsync(op1, op2);
        }
    }
}
