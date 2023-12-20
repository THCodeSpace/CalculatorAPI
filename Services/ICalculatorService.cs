using CalculatorApi.Models;

namespace CalculatorApi.Services
{
    public interface ICalculatorService
    {
        CalculatorResponce CalculatorAdd(CalculatorRequest request);
        CalculatorResponce CalculatorDivide(CalculatorRequest request);
        CalculatorResponce CalculatorMultiply(CalculatorRequest request);
        CalculatorResponce CalculatorSubtract(CalculatorRequest request);
    }
}
