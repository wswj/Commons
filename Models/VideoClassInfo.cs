#region license
// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// Function :实惠信息分类
// Created by tuhui at 2010-6-22 10:29:01.
// E-Mail: tuhui@ihangjing.com
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
	/// 实惠信息分类Model
	/// </summary>
	[Serializable]
	public class VideoClassInfo
	{
		private int _classid;
		private string _parentid;
		private string _classname;
		private int? _classorder;

        public VideoClassInfo()
		{}

        public VideoClassInfo(int classid, string parentid, string classname, int classorder)
        {
            this._classid = classid;
            this._classname = classname;
            this._classorder = classorder;
            this._parentid = parentid;
        }

        private IList<VideofitInfo> _videolist;

        private int _totalfitcount;

        /// <summary>
        /// 每个分类里面的详细视频个数
        /// </summary>
        public int totalfitcount
        {
            set { _totalfitcount = value; }
            get { return _totalfitcount; }
        }

        private string _classTitle;
        /// <summary>
        /// 详细视频分类说明
        /// </summary>
        public string ClassTitle
        {
            set { _classTitle = value; }
            get { return _classTitle; }
        }

        /// <summary>
        /// 视频列表
        /// </summary>
        public IList<VideofitInfo> Videolist
        {
            set { _videolist = value; }
            get { return _videolist; }
        }


		/// <summary>
		/// 类别编号
		/// </summary>
		public int ClassId
		{
			set{ _classid=value;}
			get{return _classid;}
		}

		/// <summary>
		/// 父类编号
		/// </summary>
		public string ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}

		/// <summary>
		/// 类别名称
		/// </summary>
		public string ClassName
		{
			set{ _classname=value;}
			get{return _classname;}
		}

		/// <summary>
		/// 排序
		/// </summary>
		public int? ClassOrder
		{
			set{ _classorder=value;}
			get{return _classorder;}
		}
	}
}
