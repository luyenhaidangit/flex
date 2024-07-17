using System.Linq.Expressions;

namespace Flex.Domain.Common.Abstractions.Data
{
    public interface IRepositoryBase<T> where T : class
    {
        /// <summary>
        /// Tìm kiếm và phân trang
        /// Điều kiện tìm kiếm operation searchs nhận các giá trị <see cref="Flex.Common.Constants.OperationType"/>.
        /// </summary>
        Task<(IEnumerable<T>, int)> SearchAndPaginateAsync(Dictionary<string, (string operation, object value)> searchs, int pageIndex, int pageSize, string sortBy, bool ascending);
    }

    /// <summary>
    /// In implementation should be Entity<TKey>
    /// </summary>
    public interface IRepositoryBase<TEntity, in TKey> where TEntity : class
    {
        Task<TEntity> FindByIdAsync(TKey id, CancellationToken cancellationToken = default, params Expression<Func<TEntity, object>>[] includeProperties);

        Task<TEntity> FindSingleAsync(Expression<Func<TEntity, bool>>? predicate = null, CancellationToken cancellationToken = default, params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void RemoveMultiple(List<TEntity> entities);
    }
}
