using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// ��Աǩ����
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

        private string _ContinuitySignDay = string.Empty;//����ǩ������
        private string _SignCount = string.Empty;   //��ǩ������
        private string _TotalIntegral = string.Empty; //ǩ����õĻ���

        /// <summary>
        ///  ����ǩ������
        /// </summary>
        public string ContinuitySignDay
        {
            set { _ContinuitySignDay = value; }
            get { return _ContinuitySignDay; }
        }
        /// <summary>
        ///  ��ǩ������
        /// </summary>
        public string SignCount
        {
            set { _SignCount = value; }
            get { return _SignCount; }
        }
        /// <summary>
        ///  ǩ����õĻ���
        /// </summary>
        public string TotalIntegral
        {
            set { _TotalIntegral = value; }
            get { return _TotalIntegral; }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public int ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        /// <summary>
        /// �û�ID
        /// </summary>
        public int UserID
        {
            set { _UserID = value; }
            get { return _UserID; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int Integral
        {
            set { _Integral = value; }
            get { return _Integral; }
        }
        /// <summary>
        /// ǩ��ʱ��
        /// </summary>
        public DateTime SignTime
        {
            set { _SignTime = value; }
            get { return _SignTime; }
        } 
        
        /// <summary>
        /// ��¼ʱ��
        /// </summary>
        public DateTime AddTime
        {
            set { _AddTime = value; }
            get { return _AddTime; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string Reve1
        {
            set { _Reve1 = value; }
            get { return _Reve1; }
        }
        #endregion
    }
}