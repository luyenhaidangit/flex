using Flex.Domain.Common.Message;

namespace Flex.Application.SystemManagement.User.Login
{
    public sealed record LoginCommand(string Account, string Password) : ICommand<LoginResponse>;
}