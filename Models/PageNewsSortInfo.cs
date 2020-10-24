using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    public class PageNewsSortInfo
    {
        private int _sortid;
        private string _sortname;
        /// <summary>
        /// 编号（自增）
        /// </summary>
        public int SortID
        {
            set { _sortid = value; }
            get { return _sortid; }
        }
        /// <summary>
        /// 新闻类别
        /// </summary>
        public string SortName
        {
            set { _sortname = value; }
            get { return _sortname; }
        }
    }
}
