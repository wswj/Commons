// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// Function :团购订单表信息
// Created by tuhui at 2010-6-22 10:33:12.
// E-Mail: tuhui@ihangjing.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    [Serializable]
    public class GroupOrdersInfo
    {
        private int _goid;
        private int _userid;
        private string _username;
        private string _tel;
        private string _senttime;
        private string _address;
        private int _state;
        private int _togoid;
        private DateTime _ordertime;
        private string _orderid;
        private decimal _totalprice;
        private DateTime _setstatetime;
        private decimal _currentprice;
        private int _paymode;
        private DateTime _paytime;
        private decimal _paymoney;
        private int _paystate;
        private int _sendfree;
        private string _tempcode;
        private string _remark;
        private int _reveint1;
        private int _reveint2;
        private string _revevar1;
        private string _itemname;
        private string _uname;
        /// <summary>
        /// 
        /// </summary>
        public int goid
        {
            set { _goid = value; }
            get { return _goid; }
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
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
        /// 0未审核，1正在处理，2已经送出，3处理完成。4失败。
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 团购项目
        /// </summary>
        public int TogoId
        {
            set { _togoid = value; }
            get { return _togoid; }
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
        public string OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
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
        public DateTime SetStateTime
        {
            set { _setstatetime = value; }
            get { return _setstatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Currentprice
        {
            set { _currentprice = value; }
            get { return _currentprice; }
        }
        /// <summary>
        ///0货到付款 1支付宝 2财付通
        /// </summary>
        public int paymode
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
        public decimal paymoney
        {
            set { _paymoney = value; }
            get { return _paymoney; }
        }
        /// <summary>
        /// 支付状态 0未支付 ，1支付成功，2支付失败
        /// </summary>
        public int paystate
        {
            set { _paystate = value; }
            get { return _paystate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sendfree
        {
            set { _sendfree = value; }
            get { return _sendfree; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tempCode
        {
            set { _tempcode = value; }
            get { return _tempcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ReveInt1
        {
            set { _reveint1 = value; }
            get { return _reveint1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ReveInt2
        {
            set { _reveint2 = value; }
            get { return _reveint2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ReveVar1
        {
            set { _revevar1 = value; }
            get { return _revevar1; }
        }
        /// <summary>
        /// 团购名称，
        /// </summary>
        public string itemname
        {
            set { _itemname = value; }
            get { return _itemname; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string uname
        {
            set { _uname = value; }
            get { return _uname; }
        }
    }
}
