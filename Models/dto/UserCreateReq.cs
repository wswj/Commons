using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangjing.Model.dto
{
    /// <summary>
    /// 用户创建请求
    /// </summary>
    public  class UserCreateReq
    {
        /// <summary>
        /// 手机号
        /// </summary>
        public String phone { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String password { get; set; }

        /// <summary>
        /// 推荐码（推荐人手机号）
        /// </summary>
        public String invateCode { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public String headImg { get; set; }

    }
}
