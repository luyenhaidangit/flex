using Flex.Application.Abstractions.Authentication;
using Flex.Application.Abstractions.Data;
using Flex.Contract.Abstractions.Message;
using Flex.Contract.Abstractions.Shared;

namespace Flex.Application.UserCases.V1.Account.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginResponse>
    {
        public async Task<Result<LoginResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var response = new LoginResponse()
            {
                AccessToken = "Token"
            };

            return Result.Success(response);
        }
    }
}
