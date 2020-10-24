using System;
namespace Hangjing.Model
{
	/// <summary>
	/// 实体类Record 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class RecordInfo
	{
		private int _rid;
		private string _startstate;
		private string _endstate;
		private string _adminname;
		private DateTime _addtime;
		private int _reve1;
		private string _reve2;
		/// <summary>
		/// 
		/// </summary>
		public int rid
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
        /// 开始价格（昨天价格）
		/// </summary>
		public string startstate
		{
			set{ _startstate=value;}
			get{return _startstate;}
		}
		/// <summary>
        /// 今天涨多少
		/// </summary>
		public string endstate
		{
			set{ _endstate=value;}
			get{return _endstate;}
		}
		/// <summary>
		/// 记录备注
		/// </summary>
		public string adminname
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
        /// <summary>
        /// 类型，1系统调整价格
        /// </summary>
        public int Reve1
        {
            set { _reve1 = value; }
            get { return _reve1; }
        }
        /// <summary>
        /// 增加" + addusercount + "用户
        /// </summary>
        public string Reve2
        {
            set { _reve2 = value; }
            get { return _reve2; }
        }

        private string _orderid;
        /// <summary>
        /// 订单编号
        /// </summary>
        public string orderid
        {
            get { return _orderid; }
            set { _orderid = value; }
        }

	}
}

