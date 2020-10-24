using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
	/// <summary>
	/// 商品分组
	/// </summary>
	[Serializable]
    public class productgroup
	{
        //public IList<ShopDataInfo> sortlist { get; set; }

        public IList<FoodinfoInfo> sortlist { get; set; }

        public string _pic;

        public string pic
        {
            set { _pic = value; }
            get { return _pic; }
        }

        //public string _picure;

        //public string picure
        //{
        //    set { _picure = value; }
        //    get { return _picure; }
        //}
	}
}

