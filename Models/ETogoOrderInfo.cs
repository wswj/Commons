using System;
namespace Hangjing.Model
{
	/// <summary>
	/// 实体类ETogoOrder 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ETogoOrderInfo
	{
        public ETogoOrderInfo()
		{}
        private int _dataid;
		private string _orderid;
		private int _userid;
		private string _username;
		private string _tel;
		private string _senttime;
		private string _address;
		private int _state;
        private string _togoid;
		private DateTime _ordertime;
        private decimal _totalprice;
        private DateTime _setstatetime;
        private decimal _currentprice;

        private int _foodcount;
        private int _ordercount;
        private decimal _ordertotal;

        private string _togoname;
        private string _customername;
        private string _togotel;

        private int _paymode;
        private DateTime _paytime;
        private decimal _paymoney;
        private int _paystate;

        private string _rID;
        /// <summary>
        /// 推荐人id
        /// </summary>
        public string rID
        {
            set { _rID = value; }
            get { return _rID; }
        }

        private string _timespan;
        /// <summary>
        /// 计算时间 倒计时领币倒计时
        /// </summary>
        public string timespan
        {
            set { _timespan = value; }
            get { return _timespan; }
        }

        private int _totalstep;
        /// <summary>
        /// 未使用
        /// </summary>
        public int totalstep
        {
            set { _totalstep = value; }
            get { return _totalstep; }
        }

        private decimal _currentstep;
        /// <summary>
        /// 当前任务卷轴已经产出多少
        /// </summary>
        public decimal currentstep
        {
            set { _currentstep = value; }
            get { return _currentstep; }
        }

        private string _lingquspan;
        /// <summary>
        /// 首页赋值领取
        /// </summary>
        public string lingquspan
        {
            set { _lingquspan = value; }
            get { return _lingquspan; }
        }

        private string _Remark;

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _Remark = value; }
            get { return _Remark; }
        }

        /// <summary>
        /// 表示是否为升级赠送的任务（1赠送的，0正常兑换的）
        /// </summary>
        public int paymode
        {
            set { _paymode = value; }
            get { return _paymode; }
        }

        /// <summary>
        /// 卷轴有效结束时间
        /// </summary>
        public DateTime paytime
        {
            set { _paytime = value; }
            get { return _paytime; }
        }

        /// <summary>
        /// 卷轴兑换需要多少个糖果
        /// </summary>
        public decimal paymoney
        {
            set { _paymoney = value; }
            get { return _paymoney; }
        }

        /// <summary>
        /// 卷轴所有效天数
        /// </summary>
        public int paystate
        {
            set { _paystate = value; }
            get { return _paystate; }
        }

        public string TogoTel
        {
            get { return _togotel; }
            set { _togotel = value; }
        }

        /// <summary>
        /// 自增字段
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid;  }
        }

		/// <summary>
		/// 订单编号(当前时间自动生成)
		/// </summary>
		public string OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}

		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}

		/// <summary>
		/// 用户真实名称(收件人)
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}

		/// <summary>
		/// 手机号码
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}

		/// <summary>
		/// 矿机图片
		/// </summary>
		public string SentTime
		{
			set{ _senttime=value;}
            get { return _senttime; }
		}

		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}

		/// <summary>
		/// 可用状态，0表示不可用，1表示可用了(历史任务)。
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}

		/// <summary>
		/// 下订单时间
		/// </summary>
		public DateTime orderTime
		{
			set{ _ordertime=value;}
			get{return _ordertime;}
		}

        /// <summary>
        /// 卷轴总产量
        /// </summary>
        public decimal TotalPrice
        {
            set { _totalprice = value; }
            get { return _totalprice; }
        }

        /// <summary>
        /// 订单统计数目
        /// </summary>
        public int OrderCount
        {
            get { return _ordercount; }
            set { _ordercount = value; }
        }

        /// <summary>
        /// 订单金额统计
        /// </summary>
        public Decimal OrderTotal
        {
            get { return _ordertotal; }
            set { _ordertotal = value; }
        }

        /// <summary>
        /// 下次可领取时间
        /// </summary>
        public DateTime SetStateTime
        {
            get { return _setstatetime; }
            set { _setstatetime = value; }
        }

        /// <summary>
        ///卷轴等级或者编号（手环，初级，中级,高级...）
        /// </summary>
        public string TogoID
        {
            set
            {
                _togoid = value;
            }
            get
            {
                return _togoid;
            }
        }

        /// <summary>
        ///矿机日产量
        /// </summary>
        public decimal Currentprice
        {
            set
            {
                _currentprice = value;
            }
            get
            {
                return _currentprice;
            }
        }

        /// <summary>
        /// 商家名称
        /// 2010-03-15 8:47 by jijunjian
        /// </summary>
        public string TogoName
        {
            set { _togoname = value; }
            get { return _togoname; }
        }

        /// <summary>
        /// 订单包含的菜品数目
        /// </summary>
        public int FoodCount
        {
            get { return _foodcount; }
            set { _foodcount = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string CustomerName
        {
            get { return _customername; }
            set { _customername = value; }
        }

        private decimal _acountpay;
        /// <summary>
        /// 活跃度
        /// </summary>
        public decimal acountpay
        {
            get { return _acountpay; }
            set { _acountpay = value; }
        }

	}
}

