/*********************************************************************
 * CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
 * Created by wanghui at 2011-5-12 9:03:30.
 * E-Mail   : wanghui@ihangjing.com
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Hangjing.Model
{
    /// <summary>
    /// 实体类ECustomer+Integral 。(实名认证信息)
    /// </summary>
    public class ECustomerIntegralInfo
    {
        private int _integralid;
        private string _custid;
        private string _payintegral;
        private int _detailid;
        private DateTime _cdate;
        private string _state;
        private string _giftsid;
        private string _address;
        private string _phone;
        private string _person;
        private string _date;
        private string _username;
        private string _giftname;
        private string _remark;

        private string _picture;
        /// <summary>
        /// 头像
        /// </summary>
        public string Picture
        {
            set { _picture = value; }
            get { return _picture; }
        }
        private int _subcount;
        /// <summary>
        /// 实名验证次数
        /// </summary>
        public int subcount
        {
            set { _subcount = value; }
            get { return _subcount; }
        }

        private DateTime _regtime;
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegTime
        {
            set { _regtime = value; }
            get { return _regtime; }
        }

        private string _website;
        /// <summary>
        /// 为空或者0为未实名认证(0或者空：未实名，未支付，1：实名未支付，不等于1说明实名+支付，后期可考虑实名认证为实名数据库编号)
        /// </summary>
        public string WebSite
        {
            set{_website = value;}
            get{return _website;}
        }

        private string _qq;
        /// <summary>
        /// GUID(会员编号后面使用此字段为获取用户)
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }

        private int _dataid;
        /// <summary>
        ///用户编号
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid; }
        }

        private string _name;
        /// <summary>
        /// 昵称
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        private string _tell;
        /// <summary>
        /// 微信号
        /// </summary>
        public string Tell
        {
            set { _tell = value; }
            get { return _tell; }
        }
        private string _sex;
        /// <summary>
        /// 性别 (0:男1，女)
        /// </summary>
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }

        private string _ticket;
        /// <summary>
        /// 打款凭证
        /// </summary>
        public string Ticket
        {
            set { _ticket = value; }
            get { return _ticket; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int IntegralId
        {
            set { _integralid = value; }
            get { return _integralid; }
        }

        /// <summary>
        /// 开户名称
        /// </summary>
        public string CustId
        {
            set { _custid = value; }
            get { return _custid; }
        }

        /// <summary>
        /// 开户行
        /// </summary>
        public string PayIntegral
        {
            set { _payintegral = value; }
            get { return _payintegral; }
        }

        /// <summary>
        /// 用户id
        /// </summary>
        public int DetailId
        {
            set { _detailid = value; }
            get { return _detailid; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Cdate
        {
            set { _cdate = value; }
            get { return _cdate; }
        }

        /// <summary>
        /// 用户电话（手机）
        /// </summary>
        public string State
        {
            set { _state = value; }
            get { return _state; }
        }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string GiftsId
        {
            set { _giftsid = value; }
            get { return _giftsid; }
        }

        /// <summary>
        /// 开户银行省Address
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        /// <summary>
        /// 开户市Phone
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }

        /// <summary>
        /// 微信号Person
        /// </summary>
        public string Person
        {
            set { _person = value; }
            get { return _person; }
        }

        /// <summary>
        /// 开户网点Date
        /// </summary>
        public string Date
        {
            set { _date = value; }
            get { return _date; }
        }
        /// <summary>
        /// 支付宝名称UserName
        /// </summary>
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        /// <summary>
        /// 银行卡号GiftName
        /// </summary>
        public string GiftName
        {
            get { return _giftname; }
            set { _giftname = value; }
        }

        /// <summary>
        /// 支付宝号Remark
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

    }
}
