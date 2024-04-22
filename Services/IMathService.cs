using soap_api_calc.Models;
using System.ServiceModel;


namespace soap_api_calc.Services
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        double Add(double operand1, double operand2);

        [OperationContract]
        double Subtract(double operand1, double operand2);

        [OperationContract]
        double Divide(double operand1, double operand2);

        [OperationContract]
        double Multiply(double operand1, double operand2);

        
    }

}
