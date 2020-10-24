
// 用户收益记录
// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// jijunjian@ihangjing.com
// 2010-03-05

using System;
namespace Hangjing.Model
{
    public enum PointEventType
    {
        /// <summary>
        /// (火力值释放)
        /// </summary>
        release = 0,
        /// <summary>
        /// (领取币产币)
        /// </summary>
        getperhour = 1,
        /// <summary>
        /// (出售)
        /// </summary>
        sale = 2,
        /// <summary>
        /// (订单支付/购买)
        /// </summary>
        pay = 3,
        /// <summary>
        /// (买进)
        /// </summary>
        buy = 4,
        /// <summary>
        /// (下线购买)
        /// </summary>
        lowpay = 5,
        /// <summary>
        /// (领导奖励)
        /// </summary>
        superreward = 6,
        /// <summary>
        /// (买矿机)
        /// </summary>
        buymachine = 7,
        /// <summary>
        /// (买方拒绝打钱，退回)
        /// </summary>
        salenopay = 8,
        /// <summary>
        /// (买方已打钱不确认，自动成交)
        /// </summary>
        timeout = 9,
        /// <summary>
        /// (推荐一个用户奖励火力值)
        /// </summary>
        actpoint = 10,
        /// <summary>
        /// 话费充值used
        /// </summary>
        addmobile = 11,
        /// <summary>
        /// 签到 奖励used
        /// </summary>
        usersignin = 12,
        /// <summary>
        /// 转赠派豆
        /// </summary>
        giveother = 13,
        /// <summary>
        /// 达人分红
        /// </summary>
        givelevel = 14,
        /// <summary>
        /// 余额提现
        /// </summary>
        tixian = 15,
        /// <summary>
        /// 认购充值
        /// </summary>
        chongzhi = 16,

    }

    /// <summary>
    /// 实体类EPointRecord 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class EPointRecordInfo
    {
        private int _dataid;
        private int _userid;
        private decimal _point;
        private string _event;
        private DateTime _time;
        private string _uname;


        private int _type;
        /// <summary>
        /// 类型...
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }


        /// <summary>
        /// 用户名称
        /// </summary>
        public string uname
        {
            set { _uname = value; }
            get { return _uname; }
        }

        /// <summary>
        /// 自增长
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid; }
        }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 变化积分
        /// </summary>
        public decimal Point
        {
            set { _point = value; }
            get { return _point; }
        }

        /// <summary>
        /// 当天产糖果量 （进行对比校验）
        /// </summary>
        public decimal Amount
        {
            set;
            get;
        }
        /// <summary>
        /// 用户的糖果总量
        /// </summary>
        public decimal totalsweet
        {
            set;
            get;
        }
        /// <summary>
        /// 当前积分
        /// </summary>
        public decimal curpoint
        {
            set;
            get;
        }

        /// <summary>
        /// 变化积分（正式的）,有正负
        /// </summary>
        public decimal changepoint
        {
            set;
            get;
        }

        /// <summary>
        /// 主类型，1:派豆  2：助力值 3:ppc
        /// </summary>
        public int transferfee
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


        /// <summary>
        /// 记录货币备注
        /// </summary>
        public string Event
        {
            set { _event = value; }
            get { return _event; }
        }
        /// <summary>
        ///当前时间 
        /// </summary>
        public DateTime Time
        {
            set { _time = value; }
            get { return _time; }
        }
    }
}

