using System.ServiceModel;

namespace WebApplication3.Models
{
    public class CalculatorServiceContract
    {
        [ServiceContract]
        public interface ICalculatorService
        {
            [OperationContract]
            double addition(double op1, double op2);

            [OperationContract]
            double subtraction(double op1, double op2);

            [OperationContract]
            double division(double op1, double op2);

            [OperationContract]
            double multiplication(double op1, double op2);        }
    }
}
