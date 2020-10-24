using System;
namespace Hangjing.Model
{
	/// <summary>
    /// 实体类publicliveInfo 。(爱心基金信息)
	/// </summary>
    public class publicliveInfo
	{
		private int _dataid;
		private string _picture;
        private decimal _link;
		private string _introduce;
        private int _state;
		private string _title;
        private decimal _width;
        private DateTime _height;

        private decimal _allmoney;
        /// <summary>
        /// 累计捐赠
        /// </summary>
        public decimal allmoney
        {
            set { _allmoney = value; }
            get { return _allmoney; }
        }

		/// <summary>
		/// 自动增长
		/// </summary>
		public int DataId
		{
			set{ _dataid=value;}
			get{return _dataid;}
		}
		/// <summary>
        /// 爱心图片
		/// </summary>
		public string Picture
		{
			set{ _picture=value;}
			get{return _picture;}
		}
		/// <summary>
        /// 爱心捐赠
		/// </summary>
		public decimal Link
		{
			set{ _link=value;}
			get{return _link;}
		}
		/// <summary>
        /// 未用
		/// </summary>
		public string Introduce
		{
			set{ _introduce=value;}
			get{return _introduce;}
		}
		/// <summary>
        ///  累计捐赠多少次
		/// </summary>
        public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
        /// 爱心标题
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		///网购代捐
		/// </summary>
        public decimal Width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 新增时间
		/// </summary>
        public DateTime Height
		{
			set{ _height=value;}
			get{return _height;}
		}
	}
}

