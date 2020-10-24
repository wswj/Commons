using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// 答题库数据库
    /// </summary>
    public class QustionRecordInfo
    {
        private int _ranid;
        private string _orderid;
        private DateTime _adddate;
        private string _contents;
        private string _inve1;
        private string _inve2;
        private string _inve3;
        private string _inve4;

        /// <summary>
        ///  自增编号
        /// </summary>
        public int RanId
        {
            set { _ranid = value; }
            get { return _ranid; }
        }

        /// <summary>
        /// 正确选项
        /// </summary>
        public string OrderId
        {
            set { _orderid = value; }
            get { return _orderid; }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }

        /// <summary>
        /// 问题内容
        /// </summary>
        public string Contents
        {
            set { _contents = value; }
            get { return _contents; }
        }

        /// <summary>
        /// 题目A
        /// </summary>
        public string Inve1
        {
            set { _inve1 = value; }
            get { return _inve1; }
        }

        /// <summary>
        /// 题目B
        /// </summary>
        public string Inve2
        {
            set { _inve2 = value; }
            get { return _inve2; }
        }

        /// <summary>
        ///  题目C
        /// </summary>
        public string Inve3
        {
            set { _inve3 = value; }
            get { return _inve3; }
        }

        /// <summary>
        /// 题目D
        /// </summary>
        public string Inve4
        {
            set { _inve4 = value; }
            get { return _inve4; }
        }
    }
}
