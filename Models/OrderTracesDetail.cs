using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
	/// <summary>
	/// 快递信息
	/// </summary>
	[Serializable]
    public class OrderTracesDetail
	{

        public OrderTracesDetail()
        { }

        /// <summary>
        /// 快递信息
        /// </summary>
        public string ShipperCode
        {
            set;
            get;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string ShipperName
        {
            set;
            get;
        }


        /// <summary>
        /// 快递sh
        /// </summary>
        public string AcceptTime
        {
            set;
            get;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string AcceptStation
        {
            set;
            get;
        }
        
	}
}

