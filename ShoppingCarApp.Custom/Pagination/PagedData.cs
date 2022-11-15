using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Custom.Pagination
{
    public class PagedData<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public IEnumerable<T> Data { get; set; }


        public bool HasPrevious
        {
            get
            {
                return (CurrentPage > 1);
            }
        }
        public bool HasNext
        {
            get
            {
                return (CurrentPage < TotalPage);
            }
        }
    }

}