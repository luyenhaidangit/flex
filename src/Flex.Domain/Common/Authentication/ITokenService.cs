using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Flex.Domain.Common.Authentication
{
    public interface ITokenService
    {
        string GenerateToken(List<Claim> claims);
    }
}