/*********************************************************************
 * CopyRight (c) 2009-2017 HangJing Teconology. All Rights Reserved.
 * FileName : PageArticles.cs
 * Function : ��ַʵ����
 * Created by zhouzhijian at 2017-7-26 16:53:41.
 * E-Mail   : zhouzhijian@ihangjing.com
*********************************************************************/
using System;
using System.Collections.Generic;

namespace Hangjing.Model
{
    /// <summary>
    /// ʵ����PageArticles ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class PageArticlesInfo
    {
        public PageArticlesInfo()  
        {  
            //  
            // TODO: �ڴ˴���ӹ��캯���߼�  
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
        /// �����Ƿ񹫿���������Ϊ0������Ϊ1��˽��Ϊ3������Ϊ2
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
        /// ��ͼƬ���ַ�λ��1��ʾ������ͼƬ�Ϸ���0��ʾ������ͼƬ�·�
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
        ///access_token(����uid|openid)
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
        /// (��ʱ�����ж�����ԭ�ж��ٸ�����)
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
        ///���������Զ�����1��Ϊ�Զ�����0��������
        /// </summary>
        public string autoplay_music
        {
            set;
            get;
        }
        /// <summary>
        ///ͼƬˮӡ1��Ϊ���ˮӡ0������ˮӡ
        /// </summary>
        public string enable_water_mark
        {
            set;
            get;
        }


    }
}

