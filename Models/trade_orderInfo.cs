using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// 发布求购及交易订单信息
    /// </summary>
    [Serializable]
    public class trade_orderInfo
    {
        public trade_orderInfo()
        { }
        #region Model
        private string _id;
        private string _userid;
        private string _sham;
        private decimal _amount;
        private int _profit;
        private string _future;
        private string _direction;
        private int _period;
        private DateTime _opentime;
        private decimal _openprice;
        private DateTime _closetime;
        private decimal _closeprice;
        private string _result;
        private int _status;
        private DateTime _millisecond;


        private string _userphone;
        /// <summary>
        /// 用户手机（短信通知应单方）
        /// </summary>
        public string userphone
        {
            set { _userphone = value; }
            get { return _userphone; }
        }

        private string _truename;
        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string truename
        {
            set { _truename = value; }
            get { return _truename; }
        }

        private string _userpicture;
        /// <summary>
        /// 用户头像
        /// </summary>
        public string userpicture
        {
            set { _userpicture = value; }
            get { return _userpicture; }
        }


        private string _adduserpicture;
        /// <summary>
        /// 用户头像
        /// </summary>
        public string adduserPicture
        {
            set { _adduserpicture = value; }
            get { return _adduserpicture; }
        }


        private string _statehtml;
        /// <summary>
        /// 状态栏
        /// </summary>
        public string statehtml
        {
            set { _statehtml = value; }
            get { return _statehtml; }
        }

        private string _yiwancheng;
        /// <summary>
        /// 完成页面赋值
        /// </summary>
        public string yiwancheng
        {
            set { _yiwancheng = value; }
            get { return _yiwancheng; }
        }

        private IList<IntegralInfo> _ItemList;
        /// <summary>
        /// 用户订单对应的用户支付信息
        /// </summary>
        public IList<IntegralInfo> ItemList
        {
            set { _ItemList = value; }
            get { return _ItemList; }
        }

        private string _pagehtml;
        /// <summary>
        /// 赋值用户页面html
        /// </summary>
        public string pagehtml
        {
            set { _pagehtml = value; }
            get { return _pagehtml; }
        }

        private int _adduser;
        /// <summary>
        /// 卖方ID。（应单方，为求购订单时候为购买方，为卖单反之）
        /// </summary>
        public int adduser
        {
            set { _adduser = value; }
            get { return _adduser; }
        }

        private string _useraccode;
        /// <summary>
        /// 用户糖果数量
        /// </summary>
        public string useraccode
        {
            set { _useraccode = value; }
            get { return _useraccode; }
        }

        private string _username;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }

        private string _addusername;
        /// <summary>
        /// 购买方用户名称 （应单方，可以是买单或者卖单）
        /// </summary>
        public string addusername
        {
            set { _addusername = value; }
            get { return _addusername; }
        }
        private string _addtruename;
        /// <summary>
        /// 购买方用户真实名称
        /// </summary>
        public string addtruename
        {
            set { _addtruename = value; }
            get { return _addtruename; }
        }

        private string _adduserphone;
        /// <summary>
        /// 购买方用户真实手机号
        /// </summary>
        public string adduserphone
        {
            set { _adduserphone = value; }
            get { return _adduserphone; }
        }

        private string _buyphone;
        /// <summary>
        /// 购买方电话号码
        /// </summary>
         public string buyphone
        {
            set { _buyphone = value; }
            get { return _buyphone; }
        }
        private string _openid;
        /// <summary>
        /// _openid（唯一编号）
        /// </summary>
        public string openid
        {
            set { _openid = value; }
            get { return _openid; }
        }

        private string _orderid;
        /// <summary>
        /// 订单编号
        /// </summary>
        public string orderid
        {
            set { _orderid = value; }
            get { return _orderid; }
        }

        /// <summary>
        /// 交易随机号
        /// </summary>
        public string id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 用户编号（发布者编号，可为求购 或者卖者编号）
        /// </summary>
        public string userId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 用户手机（发布者）
        /// </summary>
        public string sham
        {
            set { _sham = value; }
            get { return _sham; }
        }
        /// <summary>
        /// 交易当前价格（开启价格同步的每天自动更新的新价格默认为原始单价）
        /// </summary>
        public decimal amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        /// <summary>
        /// 求购数量
        /// </summary>
        public int profit
        {
            set { _profit = value; }
            get { return _profit; }
        }
        /// <summary>
        /// 需要上传的打款凭证(判断是否支付)=future
        /// </summary>
        public string future
        {
            set { _future = value; }
            get { return _future; }
        }
        /// <summary>
        /// 图片信息信息
        /// </summary>
        public string direction
        {
            set { _direction = value; }
            get { return _direction; }
        }
        /// <summary>
        /// 发布信息类型（1是买入，2是卖出 ）
        /// </summary>
        public int period
        {
            set { _period = value; }
            get { return _period; }
        }
        /// <summary>
        /// 交易开始时间
        /// </summary>
        public DateTime openTime
        {
            set { _opentime = value; }
            get { return _opentime; }
        }
        /// <summary>
        ///   求购原始单价
        /// </summary>
        public decimal openPrice
        {
            set { _openprice = value; }
            get { return _openprice; }
        }
        /// <summary>
        /// 交易结束（关闭）时间确认打款时间
        /// </summary>
        public DateTime closeTime
        {
            set { _closetime = value; }
            get { return _closetime; }
        }
        /// <summary>
        ///  最终成交价格
        /// </summary>
        public decimal closePrice
        {
            set { _closeprice = value; }
            get { return _closeprice; }
        }
        /// <summary>
        /// (处理完成后显示完成结果)
        /// </summary>
        public string result
        {
            set { _result = value; }
            get { return _result; }
        }
        /// <summary>
        /// 已经成交，待成交，已完成，交易单，我的求购买入(0or1:为交易单(1,为交易匹配成功没有上传打款照片，1显示拒绝打款)，0:我的求购信息，-1撤销订单，2投诉中...,3,交易已经完成,4完成订单超时已经退回去（显示币已经退回）)
        /// </summary>
        public int status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 使用倒计时功能
        /// </summary>
        public DateTime millisecond
        {
            set { _millisecond = value; }
            get { return _millisecond; }
        }

        /// <summary>
        /// 是否开启价格同步0关1开
        /// </summary>
        public string synchroPrice
        {
            set;
            get;
        }
        /// <summary>
        /// 是否开启溢价同步0关不等于0则开（显示为溢价倍数）
        /// </summary>
        public string multiplePrice
        {
            set;
            get;
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime addtime
        {
            set;
            get;
        }

        /// <summary>
        /// 随机编号
        /// </summary>
        public int tempid
        {
            set;
            get;
        }

        /// <summary>
        /// 该订单是否被投诉，0未投诉。1已经投诉
        /// </summary>
        public int paytype
        {
            set;
            get;
        } 
        /// <summary>
        /// 当天成交订单个数
        /// </summary>
        public int ordercount
        {
            set;
            get;
        }
        /// <summary>
        /// 总交易订单个数
        /// </summary>
        public int allordercount
        {
            set;
            get;
        } 
         /// <summary>
        /// 总交易订单火豆个数
        /// </summary>
        public int totalcount
        {
            set;
            get;
        } 
        /// <summary>
        /// 用户等级，根据这个等级判断手续费率，
        /// </summary>
        public string activecode
        {
            set;
            get;
        }
        #endregion Model
    }
}

