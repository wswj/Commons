/*********************************************************************
 * CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
 * FileName : eaddress.cs
 * Function : ��ַʵ����
 * Created by jijunjian at 2010-7-26 16:53:41.
 * E-Mail   : jijunjian@ihangjing.com
*********************************************************************/
using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// ʵ����PageContentsInfo ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
        /// ��ʱ���ݣ��洢ѭ�����������ڸ�������
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

