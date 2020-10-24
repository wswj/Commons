using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// 跑腿订单
    /// </summary>
    [Serializable]
    public class ExpressOrderInfo
    {
        private int _dataid;
        private string _orderid;
        private int _userid;
        private string _username;
        private string _tel;
        private string _senttime;
        private string _address;
        private int _state;
        private int _togoid;
        private DateTime _ordertime;
        private decimal _totalprice;
        private DateTime _setstatetime;
        private decimal _currentprice;

        private int _foodcount;
        private int _ordercount;
        private decimal _ordertotal;

        private string _togoname;
        private string _customername;

        private string _Remark;
        private string _oorderid;
        private int _callcount;
        private string _callmsg;
        private string _writer;

        //支付部分
        private DateTime _paytime;
        private int _paystate;//0表示支付，1成功，-1失败
        private decimal _paymoney;
        private int _paymode;
        private string payorderid;
        private decimal _sendmoney;

        private int _Inve1;
        private int _sid;
        private string _inve2;
        private int _bid;
        private int _cityid;
        private string _tempcode;
        private string strPrintEnd;
        private int _addpoint;

        //后来新增的字段
        private int _ordersource;
        private int _isaddpoint;
        private int _sendtype;
        private string _ulat;
        private string _ulng;
        private string _shoplng;
        private string _shoplat;
        private string _sitelat;
        private string _sitelng;
        private int _ordertype;
        private int _noaccess;
        private int _iscancel;
        private int _validatecode;
        private int _reveint1;
        private int _reveint2;
        private string _revevar;
        private DateTime _revedate1;
        private DateTime _revedate2;
        private int _istimelimit;

        private string _payorderid;

        private string _servename;

        /// <summary>
        ///  图片完整路径数组
        /// </summary>		
        public string servename
        {
            get { return _servename; }
            set { _servename = value; }
        }


        private IList<FoodInOrderInfo> _foodlist;

        /// <summary>
        /// 
        /// </summary>
        public IList<FoodInOrderInfo> foodlist
        {
            get { return _foodlist; }
            set { _foodlist = value; }
        }

        /// <summary>
        /// 号
        /// </summary>		

        public string PayOrderId
        {
            get { return _payorderid; }
            set { _payorderid = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int addpoint
        {
            set { _addpoint = value; }
            get { return _addpoint; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PrintEnd
        {
            get { return strPrintEnd; }
            set { strPrintEnd = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string tempcode
        {
            set { _tempcode = value; }
            get { return _tempcode; }
        }

        /// <summary>
        ///
        /// </summary>
        public int Cityid
        {
            set { _cityid = value; }
            get { return _cityid; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int sid
        {
            set { _sid = value; }
            get { return _sid; }
        }

        /// <summary>
        ///
        /// </summary>
        public int Inve1
        {
            set { _Inve1 = value; }
            get { return _Inve1; }
        }


        /// <summary>
        ///
        /// </summary>
        public string Inve2
        {
            set { _inve2 = value; }
            get { return _inve2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int bid
        {
            set { _bid = value; }
            get { return _bid; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal sendmoney
        {
            set { _sendmoney = value; }
            get { return _sendmoney; }
        }


        /// <summary>
        ///  post_sort(1:视频0：图片)
        /// </summary>
        public int PayMode
        {
            set { _paymode = value; }
            get { return _paymode; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime paytime
        {
            set { _paytime = value; }
            get { return _paytime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int paystate
        {
            set { _paystate = value; }
            get { return _paystate; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal paymoney
        {
            set { _paymoney = value; }
            get { return _paymoney; }
        }

        /// <summary>
        ///  mp4 完整播放地址
        /// </summary>
        public string writer
        {
            set { _writer = value; }
            get { return _writer; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _Remark = value; }
            get { return _Remark; }
        }


        /// <summary>
        /// 自增字段
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid; }
        }

        /// <summary>
        ///
        /// </summary>
        public string OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }

        /// <summary>
        ///  农场名称
        /// </summary>
        public string SentTime
        {
            set { _senttime = value; }
            get { return _senttime; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime orderTime
        {
            set { _ordertime = value; }
            get { return _ordertime; }
        }

        /// <summary>
        ///
        /// </summary>
        public decimal TotalPrice
        {
            set { _totalprice = value; }
            get { return _totalprice; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int OrderCount
        {
            get { return _ordercount; }
            set { _ordercount = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Decimal OrderTotal
        {
            get { return _ordertotal; }
            set { _ordertotal = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime SetStateTime
        {
            get { return _setstatetime; }
            set { _setstatetime = value; }
        }

        /// <summary>
        /// 农场编号
        /// </summary>
        public int TogoID
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
        ///
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
        /// 
        /// </summary>
        public string TogoName
        {
            set { _togoname = value; }
            get { return _togoname; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int FoodCount
        {
            get { return _foodcount; }
            set { _foodcount = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CustomerName
        {
            get { return _customername; }
            set { _customername = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Oorderid
        {
            set { _oorderid = value; }
            get { return _oorderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int callcount
        {
            set { _callcount = value; }
            get { return _callcount; }
        }
        /// <summary>
        /// 分享图片(视频或者图片均为该数据)
        /// </summary>
        public string callmsg
        {
            set { _callmsg = value; }
            get { return _callmsg; }
        }

        /// <summary>
        /// 
        /// </summary>		

        public int ordersource
        {
            get { return _ordersource; }
            set { _ordersource = value; }
        }
        /// <summary>
        /// 
        /// </summary>		
        public int isaddpoint
        {
            get { return _isaddpoint; }
            set { _isaddpoint = value; }
        }
        /// <summary>
        /// 未用
        /// </summary>		
        public int sendtype
        {
            get { return _sendtype; }
            set { _sendtype = value; }
        }
        /// <summary>
        /// 收件人纬度 
        /// </summary>		
        public string ulat
        {
            get { return _ulat; }
            set { _ulat = value; }
        }
        /// <summary>
        /// 收件人经度
        /// </summary>	
        public string ulng
        {
            get { return _ulng; }
            set { _ulng = value; }
        }
        /// <summary>
        /// 发件人纬度 
        /// </summary>		
        public string shoplat
        {
            get { return _shoplat; }
            set { _shoplat = value; }
        }
        /// <summary>
        /// 发件人经度
        /// </summary>		
        public string shoplng
        {
            get { return _shoplng; }
            set { _shoplng = value; }
        }
        /// <summary>
        /// 图片名称数组，
        /// </summary>		
        public string sitelat
        {
            get { return _sitelat; }
            set { _sitelat = value; }
        }
        /// <summary>
        /// 粉丝数量
        /// </summary>		
        public string sitelng
        {
            get { return _sitelng; }
            set { _sitelng = value; }
        }
        /// <summary>
        /// 未用
        /// </summary>		
        public int ordertype
        {
            get { return _ordertype; }
            set { _ordertype = value; }
        }
        /// <summary>
        /// 未用 
        /// </summary>		
        public int noaccess
        {
            get { return _noaccess; }
            set { _noaccess = value; }
        }
        /// <summary>
        /// 未用
        /// </summary>		
        public int validateCode
        {
            get { return _validatecode; }
            set { _validatecode = value; }
        }
        /// <summary>
        /// 
        /// </summary>	
        public int iscancel
        {
            get { return _iscancel; }
            set { _iscancel = value; }
        }
        /// <summary>
        /// 服务类型编号
        /// </summary>		
        public int ReveInt1
        {
            get { return _reveint1; }
            set { _reveint1 = value; }
        }
        /// <summary>
        /// 是否被接单： 0未被接单 1已被接单  5流单(用于接单按钮的变化)
        /// </summary>		
        public int ReveInt2
        {
            get { return _reveint2; }
            set { _reveint2 = value; }
        }
        /// <summary>
        /// 用户头像
        /// </summary>		  
        public string ReveVar
        {
            get { return _revevar; }
            set { _revevar = value; }
        }
        /// <summary>
        /// 未用
        /// </summary>		
        public DateTime ReveDate1
        {
            get { return _revedate1; }
            set { _revedate1 = value; }
        }
        /// <summary>
        /// 未用
        /// </summary>		
        public DateTime ReveDate2
        {
            get { return _revedate2; }
            set { _revedate2 = value; }
        }
        /// <summary>
        /// 未用
        /// </summary>		
        public int IsTimeLimit
        {
            get { return _istimelimit; }
            set { _istimelimit = value; }
        }


        /// <summary>
        /// 城市名称
        /// </summary>
        public string CityName
        {
            get;
            set;
        }

        /// <summary>
        /// 余额支付的金额
        /// </summary>
        public decimal  acountpay
        {
            get;
            set;
        }

    }
}

