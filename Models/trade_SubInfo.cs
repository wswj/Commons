using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// ������Ϣ
    /// </summary>
    //[Serializable]
    public class trade_SubInfo
    {
        
        /// <summary>
        /// ��ǰ�ǹ��۸�
        /// </summary>
        public decimal amount
        {
            set;
            get;
        }

        /// <summary>
        /// �Ƿ�Ͷ��0 δͶ��1�Ѿ�Ͷ��
        /// </summary>
        public int paytype
        {
            set;
            get;
        }
         /// <summary>
         /// ������������������������
         /// </summary>
        public int profit
        {
            set;
            get;
        }
        /// <summary>
        /// Ͷ������ƾ֤=affairs
        /// </summary>
        public string future
        {
            set;
            get;
        }
        /// <summary>
        /// //ʶ��ö��������ͣ�1�󹺶�����2������������Ӧ�����������ݸ��ݴ��ֶμ�¼���ݣ����ֻ���Ϊ������Ϊ�������ţ�Ϊ�򣬼�Ϊ�����Ϣ��
        /// </summary>
        public int period
        {
            set;
            get;
        }
        /// <summary>
        ///�ϴ���ͼƬ·��
        /// </summary>
        public string direction
        {
            set;
            get;
        }
        /// <summary>
        /// ����ϵͳ����δ������۱���������Ϊ��۱��ʣ���ʵ�۸�Ϊϵͳ����*��۱��� �����ǹ��ļ۸� �������۸�
        /// </summary>
        public decimal open_price
        {
            set;
            get;
        }
        /// <summary>
        /// �û����
        /// </summary>
        public int userId
        {
            set;
            get;
        }
        /// <summary>
        /// (��¼�û����𣬷�ֹ���ǹ������������˳���)0��ֹ���ף�1=50%,2=35% ,3=30%,4=28%,5=25%
        /// </summary>
        public string activecode
        {
            set;
            get;
        }
        /// <summary>
        /// ���ҵ�id�������id,��type����
        /// </summary>
        public decimal adduser
        {
            set;
            get;
        } 

        /// <summary>
        /// �ֻ�����
        /// </summary>
        public string sham
        {
            set;
            get;
        } 
       
        /// <summary>
        /// ���ɽ��۸�
        /// </summary>
        public decimal close_price
        {
            set;
            get;
        }
        /// <summary>
        /// ���׿�ʼʱ��
        /// </summary>
        public DateTime openTime
        {
            set;
            get;
        }

        /// <summary>
        ///  ���ɶ���id
        /// </summary>
        public string orderid
        {
            set;
            get;
        }
        /// <summary>
        /// �Ѿ��ɽ������ɽ�������ɣ����׵����ҵ�������(0or1:Ϊ���׵�(0,Ϊ����û���ϴ������Ƭ��1��ʾӦ��δ��2�Ѿ�����ϴ���ͼ)��0:�ҵ�����Ϣ��-1����������3�����)
        /// </summary>
        public int status
        {
            set;
            get;
        }
        /// <summary>
        /// ��¼�û���ǰ�ȼ�����������ʱ��������˵���������ݵȼ�������ʣ�Ҳ����ݵȼ������û��ǹ�����ֹ�û�����ǰ����������Ϣ�������������ͻᵼ�����ݴ�������
        /// </summary>
        public string result
        {
            set;
            get;
        }

        /// <summary>
        ///  ���׵���ʱ
        /// </summary>
        public DateTime millisecond 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ���׽���ʱ��
        /// </summary>
        public DateTime closeTime { get; set; }

        //�Ƿ����۸�ͬ��0�رգ�1����
        public string synchroPrice { get; set; }

        //�Ƿ������ͬ��0�ز�����0�򿪣���ʾΪ��۱�����
        public string multiplePrice { get; set; }
    }
}

