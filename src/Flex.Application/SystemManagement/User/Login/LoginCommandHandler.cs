using System.Security.Claims;
using Flex.Domain.Common.Message;
using Flex.Domain.Common.Authentication;
using Flex.Domain.SystemManagement.User.Abstractions;
using Flex.Domain.Common.Response;

namespace Flex.Application.SystemManagement.User.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginResponse>
    {
        private readonly ITlProfilesRepository _tlProfilesRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenService _tokenService;

        public LoginCommandHandler(ITlProfilesRepository tlProfilesRepository, IPasswordHasher passwordHasher, ITokenService tokenService)
        {
            _tlProfilesRepository = tlProfilesRepository;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
        }

        public async Task<Result<LoginResponse>> Handle(LoginCommand command, CancellationToken cancellationToken)
        {
            var user = await _tlProfilesRepository.FindOneAsync(x => x.TlName.Trim().ToUpper() == command.UserName.Trim().ToUpper());

            if(user is null)
            {
                throw new ArgumentNullException("Tài khoản không tồn tại trong hệ thống!");
            }

            var passwordHash = _passwordHasher.HashPassword(command.Password);

            if (user.Pin != passwordHash)
            {
                throw new ArgumentNullException("Mật khẩu không chính xác!");
            }

            var claims = new List<Claim> 
            {
                new Claim(ClaimKeyConstant.Username,user.TlName)
            };

            var token = _tokenService.GenerateToken(claims);

            var loginResponse = new LoginResponse()
            {
                AccessToken = token
            };

            var result = new Result<LoginResponse>()
            {
                Data = loginResponse,
                Message = MessageConstant.Success,
                Success = true
            };

            return result;
        }
    }
}