using System;
namespace Hangjing.Model
{
	/// <summary>
    /// 外卖商家分类
	/// </summary>
    public class shopsortInfo
	{
		private int _id;
		private string _classname;
		private int _depth;
		private int _status;
		private int _priority;
		private int _parentid;
		private int _isdel;
        private string _pic;

        /// <summary>
        /// 图片
        /// </summary>
        public string pic
        {
            set { _pic = value; }
            get { return _pic; }
        }
		/// <summary>
        /// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string classname
		{
			set{ _classname=value;}
			get{return _classname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Depth
		{
			set{ _depth=value;}
			get{return _depth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Priority
		{
			set{ _priority=value;}
			get{return _priority;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Parentid
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int isDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
	}
}

