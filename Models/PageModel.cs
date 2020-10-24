using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangjing.Model
{
    public class PageModel
    {
        public int pageSize { get; set; }

        public int pageIndex { get; set; }

        public string strWhere { get; set; }

        public string orderName { get; set; }

        public int orderType { get; set; }

        public int accountId { get; set; }
    }
}
