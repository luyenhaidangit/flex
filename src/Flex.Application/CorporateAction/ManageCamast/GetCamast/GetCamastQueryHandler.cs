using Dapper;
using Flex.Application.Common.Shared;
using Flex.Application.Common.Message;
using Flex.Application.Common.Data;

namespace Flex.Application.CorporateAction.ManageCamast.GetCamast
{
    //public sealed class GetCamastQueryHandler : IQueryHandler<GetCamastQuery, PagingResult<GetCamastResponse>>
    //{
    //    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    //    public GetCamastQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    //    {
    //        _sqlConnectionFactory = sqlConnectionFactory;
    //    }

    //    public async Task<Result<PagingResult<GetCamastResponse>>> Handle(GetCamastQuery request, CancellationToken cancellationToken)
    //    {
    //        using var connection = _sqlConnectionFactory.CreateConnection();

    //        const string sql = """
    //        SELECT CA.ISINCODE ISINCODE, -- Mã Isin
    //               CA.CAMASTID CAMASTID, -- Mã thực hiện quyền
    //               CA.CATYPE CATYPE, -- Loại thực hiện quyền (+)
    //               SBTO.SYMBOL TOSYMBOL, -- Chứng khoán nhận
    //               SB.SYMBOL SYMBOL, -- Chứng khoán chốt
    //               CA.STATUS STATUS, -- Trạng thái (+)
    //               SB2.SBDATE KHQDATE, -- Ngày giao dịch không hưởng quyền
    //               CA.REPORTDATE REPORTDATE, -- Ngày đăng ký cuối cùng
    //               CA.ACTIONDATE ACTIONDATE, -- Ngày thực hiện quyền
    //               NVL (CA.INACTIONDATE, CA.ACTIONDATE) INACTIONDATE, -- Ngày thực hiện dự kiến,
    //               CA.BEGINDATE BEGINDATE, -- Ngày bắt đầu đăng ký quỹ mở/nhận cổ phiếu chuyển đổi
    //               CA.DUEDATE DUEDATE, -- Ngày cuối cùng đăng ký quỹ mở/nhận cổ phiếu chuyển đổi
    //               CA.TRADEDATE TRADEDATE, -- Ngày giao dịch trở lại
    //               CA.FRDATETRANSFER FRDATETRANSFER, -- Ngày bắt đầu chuyển nhượng
    //               CA.TODATETRANSFER TODATETRANSFER, -- Ngày kết thúc chuyển nhượng
    //               CA.DESCRIPTION DESCRIPTION, -- Mô tả
    //               (CASE WHEN CA.PITRATESE = 0 THEN TO_NUMBER (SYS1.VARVALUE)
    //               ELSE TO_NUMBER (CA.PITRATESE)
    //               END) PITRATESE, -- Thuế suất thu nhập cá nhân cổ phiếu (%),
    //               (CASE WHEN CA.PITRATE = 0 THEN TO_NUMBER (SYS2.VARVALUE)
    //               ELSE TO_NUMBER (PITRATE)
    //               END) PITRATE, -- Thuế suất thu nhập cá nhân tiền (%)
    //               CA.PITRATEMETHOD PITRATEMETHOD, -- Phương thức thu thuế (+)
    //               NVL (CASTOTAL.QTTY, 0) QTTY, -- Số lượng chứng khoán đã phân bổ
    //               NVL (CASTOTAL.AMT, 0) AMT, -- Số tiền chốt,
    //               MAKER.TLNAME MAKERID, -- Người khai
    //               APPRV.TLNAME APPRVID, -- Người duyệt
    //               (CASE WHEN CA.STATUS IN ('P') THEN 'Y' ELSE 'N' END) APRALLOW -- Cho phép duyệt
    //        FROM CAMAST CA
    //        JOIN SBSECURITIES SB ON CA.CODEID = SB.CODEID
    //        JOIN SBSECURITIES SBTO ON NVL(CA.TOCODEID, CA.CODEID) = SBTO.CODEID
    //        JOIN SBCURRDATE SB1 ON SB1.SBDATE = CA.REPORTDATE AND SB1.SBTYPE = 'B'
    //        JOIN SBCURRDATE SB2 ON SB2.NUMDAY = SB1.NUMDAY - 2 AND Sb2.SBTYPE = 'B'
    //        JOIN SYSVAR SYS1 ON SYS1.VARNAME = 'PITRATESE'
    //        JOIN SYSVAR SYS2 ON SYS2.VARNAME = 'PITRATE'
    //        LEFT JOIN (SELECT SCAS.CAMASTID,
    //                          -- ISSE: Đã phân bổ chứng khoán?
    //                          SUM(CASE WHEN SCAS.ISSE = 'Y' THEN SCAS.QTTY ELSE 0 END) QTTY,
    //                          -- ISCI: Đã phân bổ tiền?
    //                          SUM(CASE WHEN SCAS.ISCI = 'Y' THEN SCAS.AMT ELSE 0 END) AMT,
    //                          -- SC: Phương thức thanh toán tại công ty chứng khoán
    //                          -- Thanh toán tại công ty chứng khoán tính tiền thuế thu nhập cá nhân
    //                          -- Không phân bổ tiền hoặc không phải đóng VAT không phải đóng thuế
    //                          -- Nếu quyền trả gốc và lãi trái phiếu thì lấy * INTAMT nợ lãi
    //                          SUM(CASE WHEN SCAS.PITRATEMETHOD != 'SC' AND (SCAS.PITRATEMETHOD != '##' OR SCAM.PITRATEMETHOD != 'SC') THEN 0
    //                                WHEN SCAS.ISCI != 'Y' OR SCF.VAT != 'Y' THEN 0
    //                                ELSE ROUND((SCAM.PITRATE/100) * (CASE WHEN SCAM.CATYPE = '016' THEN SCAS.INTAMT ELSE SCAS.AMT END))
    //                                END) TAXAMT
    //                   FROM CASCHD SCAS
    //                   JOIN CAMAST SCAM ON SCAS.CAMASTID = SCAM.CAMASTID
    //                   JOIN AFMAST SAF ON SCAS.AFACCTNO = SAF.ACCTNO
    //                   JOIN CFMAST SCF ON SCF.CUSTID = SAF.CUSTID
    //                   WHERE SCAM.DELTD = 'N' AND SCAM.DELTD = 'N'
    //                   GROUP BY SCAS.CAMASTID) CASTOTAL ON CA.CAMASTID = CASTOTAL.CAMASTID
    //        LEFT JOIN TLPROFILES MAKER ON CA.MAKERID = MAKER.TLID
    //        LEFT JOIN TLPROFILES APPRV ON CA.APPRVID = APPRV.TLID
    //        """;

    //        var queryResult = await connection.QueryAsync(sql);

    //        var camasts = CorporateActionMapper.MapToIEnumerableCamastResponse(queryResult);

    //        var result = PagingResult<GetCamastResponse>.Create(camasts,1,10,800);

    //        var result1 = new Result<PagingResult<GetCamastResponse>>
    //        {
    //            Data = result,
    //            Success = true,
    //            Message = "ok"
    //        };

    //        return result1;
    //    }
    //}
}