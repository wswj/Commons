using System;
using System.Text;
namespace Hangjing.Model
{
    public class A_AreaInfo
    {
        #region 成员字段
        private int _iD = default(int);
        private int _parent_ID = default(int);
        private string _a_Name = String.Empty;
        #endregion
        #region 构造方法
        public A_AreaInfo() { }
        #endregion
        #region 成员方法
        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(this.GetType().FullName);
            sb.Append(_parent_ID);
            sb.Append(_a_Name);
            return sb.ToString().GetHashCode();
        }
        #endregion
        #region 成员属性
        ///<summary>
        ///地域ID
        ///</summary>
        public int ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
            }
        }
        ///<summary>
        ///父级ID
        ///</summary>
        public int Parent_ID
        {
            get
            {
                return _parent_ID;
            }
            set
            {
                _parent_ID = value;
            }
        }
        ///<summary>
        ///地域名称
        ///</summary>
        public string A_Name
        {
            get
            {
                return _a_Name;
            }
            set
            {
                _a_Name = value;
            }
        }
        #endregion
    }
}
