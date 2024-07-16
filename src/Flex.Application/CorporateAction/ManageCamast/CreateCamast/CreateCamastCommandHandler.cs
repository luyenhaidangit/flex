using Flex.Contract.Abstractions.Message;
using Flex.Contract.Abstractions.Shared;

namespace Flex.Application.CorporateAction.ManageCamast.Commands.CreateCamast
{
    /// <summary>
    /// Thêm bản ghi Camast.
    /// Trạng thái P Chờ duyệt
    /// </summary>
    public class CreateCamastCommandHandler : ICommandHandler<ApproveCamastCommand>
    {
        public Task<Result> Handle(ApproveCamastCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
