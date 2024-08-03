using Flex.Domain.Common.Message;
using Flex.Domain.Common.Shared;
using Flex.Domain.Common.Abstractions.Services;
using Flex.Domain.SystemManagement.User.Abstractions;

namespace Flex.Application.SystemManagement.User.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginResponse>
    {
        private readonly ITlProfilesRepository _tlProfilesRepository;
        private readonly IPasswordHasher _passwordHasher;

        public LoginCommandHandler(ITlProfilesRepository tlProfilesRepository, IPasswordHasher passwordHasher)
        {
            _tlProfilesRepository = tlProfilesRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<Result<LoginResponse>> Handle(LoginCommand command, CancellationToken cancellationToken)
        {
            var user = await _tlProfilesRepository.FindOneAsync(x => x.TlName == command.Account);

            if(user is null)
            {
                throw new ArgumentNullException("Tài khoản không tồn tại trong hệ thống!");
            }

            var passwordHash = _passwordHasher.HashPassword(command.Password);

            if (user.Pin != passwordHash)
            {
                throw new ArgumentNullException("Mật khẩu không chính xác!");
            }

            var loginResponse = new LoginResponse()
            {
                AccessToken = user.Pin
            };

            var result = new Result<LoginResponse>()
            {
                Data = loginResponse,
                Message = "Done",
                Success = true
            };

            return result;
        }
    }
}