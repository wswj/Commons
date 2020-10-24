using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    public enum GroupEventType
    {

        // and Reve2='1'(推广获取活跃度总和)
        //获取（活力度）活力度类型，0:卷轴活跃度，1:直推获取活跃度（及下线购买卷轴）,Reve2=2:卖豆活力度扣除，3:新人红包获取活力值，4:推广会员获取活力值每个直推5 复投奖励活力值 6购买奖励活力值
        /// <summary>
        /// 卷轴活跃度
        /// </summary>
        missionAdd = 0,
        /// <summary>
        ///直推获取活跃度（及下线购买卷轴有效期45天）
        /// </summary>
        tgValue = 1,
        /// <summary>
        /// 卖豆扣除活力度
        /// </summary>
        clubSub = 2,
        /// <summary>
        /// 新人红包获取活力值
        /// </summary>
        NewPersonAdd = 3,
        /// <summary>
        /// 推广会员获取活力值每个直推
        /// </summary>
        invitefriend = 4,
        /// <summary>
        /// 复投奖励活力值
        /// </summary>
        DoubleThrow = 5,
        /// <summary>
        /// 购买奖励活力值
        /// </summary>
        BuyHuoDou = 6,

    }


    /// <summary>
    /// IntegralToVip:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class IntegralToVipInfo
    {

        public IntegralToVipInfo()
        { }

        private int _dataid;
        private int _userid;
        private int _vip;
        private int _state;
        private decimal _starttime;
        private DateTime _endtime;
        private DateTime _createtime;
        private decimal _inve1;
        private string _reve1;
        private string _reve2;
        private string _reve3;

        private string _username;

        private string _usergrade;
        /// <summary>
        /// 用户等级名称
        /// </summary>
        public string usergrade
        {
            set { _usergrade = value; }
            get { return _usergrade; }
        }

        private string _userpic;
        /// <summary>
        /// 用户等级头像
        /// </summary>
        public string userpic
        {
            set { _userpic = value; }
            get { return _userpic; }
        }


        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }

        private string _vipgrade;

        /// <summary>
        /// 用户等级
        /// </summary>
        public string vipgrade
        {
            set { _vipgrade = value; }
            get { return _vipgrade; }
        }

        /// <summary>
        /// 主机
        /// </summary>
        public int DataId
        {
            set { _dataid = value; }
            get { return _dataid; }
        }

        /// <summary>
        /// 用户的编号
        /// </summary>
        public int UserId
        {
            set { _userid = value; }
            get { return _userid; }
        }

        /// <summary>
        /// 获取活跃度类型，0:卷轴活跃度，1:直推获取活跃度（及下线购买卷轴）,2:加入俱乐部，3:加入组队，4:城市合伙人（5邀请好友，6分享文章 只对与推广会员）
        /// </summary>
        public int Vip
        {
            set { _vip = value; }
            get { return _vip; }
        }

        /// <summary>
        /// 审核状态  0 = "未审核";  1 = "审核通过"; 2 = "审核未通过";
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }

        /// <summary>
        /// 变化的值
        /// </summary>
        public decimal StartTime
        {
            set { _starttime = value; }
            get { return _starttime; }
        }

        /// <summary>
        /// 可以使用的结束日期
        /// </summary>
        public DateTime EndTime
        {
            set { _endtime = value; }
            get { return _endtime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }

        /// <summary>
        /// 会员获取金额
        /// </summary>
        public decimal Inve1
        {
            set { _inve1 = value; }
            get { return _inve1; }
        }

        /// <summary>
        /// 获取余额名称
        /// </summary>
        public string Reve1
        {
            set { _reve1 = value; }
            get { return _reve1; }
        }

        /// <summary>
        /// type（类型如：1活跃度2，备用3新人注册红包，4活力度。。。）
        /// </summary>
        public string Reve2
        {
            set { _reve2 = value; }
            get { return _reve2; }
        }

        /// <summary>
        /// 获取详情
        /// </summary>
        public string Reve3
        {
            set { _reve3 = value; }
            get { return _reve3; }
        }

        private User_Grade_RInfo _favourable;
        /// <summary>
        /// 等级优惠
        /// </summary>
        public User_Grade_RInfo favourable
        {
            set { _favourable = value; }
            get { return _favourable; }
        }
    }
}

