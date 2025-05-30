using KooliProjekt.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace  KooliProjekt.Data
{
    public static class PagingExtensions
    {
        public static async Task<PagedResult<T>> GetPagedAsync<T>(this IQueryable<T> query, int page, int pageSize)
        {
            var result = new PagedResult<T>
            {
                Page = page,
                PageSize = pageSize,
                TotalCount = await query.CountAsync(),
                Items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync()
            };
            return result;
        }
    }
}
