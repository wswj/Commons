using System;
namespace Hangjing.Model
{
	/// <summary>
	/// 用户的交易额度
	/// </summary>
	[Serializable]
	public partial class trade_limit_log
	{
		public trade_limit_log()
		{}
		#region Model
		private int _id;
		private int? _user_id;
		private decimal? _user_limit;
		private DateTime? _c_t;
		private DateTime? _u_t;
		private decimal? _change_limit;
		private int? _source;
		private string _msg;
        private int? _from_user_id;
        /// <summary>
        /// 
        /// </summary>
        public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}

        /// <summary>
        /// 
        /// </summary>
        public int? from_user_id
        {
            set;
            get;
        }

        /// <summary>
        /// 会员编号
        /// </summary>
        public int? user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 用户当前额度
		/// </summary>
		public decimal? user_limit
		{
			set{ _user_limit=value;}
			get{return _user_limit;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? c_t
		{
			set{ _c_t=value;}
			get{return _c_t;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? u_t
		{
			set{ _u_t=value;}
			get{return _u_t;}
		}
		/// <summary>
		/// 变化额度
		/// </summary>
		public decimal? change_limit
		{
			set{ _change_limit=value;}
			get{return _change_limit;}
		}
		/// <summary>
		/// 来源：1，买币得到，2：推荐下线
		/// </summary>
		public int? source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string msg
		{
			set{ _msg=value;}
			get{return _msg;}
		}
		#endregion Model

	}
}

