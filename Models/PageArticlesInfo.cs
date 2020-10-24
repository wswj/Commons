/*********************************************************************
 * CopyRight (c) 2009-2017 HangJing Teconology. All Rights Reserved.
 * FileName : PageArticles.cs
 * Function : 地址实现类
 * Created by zhouzhijian at 2017-7-26 16:53:41.
 * E-Mail   : zhouzhijian@ihangjing.com
*********************************************************************/
using System;
using System.Collections.Generic;

namespace Hangjing.Model
{
    /// <summary>
    /// 实体类PageArticles 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class PageArticlesInfo
    {
        public PageArticlesInfo()  
        {  
            //  
            // TODO: 在此处添加构造函数逻辑  
            // 
        }
        /// <summary>
        /// 
        /// </summary>
        public string action
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string controller
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>

        public string Abstract
        {
            set;
            get;
        }
            /// <summary>
        /// 
        /// </summary>
        public string access_token
        {
            set;
            get;
        }



        /// <summary>
        /// 
        /// </summary>
        public int dataid
        {
            set;
            get;
        }
         /// <summary>
        /// 
        /// </summary>
        public string article_id
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string cover_img_url
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime create_time
        {
            set;
            get;
        }
        /// <summary>
        /// 文字是否公开，不公开为0，公开为1，私密为3，加密为2
        /// </summary>
        public int privacy
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int visit_count
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int praise_count
        {
            set;
            get;
        }
        /// <summary>
        ///
        /// </summary>
        public int comment_count
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public int rcmd_state
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public int theme
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public string music_url
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public string music_desc
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public int category_id
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public string password
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public int state
        {
            set;
            get;
        }

        /// <summary>
        /// （图片文字方位）1表示文章在图片上方，0表示文字在图片下方
        /// </summary>
        public string text_pos
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public int cover_crop
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public string enable_comment
        {
            set;
            get;
        }
       
        /// <summary>
        /// 
        /// </summary>
        public IList<Hangjing.Model.PageContentsInfo> content
        {
            set;
            get;
        }

        /// <summary>
        ///access_token(保存uid|openid)
        /// </summary>
        public string EContent
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public int reve1
        {
            set;
            get;
        }

        /// <summary>
        /// (暂时用于判断文章原有多少个段落)
        /// </summary>
        public string Reve2
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string video_thumbnail
        {
            set;
            get;
        }
        /// <summary>
        ///背景音乐自动播放1：为自动播放0：不播放
        /// </summary>
        public string autoplay_music
        {
            set;
            get;
        }
        /// <summary>
        ///图片水印1：为添加水印0：不加水印
        /// </summary>
        public string enable_water_mark
        {
            set;
            get;
        }


    }
}

