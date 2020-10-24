using System;
using System.Text;
namespace Hangjing.Model
{
    public class F_KindInfo
    {
        #region 成员字段
        private long _k_ID = default(long);
        private long _f_ID = default(long);
        private string _k_Name = String.Empty;
        private DateTime _k_Publish = DateTime.Now;
        private string _K_Desc = String.Empty;
        #endregion
        #region 构造方法
        public F_KindInfo() { }
        #endregion
        #region 成员方法
        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(this.GetType().FullName);
            sb.Append(_f_ID);
            sb.Append(_k_Name);
            sb.Append(_k_Publish);
            sb.Append(_K_Desc);
            return sb.ToString().GetHashCode();
        }
        #endregion
        #region 成员属性
        ///<summary>
        ///一级分类从10开始，不大于2位数，二级分类如1010、1011
        ///</summary>
        public long K_ID
        {
            get
            {
                return _k_ID;
            }
            set
            {
                _k_ID = value;
            }
        }
        ///<summary>
        ///当为一级分类的时候为0，二级分类是如10，11，三级分类如1011、1012
        ///</summary>
        public long F_ID
        {
            get
            {
                return _f_ID;
            }
            set
            {
                _f_ID = value;
            }
        }
        ///<summary>
        ///分类名称
        ///</summary>
        public string K_Name
        {
            get
            {
                return _k_Name;
            }
            set
            {
                _k_Name = value;
            }
        }
        ///<summary>
        ///分类说明
        ///</summary>
        public string K_Desc
        {
            get
            {
                return _K_Desc;
            }
            set
            {
                _K_Desc = value;
            }
        }
        ///<summary>
        ///添加时间
        ///</summary>
        public DateTime K_Publish
        {
            get
            {
                return _k_Publish;
            }
            set
            {
                _k_Publish = value;
            }
        }
        #endregion
    }
}
