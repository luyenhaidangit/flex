using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Flex.Domain.Common.Authentication;

namespace Flex.Infrastructure.Authentication
{
    public class TokenService : ITokenService
    {
        private readonly JwtOption _jwtOption;

        public TokenService(IOptions<JwtOption> jwtOption)
        {
            _jwtOption = jwtOption.Value;
        }

        public string GenerateToken(List<Claim> claims)
        {
            var issuer = _jwtOption.Issuer;
            var audience = _jwtOption.Audience;
            var creds = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtOption.Key)), SecurityAlgorithms.HmacSha256);
            var expires = DateTime.UtcNow.AddMinutes(_jwtOption.ExpiryMinutes);

            var token = new JwtSecurityToken(
               issuer: issuer,
               audience: audience,
               expires: expires,
               signingCredentials: creds,
               claims: claims
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenString;
        }
    }
}