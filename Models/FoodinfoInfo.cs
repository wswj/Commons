using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    [Serializable]
    public class FoodinfoInfo
    {
        private int _unid;
        private string _inuse;
        private string _foodno;
        private decimal _fprice;
        private DateTime _fpindate;
        private DateTime _fpactivedate;
        private int _fpmaster;
        private string _foodname;
        private string _foodnamepy;
        private decimal _fullprice;
        private int _remains;
        private int _maxperday;
        private string _taste;
        private string _picture;
        private int _foodtype;
        private string _sortName;
        private string _togoName;
        private int _ordernum;
        private int _isrecommend;
        private int _isspecial;
        private string _opentime;
        private int _isauth;
        private int _salecount;
        private string _imgtype;
        private string _nextandpre;
        private string _togoTel;

        public decimal xprice
        {
            set;
            get;
        }
        /// <summary>
        /// 修改为商家总销量（投票数）
        /// </summary>
        public int procount
        {
            set;
            get;
        }
        /// <summary>
        /// 商家图片
        /// </summary>
        public string shoppic
        {
            set;
            get;
        }
        /// <summary>
        /// 商家产品数量
        /// </summary>
        public string productcount
        {
            set;
            get;
        }

        private long _p_Logistic = default(long);
        ///<summary>
        ///包含物流模板的ID，如果不使用模板，添加0为包邮(模版选择需要注意模板内所添加的物流类型，和此表的“是否快递方式”字段要对应)
        ///</summary>
        public long P_Logistic
        {
            get
            {
                return _p_Logistic;
            }
            set
            {
                _p_Logistic = value;
            }
        }
        private int _p_Fast = default(int);

        ///<summary>
        ///是否快递方式，0为不是，1是(添加订单时，两种物流方式都存在的话需分开提交)
        ///</summary>
        public int P_Fast
        {
            get
            {
                return _p_Fast;
            }
            set
            {
                _p_Fast = value;
            }
        }

        /// <summary>
        /// 用户编号，记录哪个用户上传产品
        /// </summary>
        public int reveint
        {
            set;
            get;
        }
        /// <summary>
        /// 商品模板id
        /// </summary>
        public string templateid
        {
            set;
            get;
        }
        /// <summary>
        /// 团购结束时间
        /// </summary>
        public DateTime endDatetime
        {
            set;
            get;
        }
        /// <summary>
        /// 为0，根据糖果当前价格判断需要多少糖果，大于0，表示需要多少个糖果
        /// </summary>
        public decimal discount
        {
            set;
            get;
        }


        /// <summary>
        /// 服务标签
        /// </summary>
        public string nametag
        {
            set;
            get;
        }
        /// <summary>
        /// 商品标签
        /// </summary>
        public string msgtag
        {
            set;
            get;
        }
        /// <summary>
        /// 商品分类id
        /// </summary>
        public long K_ID
        {
            set;
            get;
        }
        /// <summary>
        /// 商品的评论内容(最新)
        /// </summary>
        public string plopinion
        {
            set;
            get;
        }

        /// <summary>
        /// 评论数
        /// </summary>
        public int plping
        {
            set;
            get;
        }
       
        /// <summary>
        /// 综合积分
        /// </summary>
        public int subpoint
        {
            set;
            get;
        }

        /// <summary>
        /// 商品的
        /// </summary>
        public IList<FBPicInfo> propic
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的html（上一个，下一个）
        /// </summary>
        public string nextandpre
        {
            set { _nextandpre = value; }
            get { return _nextandpre; }
        }
        /// <summary>
        /// 产品标签列表
        /// </summary>
        public IList<ShopFoodPictureInfo> pictags
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的 标签
        /// </summary>
        public string imgtype
        {
            set { _imgtype = value; }
            get { return _imgtype; }
        }

        /// <summary>
        /// 销售份数
        /// </summary>
        public int salecount
        {
            get { return _salecount; }
            set { _salecount = value; }
        }

        /// <summary>
        /// 10:00:00-12:00:00/14:00:00-23:00:00;
        /// </summary>
        public string OpenTime
        {
            set { _opentime = value; }
            get { return _opentime; }
        }
        /// <summary>
        /// 0表示未审核，1表示审核了
        /// </summary>
        public int isauth
        {
            get { return _isauth; }
            set { _isauth = value; }
        }

        /// <summary>
        /// 统计是否推荐
        /// </summary>
        public int IsRecommend
        {
            get { return _isrecommend; }
            set { _isrecommend = value; }
        }

        /// <summary>
        /// 是否特价
        /// </summary>
        public int IsSpecial
        {
            get { return _isspecial; }
            set { _isspecial = value; }
        }

        /// <summary>
        /// 商品排序
        /// </summary>
        public int OrderNum
        {
            get { return _ordernum; }
            set { _ordernum = value; }
        }

        /// <summary>
        /// 商家名
        /// </summary>
        public string TogoName
        {
            get { return _togoName; }
            set { _togoName = value; }
        }

        /// <summary>
        /// 类型名
        /// </summary>
        public string SortName
        {
            get { return _sortName; }
            set { _sortName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Unid
        {
            set { _unid = value; }
            get { return _unid; }
        }

        /// <summary>
        /// y 上架，n 下架，d  删除
        /// </summary>
        public string InUse
        {
            set { _inuse = value; }
            get { return _inuse; }
        }

        /// <summary>
        /// 菜品号 暂未使用 未知功能
        /// </summary>
        public string FoodNo
        {
            set { _foodno = value; }
            get { return _foodno; }
        }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal FPrice
        {
            set { _fprice = value; }
            get { return _fprice; }
        }

        /// <summary>
        /// 商品录入日期
        /// </summary>
        public DateTime FPInDate
        {
            set { _fpindate = value; }
            get { return _fpindate; }
        }

        /// <summary>
        /// 活动截止日期
        /// </summary>
        public DateTime FPActiveDate
        {
            set { _fpactivedate = value; }
            get { return _fpactivedate; }
        }

        /// <summary>
        /// 菜品隶属餐馆编号
        /// </summary>
        public int FPMaster
        {
            set { _fpmaster = value; }
            get { return _fpmaster; }
        }

        /// <summary>
        /// 菜品名
        /// </summary>
        public string FoodName
        {
            set { _foodname = value; }
            get { return _foodname; }
        }

        /// <summary>
        /// 拼音
        /// </summary>
        public string FoodNamePy
        {
            set { _foodnamepy = value; }
            get { return _foodnamepy; }
        }

        /// <summary>
        /// 原价
        /// </summary>
        public decimal FullPrice
        {
            set { _fullprice = value; }
            get { return _fullprice; }
        }
        /// <summary>
        ///  剩余数量
        /// </summary>
        public int Remains
        {
            set { _remains = value; }
            get { return _remains; }
        }

        /// <summary>
        /// 每日最大供应量 库存
        /// </summary>
        public int MaxPerDay
        {
            set { _maxperday = value; }
            get { return _maxperday; }
        }

        /// <summary>
        /// 口味
        /// </summary>
        public string Taste
        {
            set { _taste = value; }
            get { return _taste; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Picture
        {
            set { _picture = value; }
            get { return _picture; }
        }

        /// <summary>
        /// 类型
        /// </summary>
        public int FoodType
        {
            set { _foodtype = value; }
            get { return _foodtype; }
        }


        /// <summary>
        /// 商家电话
        /// </summary>
        public string togoTel
        {
            set { _togoTel = value; }
            get { return _togoTel; }
        }

    }
}
