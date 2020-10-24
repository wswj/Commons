using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// 通用列表返回对象
    /// </summary>
    public class BaseListResponse<T>
    {
        public BaseListResponse() {

        }

        public BaseListResponse(int totalRecord, int pageIndex, int pageSize, IList<T> listData)
        {
            this.totalRecord = totalRecord;
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
            this.listData = listData;
        }


        /// <summary>
        /// 总记录数
        /// </summary>
        public int totalRecord
        {
            set;
            get;
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        public int pageIndex
        {
            set;
            get;
        }

        /// <summary>
        /// 本页记录数
        /// </summary>
        public int pageSize
        {
            set;
            get;
        }

        /// <summary>
        /// 列表数据
        /// </summary>
        public IList<T> listData
        {
            set;
            get;
        }


    }
}
