using Flex.Domain.Common.Message;
using Flex.Domain.Common.Response;

namespace Flex.Application.SystemManagement.User.GetCurrentUser
{
    public class GetCurrentUserQueryHandler : IQueryHandler<GetCurrentUserQuery, CurrentUserDto>
    {
        public Task<Result<CurrentUserDto>> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}