using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalLookupAPI.Models
{
    public static class PaginationHelper
    {
        public static IQueryable<Object> GetPaged(IQueryable<Object> genericQuery, int page, int pageSize = 1)
        {
            int TotalCount = genericQuery.Count();
            double pageCount = (int)Math.Ceiling(Convert.ToDouble(TotalCount) / pageSize);
            int Skip = (page - 1) * pageSize;
            IQueryable<Object> Results = (page > 0) ? genericQuery.Skip((page - 1) * pageSize).Take(pageSize) : genericQuery;
            return Results;
        }
    }
}