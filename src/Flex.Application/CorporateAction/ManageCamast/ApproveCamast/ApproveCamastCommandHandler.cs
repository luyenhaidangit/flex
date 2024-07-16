using Flex.Contract.Abstractions.Message;
using Flex.Contract.Abstractions.Shared;

namespace Flex.Application.CorporateAction.ManageCamast.Commands.ApproveCamast
{
    /// <summary>
    /// Duyệt bản ghi Camast.
    /// Trạng thái N Duyệt
    /// </summary>
    public class ApproveCamastCommandHandler : ICommandHandler<ApproveCamastCommand>
    {
        public Task<Result> Handle(ApproveCamastCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
