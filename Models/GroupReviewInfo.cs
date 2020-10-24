// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// Function :团购评价表信息
// Created by tuhui at 2010-6-22 10:33:12.
// E-Mail: tuhui@ihangjing.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    [Serializable]
    public class GroupReviewInfo
    {
        private int _rid;
        private int _userid;
        private string _togoid;
        private decimal _point;
        private string _comment;
        private DateTime _posttime;
        private int _servicegrade;
        private int _flavorgrade;
        private int _speedgrade;
        private string _username;
        private DateTime _rtime;
        private string _rcontent;
        private int _rtype;
        private string _reviewtype;
        private string _itemname;
        private string _orderid;

        private decimal _rat;

        private int _haoping;
        public int haoping
        {
            set { _haoping = value; }
            get { return _haoping; }
        }
        private int _zhongping;
        public int zhongping
        {
            set { _zhongping = value; }
            get { return _zhongping; }
        }
        private int _chaping;
        public int chaping
        {
            set { _chaping = value; }
            get { return _chaping; }
        }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string orderid
        {
            set { _orderid = value; }
            get { return _orderid; }
        }


        /// <summary>
        /// 得分（现在前都是用百分比）
        /// </summary>
        public decimal rat
        {
            set { _rat = value; }
            get { return _rat; }
        }

        /// <summary>
        /// 团购名称
        /// </summary>
        public string itemname
        {
            set { _itemname = value; }
            get { return _itemname; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int rID
        {
            set { _rid = value; }
            get { return _rid; }
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
        public string TogoID
        {
            set { _togoid = value; }
            get { return _togoid; }
        }
        /// <summary>
        /// 综合评分
        /// </summary>
        public decimal Point
        {
            set { _point = value; }
            get { return _point; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Comment
        {
            set { _comment = value; }
            get { return _comment; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PostTime
        {
            set { _posttime = value; }
            get { return _posttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ServiceGrade
        {
            set { _servicegrade = value; }
            get { return _servicegrade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int FlavorGrade
        {
            set { _flavorgrade = value; }
            get { return _flavorgrade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SpeedGrade
        {
            set { _speedgrade = value; }
            get { return _speedgrade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Rtime
        {
            set { _rtime = value; }
            get { return _rtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Rcontent
        {
            set { _rcontent = value; }
            get { return _rcontent; }
        }
        /// <summary>
        /// 审核状态：0未审核，1审核，2审核未通过
        /// </summary>
        public int rtype
        {
            set { _rtype = value; }
            get { return _rtype; }
        }
        /// <summary>
        /// 商品评论（商品的id）
        /// </summary>
        public string ReviewType
        {
            set { _reviewtype = value; }
            get { return _reviewtype; }
        }
    }
}
