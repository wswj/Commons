#region license
// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// Function :礼品信息
// Created by tuhui at 2010-6-22 10:42:53.
// E-Mail: tuhui@ihangjing.com
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// 礼品信息Model
    /// </summary>
    [Serializable]
    public class GiftsInfo
    {
        private int _giftsid;
        private string _classid;
        private string _gname;
        private string _content;
        private string _needintegral;
        private decimal _giftsprice;
        private string _picture;
        private string _username;
        private string _giftname;
        private int _stocks;
        private string _bigpicture;
        private int _sortnum;
        private DateTime _addtime;

        public GiftsInfo()
        { }

        public GiftsInfo(int giftsid, string classid, string gname, string content, string needintegral, decimal giftsprice, string picture, string username, string giftname, int stocks, string bigpicture, int sortnum,DateTime addtime)
        {
            this._classid = classid;
            this._content = content;
            this._giftsid = giftsid;
            this._giftsprice = giftsprice;
            this._gname = gname;
            this._needintegral = needintegral;
            this._picture = picture;
            this._username = username;
            this._giftname = giftname;
            this._stocks = stocks;
            this._bigpicture = bigpicture;
            this._sortnum = sortnum;
            this._addtime = addtime;
        }

       

        /// <summary>
        /// （表示该记录已经被激激活过了）
        /// </summary>
        public int Stocks
        {
            set { _stocks = value; }
            get { return _stocks; }
        }

        /// <summary>
        /// 大图
        /// </summary>
        public string bigpicture
        {
            set { _bigpicture = value; }
            get { return _bigpicture; }
        }

        /// <summary>
        /// 礼品排序
        /// </summary>
        public int sortnum
        {
            set { _sortnum = value; }
            get { return _sortnum; }
        }

        /// <summary>
        /// 礼品编号
        /// </summary>
        public int GiftsId
        {
            set { _giftsid = value; }
            get { return _giftsid; }
        }

        /// <summary>
        /// 礼品类别编号
        /// </summary>
        public string ClassId
        {
            set { _classid = value; }
            get { return _classid; }
        }

        /// <summary>
        /// 礼品名称
        /// </summary>
        public string Gname
        {
            set { _gname = value; }
            get { return _gname; }
        }

        /// <summary>
        /// 礼品介绍
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }

        /// <summary>
        ///(是否需要审核0：未审核【即存在记录】，1：已经提交图片未审核，2：审核通过)
        /// </summary>
        public string NeedIntegral
        {
            set { _needintegral = value; }
            get { return _needintegral; }
        }

        /// <summary>
        /// 礼品价值
        /// </summary>
        public decimal GiftsPrice
        {
            set { _giftsprice = value; }
            get { return _giftsprice; }
        }

        /// <summary>
        /// 礼品图片
        /// </summary>
        public string Picture
        {
            set { _picture = value; }
            get { return _picture; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Giftname
        {
            get { return _giftname; }
            set { _giftname = value; }
        }

        public DateTime addtime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }

    }
}
