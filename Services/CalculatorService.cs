using CalculatorApi.Models;

namespace CalculatorApi.Services
{
    public class CalculatorService : ICalculatorService
    {
        public CalculatorResponce CalculatorAdd(CalculatorRequest request)
        {
            CalculatorResponce result = new CalculatorResponce() { Result = request.Num1 + request.Num2 };

            return result;
        }

        public CalculatorResponce CalculatorDivide(CalculatorRequest request)
        {
            CalculatorResponce result;

            if (request.Num2 != 0)
            {
                result = new CalculatorResponce() { Result = request.Num1 / request.Num2 };
            }
            else
            {
                result = new CalculatorResponce() { Result = 0 };
            }

            return result;
        }

        public CalculatorResponce CalculatorMultiply(CalculatorRequest request)
        {
            CalculatorResponce result = new CalculatorResponce() { Result = request.Num1 * request.Num2 };

            return result;
        }

        public CalculatorResponce CalculatorSubtract(CalculatorRequest request)
        {
            CalculatorResponce result = new CalculatorResponce() { Result = request.Num1 - request.Num2 };

            return result;
        }
    }
}
