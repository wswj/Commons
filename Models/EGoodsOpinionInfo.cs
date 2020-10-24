
// ETogoOpinionInfo：商家评论实体.
// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// update by yangxiaolong@ihangjing.com
// 2010-03-12

using System;
using System.Collections.Generic;

namespace Hangjing.Model
{
    /// <summary>
    /// 商家评论实体
    /// </summary>
    [Serializable]
    public class GoodsOpinionInfo
    {
        private int _dataid;
        private int _userid;
        private int _togoid;
        private int _point;
        private string _comment;
        private DateTime _posttime;
        private int _servicegrade;
        private int _flavorgrade;
        private int _speedgrade;
        private string _username;
        private string _togoname;
        private DateTime _rtime;
        private string _rcontent;
        private int _rtype;
        private string _picture;
        private string _truename;

        /// <summary>
        /// 评论图片html
        /// </summary>
        public string pictags
        {
            get;
            set;
        }

        /// <summary>
        /// 用户图片
        /// </summary>
        public string picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        private string _picture1;
        /// <summary>
        /// 评论图片1
        /// </summary>
        public string picture1
        {
            get { return _picture1; }
            set { _picture1 = value; }
        }
        private string _picture2;
        /// <summary>
        /// 评论图片2
        /// </summary>
        public string picture2
        {
            get { return _picture2; }
            set { _picture2 = value; }
        }
        private string _picture3;
        /// <summary>
        /// 评论图片3
        /// </summary>
        public string picture3
        {
            get { return _picture3; }
            set { _picture3 = value; }
        }
        private string _picture4;
        /// <summary>
        /// 评论图片4
        /// </summary>
        public string picture4
        {
            get { return _picture4; }
            set { _picture4 = value; }
        }

        public string Rcontent
        {
            get { return _rcontent; }
            set { _rcontent = value; }
        }

        /// <summary>
        /// 商品的id
        /// </summary>
        public int Rtype
        {
            get { return _rtype; }
            set { _rtype = value; }
        }

        public DateTime Rtime
        {
            get { return _rtime; }
            set { _rtime = value; }
        }

        /// <summary>
        /// 数据编号
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid; }
        }

        /// <summary>
        /// 评论者编号
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }

        /// <summary>
        /// 商家编号
        /// </summary>
        public int TogoID
        {
            set { _togoid = value; }
            get { return _togoid; }
        }

        /// <summary>
        /// 0表示没有审核，1表示审核
        /// </summary>
        public int Point
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
        /// 评论时间
        /// </summary>
        public DateTime PostTime
        {
            set { _posttime = value; }
            get { return _posttime; }
        }

        /// <summary>
        /// 服务等级
        /// </summary>
        public int ServiceGrade
        {
            set { _servicegrade = value; }
            get { return _servicegrade; }
        }

        /// <summary>
        /// 口味等级
        /// </summary>
        public int FlavorGrade
        {
            set { _flavorgrade = value; }
            get { return _flavorgrade; }
        }

        /// <summary>
        /// 速度等级
        /// </summary>
        public int SpeedGrade
        {
            set { _speedgrade = value; }
            get { return _speedgrade; }
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string TrueName
        {
            set { _truename = value; }
            get { return _truename; }
        }

        /// <summary>
        /// 商家名称
        /// </summary>
        public string TogoName
        {
            set { _togoname = value; }
            get { return _togoname; }
        }

        /// <summary>
        /// 好评
        /// </summary>
        private int _pointA;
        public int pointA
        {
            get { return _pointA; }
            set { _pointA = value; }
        }
        /// <summary>
        /// 中评
        /// </summary>
        private int _pointB;
        public int pointB
        {
            get { return _pointB; }
            set { _pointB = value; }
        }
        /// <summary>
        /// 差评
        /// </summary>
        private int _pointC;
        public int pointC
        {
            get { return _pointC; }
            set { _pointC = value; }
        }

    }
}

