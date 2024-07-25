using Dapper;
using Flex.Application.Common.Data;
using Flex.Application.Common.Message;
using Flex.Application.Common.Mappers;
using Flex.Application.Common.Shared;
using Flex.Infrastructure.Data.Helpers;

namespace Flex.Application.Customer.ManageSemast.GetSemast
{
    public class GetSemastQueryHandler : IQueryHandler<GetSemastQuery, PagingResult<GetSemastResponse>>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public GetSemastQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<Result<PagingResult<GetSemastResponse>>> Handle(GetSemastQuery request, CancellationToken cancellationToken)
        {
            using var connection = _sqlConnectionFactory.CreateConnection();

            var queryParameters = new
            {
                SemastId = request.request.SemastId,
                AfAccTno = request.request.AfAccTno,
                CustodyCd = request.request.CustodyCd,
                SymBol = request.request.SymBol,
                Status = request.request.Status,
                OrderBy = request.request.OrderBy,
                SortBy = request.request.SortBy,
                Offset = request.request.PageIndex,
                PageSize = request.request.PageSize,
            };

            string baseQuery = $"""
            SELECT CF.CUSTODYCD CUSTODYCD, -- Số tài khoản lưu ký -- Nhiều tiểu khoản
                   AF.ACCTNO AFACCTNO, -- Số tiểu khoản -- Nhiều chứng khoán
                   SE.ACCTNO ACCTNO, -- Số tiểu khoản chứng khoán -- Duy nhất
                   CF.IDCODE IDCODE, -- Chứng minh nhân dân
                   CF.FULLNAME FULLNAME,
                   AF.ACTYPE ACTYPE, -- Mã loại hình
                   SB.SYMBOL CODEID, -- Mã chứng khoán
                   SE.OPNDATE OPNDATE, -- Ngày mở tài khoản
                   SE.CLSDATE CLSDATE, -- Ngày đóng tài khoản
                   SE.LASTDATE LASTDATE, -- Ngày giao dịch cuối cùng
                   SE.STATUS STATUS, -- Trạng thái
                   SE.PSTATUS PSTATUS, -- Trạng thái trước đó
                   SE.IRTIED IRTIED, -- Loại hình biểu phí
                   SE.ICCFTIED ICCFTIED, -- Loại hình biểu phí??
                   SE.IRCD IRCD, -- Mã biểu phí
                   SE.COSTPRICE COSTPRICE, -- Giá vay
                   SE.TRADE TRADE, -- Số dư giao dịch
                   SE.MORTAGE MORTAGE, -- Số dư phong toả theo deal
                   SE.MARGIN MARGIN, -- Số dư giao dịch margin
                   SE.NETTING NETTING, -- Số dư chờ giao dịch
                   SE.STANDING STANDING, -- Số dư chưa thanh toán
                   SE.WITHDRAW WITHDRAW, -- Số dư chờ rút
                   SE.DEPOSIT DEPOSIT, -- Số dư chờ xác nhận lưu ký
                   SE.TRANSFER TRANSFER, -- Số dư chờ chuyển
                   SE.LOAN LOAN, -- Số dư đi vay
                   AF.CUSTID CUSTID, -- Mã khách hàng
                   SE.COSTDT COSTDT, -- Ngày tính giá vốn
                   SE.BLOCKED BLOCKED, -- Số dư phong toả
                   SE.RECEIVING RECEIVING -- Số dư chờ nhận về
            FROM SEMAST SE
            JOIN SBSECURITIES SB ON SE.CODEID = SB.CODEID
            JOIN AFMAST AF ON SE.AFACCTNO = AF.ACCTNO
            JOIN CFMAST CF ON AF.CUSTID = CF.CUSTID
            WHERE AF.STATUS <> 'C' -- Đóng
            AND SB.SECTYPE <> '004' -- Quyền chọn
            AND SE.TRADE + SE.MORTAGE + SE.MARGIN + SE.NETTING + SE.STANDING + SE.WITHDRAW + SE.DEPOSIT + SE.TRANSFER + SE.LOAN + SE.BLOCKED + SE.RECEIVING > 0
            {(string.IsNullOrEmpty(request.request.SemastId) ? "" : "AND SE.SEMASTID LIKE '%' + @SemastId + '%'")}
            {(string.IsNullOrEmpty(request.request.AfAccTno) ? "" : "AND AF.ACCTNO LIKE '%' + @AfAccTno + '%'")}
            {(string.IsNullOrEmpty(request.request.CustodyCd) ? "" : "AND CF.CUSTODYCD LIKE '%' + @CustodyCd + '%'")}
            {(string.IsNullOrEmpty(request.request.SymBol) ? "" : "AND SB.SYMBOL LIKE '%' + @SymBol + '%'")}
            {(string.IsNullOrEmpty(request.request.Status) ? "" : "AND SE.STATUS = @Status")}
            """;

            var countSql = QueryHelper.BuildCountQuery(baseQuery);

            var countResult = await connection.ExecuteScalarAsync<int>(countSql, queryParameters);

            var pagingQuery = $"""
                {baseQuery}
                ORDER BY @OrderBy @SortBy
                OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY
            """;

            var queryResult = await connection.QueryAsync(pagingQuery, queryParameters);

            var camasts = CustomerMapper.MapToIEnumerableSemastResponse(queryResult);

            var result = PagingResult<GetSemastResponse>.Create(camasts, 1, 10, 800);

            var result1 = new Result<PagingResult<GetSemastResponse>>
            {
                Data = result,
                Success = true,
                Message = "ok"
            };

            return result1;
        }
    }
}