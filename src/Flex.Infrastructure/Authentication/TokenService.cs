using Flex.Domain.Common.Authentication;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Flex.Infrastructure.Authentication
{
    public class TokenService : ITokenService
    {
        private readonly JwtOption _jwtOption;

        public TokenService(IOptions<JwtOption> jwtOption)
        {
            _jwtOption = jwtOption.Value;
        }

        public JwtSecurityToken GenerateToken(List<Claim> claims)
        {
            //if (_jwtOption.Key is null || _jwtOption.Issuer is null || _jwtOption.Audience is null || _jwtOption.ExpiryMinutes.HasValue)

                return null;
        }
    }
}