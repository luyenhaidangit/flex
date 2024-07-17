using Flex.Domain.CorporateAction.Entities;
using Flex.Domain.SecuritiesPortfolio.Entities;

namespace Flex.Application.CorporateAction.ExecuteTransaction.CreateListOwner
{
    /// <summary>
    /// Giao dịch 3325 Tạo danh sách người sở hữu.
    /// Mô tả:
    /// Cập nhật Parvalue Camast giống Sbsecurities.
    /// Xóa danh sách Caschd trước đó bằng cách update Deltd = Y
    /// Lưu thông tin dữ liệu đợt quyền Camast hiện tại
    /// Nếu đợt quyền là Quyền mua, tính toán lưu thông tin optcodeid từ CodeId bảng Sbsecurities
    /// Tính giá trị chứng khoán chờ về: QTTY, AMT, ROUND (cổ phiếu lẻ), AAMT, AQTTTY...với từng loại quyền
    /// Xóa data CASCHDTEMP, lưu thông tin tính toán được (Trường ROUND xác định tiểu khoản có chốt lẻ không) dựa theo TLOG
    /// Lặp danh sách, tính lại giá trị chứng khoán quyền về
    /// Lấy data CASCHDTEMP và giá trị tính lại insert bảng CASCHD, bớt lại tài khoản cuối cùng
    /// KH cuối cùng insert các giá trị còn lại
    /// Không có chứng khoán nào set Camast trạng thái B Không có số dư chứng khoán
    /// </summary>
    public class CreateListOwnerCommandHandler
    {
        public Task Handle(CreateListOwnerRequest request, CancellationToken cancellationToken)
        {
            var queryCamast = new List<Camast>();

            var querySbsecurities = new List<Sbsecurities>();

            // Cập nhật Parvalue Camast giống Sbsecurities
            var camastToUpdate = queryCamast.SingleOrDefault(ca => ca.CamastId == request.CamastId);

            if(camastToUpdate == null)
            {
                throw new Exception();
            }

            var security = querySbsecurities.SingleOrDefault(se => se.CodeId == camastToUpdate.CodeId);

            if (security == null)
            {
                throw new Exception();
            }

            camastToUpdate.Parvalue = security.Parvalue;

            throw new NotImplementedException();
        }
    }
}
