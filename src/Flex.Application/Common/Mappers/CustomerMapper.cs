using AutoMapper;
using Flex.Application.Customer.ManageSemast.GetSemast;

namespace Flex.Application.Common.Mappers
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
        }

        public static IEnumerable<GetSemastResponse> MapToIEnumerableSemastResponse(IEnumerable<dynamic> listObj)
        {
            var res = listObj.Select(item => new GetSemastResponse
            {
                CustodyCd = item.CUSTODYCD,
                AfAcctNo = item.AFACCTNO,
                IdCode = item.IDCODE,
                FullName = item.FULLNAME,
                AcctNo = item.ACCTNO,
                CodeId = item.CODEID,
                CustId = item.CUSTID,
                AcType = item.ACTYPE,
                OpnDate = item.OPNDATE,
                ClsDate = item.CLSDATE,
                LastDate = item.LASTDATE,
                Status = item.STATUS,
                PStatus = item.PSTATUS,
                Trade = item.TRADE,
                IrType = item.IRTYPE,
                IrCd = item.IRCD,
                CostPrice = item.COSTPRICE,
                Mortage = item.MORTAGE,
                Margin = item.MARGIN,
                Netting = item.NETTING,
                Standing = item.STANDING,
                Withdraw = item.WITHDRAW,
                Deposit = item.DEPOSIT,
                Loan = item.LOAN,
                Receiving = item.RECEIVING,
                Blocked = item.BLOCKED,
                Transfer = item.TRANSFER,
                IccfTied = item.ICCFTIED,
                IccfCd = item.ICCFCD,
                CostDt = item.COSTDT
            });

            return res;
        }
    }
}