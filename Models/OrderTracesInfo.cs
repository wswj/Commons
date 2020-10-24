using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// 实体类OrderTracesInfo 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class OrderTracesInfo
    {
        public OrderTracesInfo()
		{}


        public string EBusinessID
        {
            set;
            get;
        }
        public string LogisticCode
        {
            set;
            get;
        }
        public string Success
        {
            set;
            get;
        }
        public string State
        {
            set;
            get;
        }


       
        private IList<OrderTracesDetail> _Shippers;
        public IList<OrderTracesDetail> Shippers
        {
            get { return _Shippers; }
            set { _Shippers = value; }
        }


        private IList<OrderTracesDetail> _Traces;
        /// <summary>
        /// 
        /// </summary>
        public IList<OrderTracesDetail> Traces
        {
            set { _Traces = value; }
            get { return _Traces; }
        }
       

    }
}

