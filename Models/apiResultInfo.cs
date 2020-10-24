using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// api接口返回数据
    /// </summary>
    public class apiResultInfo
    {
        /// <summary>
        /// 状态，1表示正常，其他表示失败,  100 无
        /// </summary>
        public int state
        {
            set;
            get;
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        public string msg
        {
            set;
            get;
        }
        /// <summary>
        /// 提示信息
        /// </summary>
        public string msgfix
        {
            set;
            get;
        }

        public object data
        {
            set;
            get;
        }
    }
}
