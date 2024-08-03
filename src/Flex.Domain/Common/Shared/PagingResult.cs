namespace Flex.Domain.Common.Shared
{
    public class PagingResult<T>
    {
        private PagingResult(IEnumerable<T> items, int pageIndex, int pageSize, int totalCount)
        {
            Items = items;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
        }

        public IEnumerable<T> Items { get; }
        public int PageIndex { get; }
        public int PageSize { get; }
        public int TotalCount { get; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public bool HasNextPage => PageIndex * PageSize < TotalCount;
        public bool HasPreviousPage => PageIndex > 1;

        public static PagingResult<T> Create(IEnumerable<T> items, int pageIndex, int pageSize, int totalCount)
        {
            return new PagingResult<T>(items, pageIndex, pageSize, totalCount);
        }
    }
}