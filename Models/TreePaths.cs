/*********************************************************************
 * CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
 * Function : 用户上下级结构
 * Created by jijunjian at 2010-8-21 14:26:16.
 * E-Mail   : jijunjian@ihangjing.com
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// 用户上下级结构
    /// </summary>
    public class TreePaths
    {

        /// <summary>
        /// 上级
        /// </summary>
        public int ancestor
        {
            set;
            get;
        }

        /// <summary>
        /// 下级
        /// </summary>
        public int descendant
        {
            set;
            get;
        }
       
    }
}
