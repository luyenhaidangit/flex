using System.Security.Claims;

namespace Flex.Application.Abstractions.Authentication
{
    public interface IJwtTokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
