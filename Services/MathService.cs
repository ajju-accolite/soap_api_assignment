using soap_api_calc.Models;

namespace soap_api_calc.Services
{
    public class MathService : IMathService
    {
        public double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
        public double Subtract(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        public double Divide(double operand1, double operand2)
        {
            if (operand2 == 0)
                throw new System.DivideByZeroException("Cannot divide by zero.");

            return operand1 / operand2;
        }
        public double Multiply(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }
}
