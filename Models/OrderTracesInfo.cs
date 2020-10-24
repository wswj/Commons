using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// ʵ����OrderTracesInfo ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

