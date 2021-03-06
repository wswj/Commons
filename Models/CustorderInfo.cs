using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// 实体类custorder 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class CustorderInfo
    {
        private int _unid;
        private string _inuse;
        private DateTime _orderdatetime;
        private int _orderchecker;
        private int _orderstatus;
        private string _orderrcver;
        private string _ordercomm;
        private string _orderaddress;
        private string _addresstext;
        private string _orderattach;
        private decimal _ordersums;
        private string _sender;
        private DateTime _sendtime;
        private string _callphoneno;
        private string _p2sign;
        private decimal _sendfee;
        private int _paymode;
        private DateTime _paytime;
        private decimal _paymoney;
        private int _paystate;
        private DateTime _setstatetime;
        private int _userid;
        private int _togoid;

        //以下字段需要连接查询获取
        private int _foodcount;
        private int _ordercount;
        private decimal _ordertotal;

        private string _togoname;
        private string _customername;
        private string _togotel;

        private string _fromweb;


        private int _oldstatus;
        private int _systemuser;
        private int _Commentstate;
        private string _FoodName;
        private string _writer;
        private string _TogoAddress;
        private decimal _oldprice;


        protected IList<FoodlistInfo> _foodlist;
        /// <summary>
        /// 订单中的商品
        /// </summary>
        public IList<FoodlistInfo> foodlist
        {
            get { return _foodlist; }
            set { _foodlist = value; }
        }
        /// <summary>
        /// 菜品原总金额
        /// </summary>
        public Decimal OldPrice
        {
            get { return _oldprice; }
            set { _oldprice = value; }
        }

        /// <summary>
        /// 商家地址
        /// </summary>
        public string TogoAddress
        {
            set { _TogoAddress = value; }
            get { return _TogoAddress; }
        }

        /// <summary>
        /// 处理人
        /// </summary>
        public string writer
        {
            set { _writer = value; }
            get { return _writer; }
        }

        public string FoodName
        {
            set { _FoodName = value; }
            get { return _FoodName; }
        }


        /// <summary>
        /// 商品折扣，100表示没有折扣，会员有等级会有折扣，88折，保存88
        /// </summary>
        public int OldStatus
        {
            set { _oldstatus = value; }
            get { return _oldstatus; }
        }

        /// <summary>
        /// 锁定该订单的管理员编号
        /// </summary>
        public int SystemUserId
        {
            set { _systemuser = value; }
            get { return _systemuser; }
        }

        /// <summary>
        /// 订单来源：0 网站，6 客服
        /// </summary>
        public string fromweb
        {
            set { _fromweb = value; }
            get { return _fromweb; }
        }

        private string _orderid;
        /// <summary>
        /// 订单编号 随机生成
        /// 2010-03-15 8:47 by jijunjian
        /// </summary>
        public string orderid
        {
            set { _orderid = value; }
            get { return _orderid; }
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

        /// <summary>
        /// 商家电话号码
        /// </summary>
        public string TogoTel
        {
            get { return _togotel; }
            set { _togotel = value; }
        }

        /// <summary>
        /// 自增编号
        /// </summary>
        public int Unid
        {
            set { _unid = value; }
            get { return _unid; }
        }

        /// <summary>
        /// 是否使用 Y/N
        /// </summary>
        public string InUse
        {
            set { _inuse = value; }
            get { return _inuse; }
        }

        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime OrderDateTime
        {
            set { _orderdatetime = value; }
            get { return _orderdatetime; }
        }

        /// <summary>
        /// 录入定单员工的unid
        /// </summary>
        public int OrderChecker
        {
            set { _orderchecker = value; }
            get { return _orderchecker; }
        }

        /// <summary>
        /// 1:等待审核;2:审核通过;7:已经调度;3:处理成功;4:处理失败;5:订单取消;6:订单失效;
        /// </summary>
        public int OrderStatus
        {
            set { _orderstatus = value; }
            get { return _orderstatus; }
        }

        /// <summary>
        /// 收货人称呼
        /// </summary>
        public string OrderRcver
        {
            set { _orderrcver = value; }
            get { return _orderrcver; }
        }

        /// <summary>
        /// 收货人联系电话
        /// </summary>
        public string OrderComm
        {
            set { _ordercomm = value; }
            get { return _ordercomm; }
        }

        /// <summary>
        /// 前台下单为"" ，客服下单为客服用户名
        /// </summary>
        public string OrderAddress
        {
            set { _orderaddress = value; }
            get { return _orderaddress; }
        }

        /// <summary>
        /// 收货地址
        /// </summary>
        public string AddressText
        {
            set { _addresstext = value; }
            get { return _addresstext; }
        }

        /// <summary>
        ///  商家快递单号
        /// </summary>
        public string OrderAddrEx
        {
            set;
            get;
        }
       
        /// <summary>
        ///  微信二维码支付地址
        /// </summary>
        public string PayOrderId
        {
            set;
            get;
        }

        /// <summary>
        /// 快递名称如韵达快递
        /// </summary>
        public string OrderAttach
        {
            set { _orderattach = value; }
            get { return _orderattach; }
        }

        /// <summary>
        /// 定单总金额:商品费用+配送费
        /// </summary>
        public decimal OrderSums
        {
            set { _ordersums = value; }
            get { return _ordersums; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Sender
        {
            set { _sender = value; }
            get { return _sender; }
        }

        /// <summary>
        /// 起送时间
        /// </summary>
        public DateTime SendTime
        {
            set { _sendtime = value; }
            get { return _sendtime; }
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string CallPhoneNo
        {
            set { _callphoneno = value; }
            get { return _callphoneno; }
        }

        /// <summary>
        /// 订货区域地址
        /// </summary>
        public string P2Sign
        {
            set { _p2sign = value; }
            get { return _p2sign; }
        }

        /// <summary>
        /// 配送费
        /// </summary>
        public decimal SendFee
        {
            set { _sendfee = value; }
            get { return _sendfee; }
        }

        /// <summary>
        /// 支付类型 （1支付宝/2银联/3账户余额/4货到付款/5微信支付）
        /// </summary>
        public int paymode
        {
            set { _paymode = value; }
            get { return _paymode; }
        }

        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime paytime
        {
            set { _paytime = value; }
            get { return _paytime; }
        }

        /// <summary>
        /// 支付金额
        /// </summary>
        public decimal paymoney
        {
            set { _paymoney = value; }
            get { return _paymoney; }
        }

        /// <summary>
        /// 支付结果  0 未支付 1 成功
        /// </summary>
        public int paystate
        {
            set { _paystate = value; }
            get { return _paystate; }
        }

        /// <summary>
        /// 更新状态时间
        /// </summary>
        public DateTime SetStateTime
        {
            set { _setstatetime = value; }
            get { return _setstatetime; }
        }

        /// <summary>
        /// 会员编号
        /// </summary>
        public int UserId
        {
            set { _userid = value; }
            get { return _userid; }
        }

        /// <summary>
        /// 商家编号
        /// </summary>
        public int TogoId
        {
            set { _togoid = value; }
            get { return _togoid; }
        }

        /// <summary>
        /// 是否评论0 未评论1已经评论
        /// </summary>
        public int Commentstate
        {
            set { _Commentstate = value; }
            get { return _Commentstate; }
        }

        /// <summary>
        /// 商家是否确认(0未确认，1已经确认，2拒绝).,推送商家根据这个字段
        /// </summary>
        public int IsShopSet
        {
            set;
            get;
        }
        /// <summary>
        ///  商家logo
        /// </summary>
        public string TogoPicture
        {
            set;
            get;
        }
        
        /// <summary>
        /// 用户头像
        /// </summary>
        public string uPicture
        {
            set;
            get;
        }
        private int _deliversiteid;
        /// <summary>
        /// 打印状态：999表示没有打印机商家的， 0：等待打印;1:已打印;2请求失败;3:请求已发送;-1:IP地址不允许;-2:关键参数为空或请求方式不对;-3:客户编码不正确;-4:安全校验码不正确;-5:请求时间失效;
        /// </summary>
        public int deliversiteid
        {
            get { return _deliversiteid; }
            set { _deliversiteid = value; }
        }

        private int _deliverheaderid;
        /// <summary>
        /// 群组编号
        /// </summary>
        public int deliverheaderid
        {
            get { return _deliverheaderid; }
            set { _deliverheaderid = value; }
        }

        private int _deliverid;
        /// <summary>
        /// 配送员编号
        /// </summary>
        public int deliverid
        {
            get { return _deliverid; }
            set { _deliverid = value; }
        }

        private int _sendstate;
        /// <summary>
        /// 配送状态：0：未处理,1取货中，2：配送中，3：配送完成， 4：配送失败
        /// </summary>
        public int sendstate
        {
            get { return _sendstate; }
            set { _sendstate = value; }
        }

        private int _reveint1;
        /// <summary>
        /// 商品编号
        /// </summary>
        public int ReveInt1
        {
            get { return _reveint1; }
            set { _reveint1 = value; }
        }

        private int _reveint2;
        /// <summary>
        /// （未用）就餐类型：0外卖，1堂食
        /// </summary>
        public int ReveInt2
        {
            get { return _reveint2; }
            set { _reveint2 = value; }
        }

        private string _revevar1;
        /// <summary>
        ///  家，学校，公司
        /// </summary>
        public string ReveVar1
        {
            get { return _revevar1; }
            set { _revevar1 = value; }
        }

        private string _revevar2;
        /// <summary>
        /// 用户的团购订单分订单编号
        /// </summary>
        public string ReveVar2
        {
            get { return _revevar2; }
            set { _revevar2 = value; }
        }

        private DateTime _revedate1;
        /// <summary>
        /// 商家接收或者拒绝时间
        /// </summary>
        public DateTime ReveDate1
        {
            get { return _revedate1; }
            set { _revedate1 = value; }
        }

        private DateTime _revedate2;
        /// <summary>
        /// 自动调度发大群时的时间
        /// </summary>
        public DateTime ReveDate2
        {
            get { return _revedate2; }
            set { _revedate2 = value; }
        }


        /// <summary>
        /// 表示此订单骑士要给商家的金额
        /// </summary>
        public decimal shopdiscountmoney
        {
            set;
            get;
        }

        /// <summary>
        /// 优惠券金额
        /// </summary>
        public decimal cardpay
        {
            set;
            get;
        }

        /// <summary>
        /// 临时编号，对于未登录的使用，通常用guid
        /// </summary>
        public string tempcode
        {
            set;
            get;
        }

        /// <summary>
        /// 未用
        /// </summary>
        public decimal Packagefee
        {
            set;
            get;
        }
        /// <summary>
        /// 订单用户的推荐人id
        /// </summary>
        public string rID
        {
            set;
            get;
        }

        /// <summary>
        /// 订单用户是否赠送过卷轴0未赠送1赠送过
        /// </summary>
        public int iswriter
        {
            set;
            get;
        }

        /// <summary>
        /// 订单中第一个商品id
        /// </summary>
        public string Foodid
        {
            set;
            get;
        }

        /// <summary>
        /// 订单中第一个商品FPrice
        /// </summary>
        public decimal FPrice
        {
            set;
            get;
        }
        /// <summary>
        /// 订单中第一个商品pic
        /// </summary>
        public string Foodpic
        {
            set;
            get;
        }

    }
}

