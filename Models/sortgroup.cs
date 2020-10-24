using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
	/// <summary>
	/// ·ÖÀà
	/// </summary>
	[Serializable]
    public class sortgroup
	{
        //public IList<ShopDataInfo> sortlist { get; set; }

        public IList<EFoodSortInfo> sortlist { get; set; }

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

