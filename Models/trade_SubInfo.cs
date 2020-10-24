using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// 订单信息
    /// </summary>
    //[Serializable]
    public class trade_SubInfo
    {
        
        /// <summary>
        /// 当前糖果价格
        /// </summary>
        public decimal amount
        {
            set;
            get;
        }

        /// <summary>
        /// 是否被投诉0 未投诉1已经投诉
        /// </summary>
        public int paytype
        {
            set;
            get;
        }
         /// <summary>
         /// 购买数量（或者卖出数量）
         /// </summary>
        public int profit
        {
            set;
            get;
        }
        /// <summary>
        /// 投诉问题凭证=affairs
        /// </summary>
        public string future
        {
            set;
            get;
        }
        /// <summary>
        /// //识别该订单的类型，1求购订单，2，卖出果订单应单（数据内容根据此字段记录数据，如手机，为买数据为卖家相信，为买，即为买家信息）
        /// </summary>
        public int period
        {
            set;
            get;
        }
        /// <summary>
        ///上传打开图片路径
        /// </summary>
        public string direction
        {
            set;
            get;
        }
        /// <summary>
        /// 等于系统定价未开启溢价倍数，开启为溢价倍率，真实价格为系统定价*溢价倍率 交易糖果的价格 （发布价格）
        /// </summary>
        public decimal open_price
        {
            set;
            get;
        }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int userId
        {
            set;
            get;
        }
        /// <summary>
        /// (记录用户级别，防止退糖果或者升级后退出错)0禁止交易，1=50%,2=35% ,3=30%,4=28%,5=25%
        /// </summary>
        public string activecode
        {
            set;
            get;
        }
        /// <summary>
        /// 卖家的id或者买家id,看type类型
        /// </summary>
        public decimal adduser
        {
            set;
            get;
        } 

        /// <summary>
        /// 手机号码
        /// </summary>
        public string sham
        {
            set;
            get;
        } 
       
        /// <summary>
        /// 最后成交价格
        /// </summary>
        public decimal close_price
        {
            set;
            get;
        }
        /// <summary>
        /// 交易开始时间
        /// </summary>
        public DateTime openTime
        {
            set;
            get;
        }

        /// <summary>
        ///  生成订单id
        /// </summary>
        public string orderid
        {
            set;
            get;
        }
        /// <summary>
        /// 已经成交，待成交，已完成，交易单，我的求购买入(0or1:为交易单(0,为交易没有上传打款照片，1显示应单未打款，2已经打款上传截图)，0:我的求购信息，-1撤销订单，3已完成)
        /// </summary>
        public int status
        {
            set;
            get;
        }
        /// <summary>
        /// 记录用户当前等级（订单结束时候处理结果及说明）（根据等级计算费率，也会根据等级返回用户糖果）防止用户升级前发布卖出信息，升级后撤销，就会导致数据错误问题
        /// </summary>
        public string result
        {
            set;
            get;
        }

        /// <summary>
        ///  交易倒计时
        /// </summary>
        public DateTime millisecond 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        public DateTime closeTime { get; set; }

        //是否开启价格同步0关闭，1开启
        public string synchroPrice { get; set; }

        //是否开启溢价同步0关不等于0则开（显示为溢价倍数）
        public string multiplePrice { get; set; }
    }
}

