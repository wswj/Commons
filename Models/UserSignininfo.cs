using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// 会员签到表
    /// </summary>
    //[Serializable]
    public partial class UserSignininfo
    {
        public UserSignininfo()
        { }
        #region Model
        private int _ID;
        private int _UserID = 0;
        private int _Integral = 0;
        private DateTime _SignTime = DateTime.Now;
        private DateTime _AddTime = DateTime.Now;
        private string _Reve1 = string.Empty;

        private string _ContinuitySignDay = string.Empty;//连续签到天数
        private string _SignCount = string.Empty;   //总签到次数
        private string _TotalIntegral = string.Empty; //签到获得的积分

        /// <summary>
        ///  连续签到天数
        /// </summary>
        public string ContinuitySignDay
        {
            set { _ContinuitySignDay = value; }
            get { return _ContinuitySignDay; }
        }
        /// <summary>
        ///  总签到次数
        /// </summary>
        public string SignCount
        {
            set { _SignCount = value; }
            get { return _SignCount; }
        }
        /// <summary>
        ///  签到获得的积分
        /// </summary>
        public string TotalIntegral
        {
            set { _TotalIntegral = value; }
            get { return _TotalIntegral; }
        }
        /// <summary>
        /// 自增ID
        /// </summary>
        public int ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID
        {
            set { _UserID = value; }
            get { return _UserID; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public int Integral
        {
            set { _Integral = value; }
            get { return _Integral; }
        }
        /// <summary>
        /// 签到时间
        /// </summary>
        public DateTime SignTime
        {
            set { _SignTime = value; }
            get { return _SignTime; }
        } 
        
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime AddTime
        {
            set { _AddTime = value; }
            get { return _AddTime; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string Reve1
        {
            set { _Reve1 = value; }
            get { return _Reve1; }
        }
        #endregion
    }
}