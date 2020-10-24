using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
	/// <summary>
	/// �����Ϣ
	/// </summary>
	[Serializable]
    public class OrderTracesDetail
	{

        public OrderTracesDetail()
        { }

        /// <summary>
        /// �����Ϣ
        /// </summary>
        public string ShipperCode
        {
            set;
            get;
        }

        /// <summary>
        /// ����
        /// </summary>
        public string ShipperName
        {
            set;
            get;
        }


        /// <summary>
        /// ���sh
        /// </summary>
        public string AcceptTime
        {
            set;
            get;
        }

        /// <summary>
        /// ����
        /// </summary>
        public string AcceptStation
        {
            set;
            get;
        }
        
	}
}

