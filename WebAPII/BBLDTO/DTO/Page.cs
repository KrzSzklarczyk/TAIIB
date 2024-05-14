using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO
{
    public class Page
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool FilterByName { get; set; }
        public bool FilterByActivated { get; set; }
        public bool Descending { get; set; }
        public string? SortBy { get; set; }
    }
}
