using Flex.Common.Constants;
using Flex.Common.Extensions;
using Flex.Domain.CorporateAction.Entities;
using Flex.Domain.CorporateAction.Enums;

namespace Flex.Application.CorporateAction.GeneralSearch.GetStockDividendCompare
{
    /// <summary>
    /// Lấy danh sách đối chiếu thông tin thực hiện quyền chia cổ tức bằng cổ phiếu.
    /// Danh sách bản ghi thực hiện quyền của từng tài khoản Caschd loại chia cổ tức bằng cổ phiếu.
    /// </summary>
    public class GetStockDividendCompareQueryHandler
    {
        public Task Handle(GetStockDividendCompareQuery request, CancellationToken cancellationToken)
        {
            var queryCamast = new List<Camast>();

            var queryCaschd = new List<Caschd>();

            queryCamast = queryCamast.Where(
                x => x.Catype == CorporateActionType.StockDividend.GetNumericValue().ToString("D3")
                && x.Deltd == IsDeleted.NotDeleted
            ).ToList();

            queryCaschd = queryCaschd.Where(x => x.Deltd == IsDeleted.NotDeleted).ToList();

            var result = queryCamast.Join(
                queryCaschd,
                camast => camast.CamastId,
                caschd => caschd.CamastId,
                (camast, caschd) => new
                {
                    CamastId = camast.CamastId,
                    Catype = camast.Catype,
                    //ReportDate = camast.ReportDate
                }
            );


            throw new NotImplementedException();
        }
    }
}
