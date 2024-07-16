using Flex.Contract.Abstractions.Message;
using Flex.Contract.Abstractions.Shared;

namespace Flex.Application.CorporateAction.CreateCamast
{
    public class CreateCamastCommandHandler : ICommandHandler<CreateCamastCommand>
    {
        public Task<Result> Handle(CreateCamastCommand request, CancellationToken cancellationToken)
        {
            // Tạo Camast

            throw new NotImplementedException();
        }
    }
}
