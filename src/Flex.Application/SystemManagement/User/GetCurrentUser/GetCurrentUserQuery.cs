using Flex.Domain.Common.Message;

namespace Flex.Application.SystemManagement.User.GetCurrentUser
{
    public sealed record GetCurrentUserQuery() : IQuery<CurrentUserDto>;
}