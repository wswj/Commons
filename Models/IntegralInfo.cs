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
    /// 实体类Integral 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class IntegralInfo
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
        private int _ischeck;
        private string _bindwxpic;
        private string _bindzfbpic;

        private string _ticket;
        /// <summary>
        /// 打款凭证
        /// </summary>
        public string Ticket
        {
            set { _ticket = value; }
            get { return _ticket; }
        }
        private int _sex;
        public int Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        private string _userpicture;
        /// <summary>
        /// 用户头像
        /// </summary>
        public string userPicture
        {
            set { _userpicture = value; }
            get { return _userpicture; }
        }

        private int _subcount;
        /// <summary>
        /// 提交次数，每个用户只能提交两次
        /// </summary>
        public int subcount
        {
            set { _subcount = value; }
            get { return _subcount; }
        }
        /// <summary>
        ///  用户id
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

        /// <summary>
        /// 微信pic
        /// </summary>
        public string BindWxPic
        {
            get { return _bindwxpic; }
            set { _bindwxpic = value; }
        }
        /// <summary>
        /// 支付宝号Pic
        /// </summary>
        public string BindZfbPic
        {
            get { return _bindzfbpic; }
            set { _bindzfbpic = value; }
        }

        /// <summary>
        /// 检查身份证重复的用户
        /// </summary>
        public int ischeck
        {
            get { return _ischeck; }
            set { _ischeck = value; }
        }

    }
}
