using CalculatorApi.Models;

namespace CalculatorApi.Services
{
    public interface IAuthorizationService
    {
        string AuthorizationToken(AutenticationRequest autenticationRequest);
    }
}
