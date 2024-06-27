using Flex.Contract.Abstractions.Message;

namespace Flex.Contract.Services.V1.Account.Login
{
    public static class Command
    {
        public record Revoke(string AccessToken) : ICommand;
    }
}
