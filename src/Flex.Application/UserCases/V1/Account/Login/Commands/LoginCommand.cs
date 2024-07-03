using Flex.Application.UserCases.V1.Account.Login.DTOs;
using Flex.Contract.Abstractions.Message;

namespace Flex.Application.UserCases.V1.Account.Login.Commands
{
    public class LoginCommand : ICommand<LoginResponse>
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}