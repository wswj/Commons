// EFoodSortInfo：菜品类别实体
// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// add by yangxiaolong@ihangjing.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    public class EFoodSortInfo
    {
        private int _sortid;
        private string _sortname;
        private int _jorder;
        private string _togoname;
        private string _Picture;
        private int _togonum;
        private IList<FoodinfoInfo> _foodlist;
        private int _Isfree;
        /// <summary>
        /// 菜品类别编号
        /// </summary>
        public int SortID
        {
            set { _sortid = value; }
            get { return _sortid; }
        }

        /// <summary>
        /// 是否显示
        /// </summary>
        public int Isfree
        {
            set { _Isfree = value; }
            get { return _Isfree; }
        }

        /// <summary>
        /// 菜品类别名称
        /// </summary>
        public string SortName
        {
            set { _sortname = value; }
            get { return _sortname; }
        }

        /// <summary>
        /// 菜品类别图片
        /// </summary>
        public string Picture
        {
            set { _Picture = value; }
            get { return _Picture; }
        }

        /// <summary>
        /// 所属商家名称
        /// </summary>
        public string TogoName
        {
            get { return _togoname; }
            set { _togoname = value; }
        }

        /// <summary>
        /// 商家ID
        /// </summary>
        public int TogoNum
        {
            get { return _togonum;  }
            set { _togonum = value; }
        }

        /// <summary>
        /// 排序字段.数字在的排在前
        /// </summary>
        public int Jorder
        {
            get { return _jorder; }
            set { _jorder = value; }
        }

        
        /// <summary>
        /// 菜品列表
        /// </summary>
        public IList<FoodinfoInfo> Foodlist
        {
            set { _foodlist = value; }
            get { return _foodlist; }
        }
    }
}
