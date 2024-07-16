using Flex.Contract.Abstractions.Message;
using Flex.Contract.Abstractions.Shared;

namespace Flex.Application.CorporateAction.ApproveCamast
{
    /// <summary>
    /// Duyệt bản ghi Camast.
    /// Trạng thái N Duyệt
    /// </summary>
    public class ApproveCamastCommandHandler : ICommandHandler<ApproveCamastCommand>
    {
        public Task<Result> Handle(ApproveCamastCommand request, CancellationToken cancellationToken)
        {
            // Tạo Camast

            throw new NotImplementedException();
        }
    }
}
