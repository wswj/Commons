
// �û������¼
// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// jijunjian@ihangjing.com
// 2010-03-05

using System;
namespace Hangjing.Model
{
    public enum PointEventType
    {
        /// <summary>
        /// (����ֵ�ͷ�)
        /// </summary>
        release = 0,
        /// <summary>
        /// (��ȡ�Ҳ���)
        /// </summary>
        getperhour = 1,
        /// <summary>
        /// (����)
        /// </summary>
        sale = 2,
        /// <summary>
        /// (����֧��/����)
        /// </summary>
        pay = 3,
        /// <summary>
        /// (���)
        /// </summary>
        buy = 4,
        /// <summary>
        /// (���߹���)
        /// </summary>
        lowpay = 5,
        /// <summary>
        /// (�쵼����)
        /// </summary>
        superreward = 6,
        /// <summary>
        /// (����)
        /// </summary>
        buymachine = 7,
        /// <summary>
        /// (�򷽾ܾ���Ǯ���˻�)
        /// </summary>
        salenopay = 8,
        /// <summary>
        /// (���Ѵ�Ǯ��ȷ�ϣ��Զ��ɽ�)
        /// </summary>
        timeout = 9,
        /// <summary>
        /// (�Ƽ�һ���û���������ֵ)
        /// </summary>
        actpoint = 10,
        /// <summary>
        /// ���ѳ�ֵused
        /// </summary>
        addmobile = 11,
        /// <summary>
        /// ǩ�� ����used
        /// </summary>
        usersignin = 12,
        /// <summary>
        /// ת���ɶ�
        /// </summary>
        giveother = 13,
        /// <summary>
        /// ���˷ֺ�
        /// </summary>
        givelevel = 14,
        /// <summary>
        /// �������
        /// </summary>
        tixian = 15,
        /// <summary>
        /// �Ϲ���ֵ
        /// </summary>
        chongzhi = 16,

    }

    /// <summary>
    /// ʵ����EPointRecord ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class EPointRecordInfo
    {
        private int _dataid;
        private int _userid;
        private decimal _point;
        private string _event;
        private DateTime _time;
        private string _uname;


        private int _type;
        /// <summary>
        /// ����...
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }


        /// <summary>
        /// �û�����
        /// </summary>
        public string uname
        {
            set { _uname = value; }
            get { return _uname; }
        }

        /// <summary>
        /// ������
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid; }
        }
        /// <summary>
        /// �û����
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// �仯����
        /// </summary>
        public decimal Point
        {
            set { _point = value; }
            get { return _point; }
        }

        /// <summary>
        /// ������ǹ��� �����жԱ�У�飩
        /// </summary>
        public decimal Amount
        {
            set;
            get;
        }
        /// <summary>
        /// �û����ǹ�����
        /// </summary>
        public decimal totalsweet
        {
            set;
            get;
        }
        /// <summary>
        /// ��ǰ����
        /// </summary>
        public decimal curpoint
        {
            set;
            get;
        }

        /// <summary>
        /// �仯���֣���ʽ�ģ�,������
        /// </summary>
        public decimal changepoint
        {
            set;
            get;
        }

        /// <summary>
        /// �����ͣ�1:�ɶ�  2������ֵ 3:ppc
        /// </summary>
        public int transferfee
        {
            set;
            get;
        }

        /// <summary>
        /// �û�ͷ��
        /// </summary>
        public string uPicture
        {
            set;
            get;
        }


        /// <summary>
        /// ��¼���ұ�ע
        /// </summary>
        public string Event
        {
            set { _event = value; }
            get { return _event; }
        }
        /// <summary>
        ///��ǰʱ�� 
        /// </summary>
        public DateTime Time
        {
            set { _time = value; }
            get { return _time; }
        }
    }
}

