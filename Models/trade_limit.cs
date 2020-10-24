using System;
namespace Hangjing.Model
{
	/// <summary>
	/// 用户的交易额度
	/// </summary>
	[Serializable]
	public partial class trade_limit
	{
		public trade_limit()
		{}
		#region Model
		private int _id;
		private int? _user_id;
		private decimal? _user_limit;
		private DateTime? _c_t;
		private DateTime? _u_t;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
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
		#endregion Model

	}
}

