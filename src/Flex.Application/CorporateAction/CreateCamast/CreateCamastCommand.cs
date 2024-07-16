using Flex.Contract.Abstractions.Message;

namespace Flex.Application.CorporateAction.CreateCamast
{
    public sealed record ApproveCamastCommand : ICommand
    {
        public string CamastId { get; set; }

        public DateTime ReportDate { get; set; } 
    }
}