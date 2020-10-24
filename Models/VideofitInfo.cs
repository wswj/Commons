#region license
// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// Function :实惠信息 
// Created by tuhui at 2010-6-22 10:23:25.
// E-Mail: tuhui@ihangjing.com
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// 实惠信息Model
    /// </summary>
    [Serializable]
    public class VideofitInfo
    {
        private int _benefitid;
        private int _classid;
        private string _title;
        private string _content;
        private DateTime _adddate;
        private int _viewtimes;
        private int _havecoupons;
        private string _picture;
        private int _onhome;
        private DateTime _beginday;
        private DateTime _endday;
        private string _address;
        private string _tel;
        private int _isnew;
        private int _isphone;
        private int _ishot;
        private int _printtime;

        private string _userPicture;
        private string _userName;
        private string _className;

        public VideofitInfo()
        { }

        public IList<ShopFoodPictureInfo> pictags
       {
            get;
            set;
        }
        /// <summary>
        /// 时间，1周前，1分钟前。。。
        /// </summary>
        public string timehtml
        {
            get;
            set;
        }
        /// <summary>
        /// 是否关注过
        /// </summary>
        public int isCollect
        {
            get;
            set;
        } 

        /// <summary>
        /// 点赞数量
        /// </summary>
        public int zan_num
        {
            get;
            set;
        }
        
        /// <summary>
        /// 评论数量
        /// </summary>
        public int ping_num
        {
            get;
            set;
        }

        /// <summary>
        /// 编号
        /// </summary>
        public int BenefitId
        {
            set { _benefitid = value; }
            get { return _benefitid; }
        }

        /// <summary>
        /// 类别编号
        /// </summary>
        public int ClassId
        {
            set { _classid = value; }
            get { return _classid; }
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        } 

        /// <summary>
        /// 用户图片
        /// </summary>
        public string userPicture
        {
            set { _userPicture = value; }
            get { return _userPicture; }
        }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string userName
        {
            set { _userName = value; }
            get { return _userName; }
        }

        /// <summary>
        /// 详情、内容
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }

        /// <summary>
        /// 增加时间
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }

        /// <summary>
        /// 浏览次数
        /// </summary>
        public int ViewTimes
        {
            set { _viewtimes = value; }
            get { return _viewtimes; }
        }

        /// <summary>
        /// 图片
        /// </summary>
        public string Picture
        {
            set { _picture = value; }
            get { return _picture; }
        }

        /// <summary>
        /// 0，审核中，1审核通过
        /// </summary>
        public int Onhome
        {
            get { return _onhome; }
            set { _onhome = value; }
        }

        /// <summary>
        /// 用户id
        /// </summary>
        public int HaveCoupons
        {
            get { return _havecoupons; }
            set { _havecoupons = value; }
        }

        /// <summary>
        ///起始日期
        /// </summary>
        public DateTime BeginTime
        {
            set { _beginday = value; }
            get { return _beginday; }
        }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDay
        {
            set { _endday = value; }
            get { return _endday; }
        }

        /// <summary>
        /// 视频地址
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        /// <summary>
        /// 视频分类的名称
        /// </summary>
        public string className
        {
            set { _className = value; }
            get { return _className; }
        }

        /// <summary>
        /// 视频时间长度
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }

        public int IsNew
        {
            set { _isnew = value; }
            get { return _isnew; }
        }

        /// <summary>
        /// 喜欢视频
        /// </summary>
        public int IsHot
        {
            set { _ishot = value; }
            get { return _ishot; }
        }

        public int IsPhone
        {
            set { _isphone = value; }
            get { return _isphone; }
        }

        /// <summary>
        /// 打印次数
        /// </summary>
        public int PrintTime
        {
            set { _printtime = value; }
            get { return _printtime; }
        }
    }
}
