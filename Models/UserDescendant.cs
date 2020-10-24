using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangjing.Model
{
    /// <summary>
    /// 用户下线
    /// </summary>
    public class UserDescendant
    {
        /// <summary>
        /// 记录是什么类型的(基本根据这个降手续费) wtype
        /// </summary>
        public int treelevel { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string headimgPath { get; set; }

        /// <summary>
        /// 直推队友数
        /// </summary>
        public int today { get; set; }

        /// <summary>
        /// 全部排线队友
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// 大区-人数 所有
        /// </summary>
        public int sharebig { get; set; }

        /// <summary>
        /// 小区-人数 排除最强直推
        /// </summary>
        public int shareout { get; set; }

        /// <summary>
        /// 0
        /// </summary>
        public int SaveType { get; set; }

        /// <summary>
        /// IsCertification=0已认证，IsCertification=1未认证
        /// </summary>
        public int IsCertification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Addtime { get; set; }

        /// <summary>
        /// 推荐码
        /// </summary>
        public string inviteNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int order { get; set; }
    }
}
