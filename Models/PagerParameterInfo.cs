using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangjing.Model
{
    /// <summary>
    /// 排序方式
    /// </summary>
    public enum PagerSortType { ASC, DESC }

    /// <summary>
    /// 分页参数实体
    /// </summary>
    public class PagerParameterInfo
    {
        public PagerParameterInfo()
        {
            PageSize = 20;
            PageNo = 1;
        }
        public PagerParameterInfo(int pageindex, int pagesize)
        {
            PageSize = pagesize;
            PageNo = pageindex;
        }
        public PagerParameterInfo(int pageindex)
        {
            PageSize = 20;
            PageNo = pageindex;
        }
        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get { return PageNo - 1; } }
        /// <summary>
        /// 每页条数
        /// </summary>
        public int PageSize { get; set; }

        public int PageNo { get; set; }
    }

    /// <summary>
    /// 排序规则参数实体
    /// </summary>
    public class SortParameterInfo
    {
        /// <summary>
        /// 排序字段名称
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 排序类型（升序，降序）
        /// </summary>
        public PagerSortType Ascending { get; set; }
    }

    public class SearchModelBase
    {
        public PagerParameterInfo PagerInfo { get; set; }
        public List<SortParameterInfo> SortList { get; set; }
    }

    public class PagerResult<T> where T : class, new()
    {
        public int RowCount { get; set; }
        public List<T> RowList { get; set; }

        public PagerResult()
        {
            RowCount = 0;
            RowList = new List<T>();
        }

        public PagerResult(Tuple<int, List<T>> tuple)
        {
            RowCount = tuple.Item1;
            RowList = tuple.Item2;
        }

        public PagerResult(int allcount,List<T> list)
        {
            RowCount = allcount;
            RowList = list;
        }
    }
}
