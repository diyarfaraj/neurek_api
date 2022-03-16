using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int curentPage, int totalPages, int itemsPerPage, int totalItems)
        {
            CurentPage = curentPage;
            TotalPages = totalPages;
            ItemsPerPage = itemsPerPage;
            TotalItems = totalItems;
        }

        public int CurentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
    }
}
