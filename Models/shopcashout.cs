using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Hangjing.Model
{

    /// <summary>
    /// 商家提现记录
    /// </summary>
    public class shopcashoutInfo
    {

        /// <summary>
        /// cid
        /// </summary>
        public int cid
        {
            get;
            set;
        }

        /// <summary>
        /// 提现金额
        /// </summary>
        public decimal wantmoney
        {
            get;
            set;
        }

        /// <summary>
        /// 用户编号
        /// </summary>
        public int shopid
        {
            get;
            set;
        }

        /// <summary>
        /// 提现时间
        /// </summary>
        public DateTime addtime
        {
            get;
            set;
        }

        /// <summary>
        /// 状态：0表示未处理，1表示已打款，2表示拒绝,3表示用户取消
        /// </summary>
        public int state
        {
            get;
            set;
        }

        /// <summary>
        /// 网站备注
        /// </summary>
        public string remark
        {
            get;
            set;
        }

        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime optime
        {
            get;
            set;
        }

        /// <summary>
        /// 处理管理员
        /// </summary>
        public string opuser
        {
            get;
            set;
        }

        /// <summary>
        /// reveint1
        /// </summary>
        public int reveint1
        {
            get;
            set;
        }

        /// <summary>
        /// reveint2
        /// </summary>
        public int reveint2
        {
            get;
            set;
        }

        /// <summary>
        /// reveint3
        /// </summary>
        public int reveint3
        {
            get;
            set;
        }

        /// <summary>
        /// reveint4
        /// </summary>
        public int reveint4
        {
            get;
            set;
        }

        /// <summary>
        /// reveint5
        /// </summary>
        public int reveint5
        {
            get;
            set;
        }

        /// <summary>
        /// revefloat1
        /// </summary>
        public decimal revefloat1
        {
            get;
            set;
        }

        /// <summary>
        /// revefloat2
        /// </summary>
        public decimal revefloat2
        {
            get;
            set;
        }

        /// <summary>
        /// revefloat3
        /// </summary>
        public decimal revefloat3
        {
            get;
            set;
        }

        /// <summary>
        /// 用户openid（提现到微信零钱使用）
        /// </summary>
        public string revevar1
        {
            get;
            set;
        }

        /// <summary>
        /// 目前用于用户手机（提现用户手机号）
        /// </summary>
        public string revevar2
        {
            get;
            set;
        }

        /// <summary>
        /// 提现用户名称
        /// </summary>
        public string revevar3
        {
            get;
            set;
        }

        /// <summary>
        /// revevar4
        /// </summary>
        public string revevar4
        {
            get;
            set;
        }

        /// <summary>
        /// revevar5
        /// </summary>
        public string revevar5
        {
            get;
            set;
        }
        /// <summary>
        /// 订单id
        /// </summary>
        public string orderid
        {
            get;
            set;
        }
        /// <summary>
        /// revetext
        /// </summary>
        public string revetext
        {
            get;
            set;
        }

        /// <summary>
        /// 提现订单开始时间
        /// </summary>
        public DateTime starttime
        {
            get;
            set;
        }

        /// <summary>
        /// 提现订单结算时间
        /// </summary>
        public DateTime endtime
        {
            get;
            set;
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string TogoName
        {
            get;
            set;
        }
        /// <summary>
        /// 用户openid
        /// </summary>
        public string openid
        {
            get;
            set;
        }

    }
}

