namespace Flex.Domain.Common.Data
{
    public interface IRepositoryBase<T> where T : class
    {
        /// <summary>
        /// Tìm kiếm và phân trang
        /// Điều kiện tìm kiếm operation searchs nhận các giá trị <see cref="Flex.Common.Constants.OperationType"/>.
        /// </summary>
        Task<(IEnumerable<T>, int)> SearchAndPaginateAsync(Dictionary<string, (string operation, object value)> searchs, int pageIndex, int pageSize, string sortBy, bool ascending);
    }
}