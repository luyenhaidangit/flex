using AutoMapper;
using Flex.Application.CorporateAction.ManageCamast.GetCamast;

namespace Flex.Application.CorporateAction
{
    public class CorporateActionMapper : Profile
    {
        public CorporateActionMapper()
        {
        }

        public static IEnumerable<GetCamastResponse> MapToIEnumerableCamastResponse(IEnumerable<dynamic> listObj)
        {
            var res = listObj.Select(item => new GetCamastResponse
            {
                IsinCode = item.ISINCODE,
                CamastId = item.CAMASTID,
                CaType = item.CATYPE,
                ToSymbol = item.TOSYMBOL,
                Symbol = item.SYMBOL,
                Status = item.STATUS,
                KhqDate = item.KHQDATE,
                ReportDate = item.REPORTDATE,
                ActionDate = item.ACTIONDATE,
                InActionDate = item.INACTIONDATE,
                BeginDate = item.BEGINDATE,
                DueDate = item.DUEDATE,
                TradeDate = item.TRADEDATE,
                FrDateTransfer = item.FRDATETRANSFER,
                ToDateTransfer = item.TODATETRANSFER,
                Description = item.DESCRIPTION,
                PitRateSe = item.PITRATESE,
                PitRate = item.PITRATE,
                PitRateMethod = item.PITRATEMETHOD,
                Qtty = item.QTTY,
                Amt = item.AMT,
                MakerId = item.MAKERID,
                ApprvId = item.APPRVID,
                AprAllow = item.APRALLOW
            });

            return res;
        }
    }
}
