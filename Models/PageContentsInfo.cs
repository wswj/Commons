/*********************************************************************
 * CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
 * FileName : eaddress.cs
 * Function : 地址实现类
 * Created by jijunjian at 2010-7-26 16:53:41.
 * E-Mail   : jijunjian@ihangjing.com
*********************************************************************/
using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// 实体类PageContentsInfo 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class PageContentsInfo
    {


        /// <summary>
        /// 
        /// </summary>
        public string video_thumbnail
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Dataid
        {
            set;
            get;
        }
        
        /// <summary>
        /// 临时数据，存储循环的数字用于更新数据
        /// </summary>
        public int reveint
        {
            set;
            get;
        }

       
        /// <summary>
        ///
        /// </summary>
        public string text
        {
            get;
            set;
        }

       
        /// <summary>
        /// 
        /// </summary>
        public string img_url
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public string video_id
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public string video_url
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public string link
        {
            set;
            get;
        }

        /// <summary>
        ///
        /// </summary>
        public string link_desc
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime createtime
        {
            set;
            get;
        }



        /// <summary>
        /// 
        /// </summary>
        public string ArticlesId
        {
            set;
            get;
        }

       
    }
}

