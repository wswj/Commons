using System;
using System.Collections.Generic;
namespace Hangjing.Model
{
    /// <summary>
    /// �����󹺼����׶�����Ϣ
    /// </summary>
    [Serializable]
    public class trade_orderInfo
    {
        public trade_orderInfo()
        { }
        #region Model
        private string _id;
        private string _userid;
        private string _sham;
        private decimal _amount;
        private int _profit;
        private string _future;
        private string _direction;
        private int _period;
        private DateTime _opentime;
        private decimal _openprice;
        private DateTime _closetime;
        private decimal _closeprice;
        private string _result;
        private int _status;
        private DateTime _millisecond;


        private string _userphone;
        /// <summary>
        /// �û��ֻ�������֪ͨӦ������
        /// </summary>
        public string userphone
        {
            set { _userphone = value; }
            get { return _userphone; }
        }

        private string _truename;
        /// <summary>
        /// �û���ʵ����
        /// </summary>
        public string truename
        {
            set { _truename = value; }
            get { return _truename; }
        }

        private string _userpicture;
        /// <summary>
        /// �û�ͷ��
        /// </summary>
        public string userpicture
        {
            set { _userpicture = value; }
            get { return _userpicture; }
        }


        private string _adduserpicture;
        /// <summary>
        /// �û�ͷ��
        /// </summary>
        public string adduserPicture
        {
            set { _adduserpicture = value; }
            get { return _adduserpicture; }
        }


        private string _statehtml;
        /// <summary>
        /// ״̬��
        /// </summary>
        public string statehtml
        {
            set { _statehtml = value; }
            get { return _statehtml; }
        }

        private string _yiwancheng;
        /// <summary>
        /// ���ҳ�渳ֵ
        /// </summary>
        public string yiwancheng
        {
            set { _yiwancheng = value; }
            get { return _yiwancheng; }
        }

        private IList<IntegralInfo> _ItemList;
        /// <summary>
        /// �û�������Ӧ���û�֧����Ϣ
        /// </summary>
        public IList<IntegralInfo> ItemList
        {
            set { _ItemList = value; }
            get { return _ItemList; }
        }

        private string _pagehtml;
        /// <summary>
        /// ��ֵ�û�ҳ��html
        /// </summary>
        public string pagehtml
        {
            set { _pagehtml = value; }
            get { return _pagehtml; }
        }

        private int _adduser;
        /// <summary>
        /// ����ID����Ӧ������Ϊ�󹺶���ʱ��Ϊ���򷽣�Ϊ������֮��
        /// </summary>
        public int adduser
        {
            set { _adduser = value; }
            get { return _adduser; }
        }

        private string _useraccode;
        /// <summary>
        /// �û��ǹ�����
        /// </summary>
        public string useraccode
        {
            set { _useraccode = value; }
            get { return _useraccode; }
        }

        private string _username;
        /// <summary>
        /// �û�����
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }

        private string _addusername;
        /// <summary>
        /// �����û����� ��Ӧ�������������򵥻���������
        /// </summary>
        public string addusername
        {
            set { _addusername = value; }
            get { return _addusername; }
        }
        private string _addtruename;
        /// <summary>
        /// �����û���ʵ����
        /// </summary>
        public string addtruename
        {
            set { _addtruename = value; }
            get { return _addtruename; }
        }

        private string _adduserphone;
        /// <summary>
        /// �����û���ʵ�ֻ���
        /// </summary>
        public string adduserphone
        {
            set { _adduserphone = value; }
            get { return _adduserphone; }
        }

        private string _buyphone;
        /// <summary>
        /// ���򷽵绰����
        /// </summary>
         public string buyphone
        {
            set { _buyphone = value; }
            get { return _buyphone; }
        }
        private string _openid;
        /// <summary>
        /// _openid��Ψһ��ţ�
        /// </summary>
        public string openid
        {
            set { _openid = value; }
            get { return _openid; }
        }

        private string _orderid;
        /// <summary>
        /// �������
        /// </summary>
        public string orderid
        {
            set { _orderid = value; }
            get { return _orderid; }
        }

        /// <summary>
        /// ���������
        /// </summary>
        public string id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// �û���ţ������߱�ţ���Ϊ�� �������߱�ţ�
        /// </summary>
        public string userId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// �û��ֻ��������ߣ�
        /// </summary>
        public string sham
        {
            set { _sham = value; }
            get { return _sham; }
        }
        /// <summary>
        /// ���׵�ǰ�۸񣨿����۸�ͬ����ÿ���Զ����µ��¼۸�Ĭ��Ϊԭʼ���ۣ�
        /// </summary>
        public decimal amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public int profit
        {
            set { _profit = value; }
            get { return _profit; }
        }
        /// <summary>
        /// ��Ҫ�ϴ��Ĵ��ƾ֤(�ж��Ƿ�֧��)=future
        /// </summary>
        public string future
        {
            set { _future = value; }
            get { return _future; }
        }
        /// <summary>
        /// ͼƬ��Ϣ��Ϣ
        /// </summary>
        public string direction
        {
            set { _direction = value; }
            get { return _direction; }
        }
        /// <summary>
        /// ������Ϣ���ͣ�1�����룬2������ ��
        /// </summary>
        public int period
        {
            set { _period = value; }
            get { return _period; }
        }
        /// <summary>
        /// ���׿�ʼʱ��
        /// </summary>
        public DateTime openTime
        {
            set { _opentime = value; }
            get { return _opentime; }
        }
        /// <summary>
        ///   ��ԭʼ����
        /// </summary>
        public decimal openPrice
        {
            set { _openprice = value; }
            get { return _openprice; }
        }
        /// <summary>
        /// ���׽������رգ�ʱ��ȷ�ϴ��ʱ��
        /// </summary>
        public DateTime closeTime
        {
            set { _closetime = value; }
            get { return _closetime; }
        }
        /// <summary>
        ///  ���ճɽ��۸�
        /// </summary>
        public decimal closePrice
        {
            set { _closeprice = value; }
            get { return _closeprice; }
        }
        /// <summary>
        /// (������ɺ���ʾ��ɽ��)
        /// </summary>
        public string result
        {
            set { _result = value; }
            get { return _result; }
        }
        /// <summary>
        /// �Ѿ��ɽ������ɽ�������ɣ����׵����ҵ�������(0or1:Ϊ���׵�(1,Ϊ����ƥ��ɹ�û���ϴ������Ƭ��1��ʾ�ܾ����)��0:�ҵ�����Ϣ��-1����������2Ͷ����...,3,�����Ѿ����,4��ɶ�����ʱ�Ѿ��˻�ȥ����ʾ���Ѿ��˻أ�)
        /// </summary>
        public int status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// ʹ�õ���ʱ����
        /// </summary>
        public DateTime millisecond
        {
            set { _millisecond = value; }
            get { return _millisecond; }
        }

        /// <summary>
        /// �Ƿ����۸�ͬ��0��1��
        /// </summary>
        public string synchroPrice
        {
            set;
            get;
        }
        /// <summary>
        /// �Ƿ������ͬ��0�ز�����0�򿪣���ʾΪ��۱�����
        /// </summary>
        public string multiplePrice
        {
            set;
            get;
        }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime addtime
        {
            set;
            get;
        }

        /// <summary>
        /// ������
        /// </summary>
        public int tempid
        {
            set;
            get;
        }

        /// <summary>
        /// �ö����Ƿ�Ͷ�ߣ�0δͶ�ߡ�1�Ѿ�Ͷ��
        /// </summary>
        public int paytype
        {
            set;
            get;
        } 
        /// <summary>
        /// ����ɽ���������
        /// </summary>
        public int ordercount
        {
            set;
            get;
        }
        /// <summary>
        /// �ܽ��׶�������
        /// </summary>
        public int allordercount
        {
            set;
            get;
        } 
         /// <summary>
        /// �ܽ��׶����𶹸���
        /// </summary>
        public int totalcount
        {
            set;
            get;
        } 
        /// <summary>
        /// �û��ȼ�����������ȼ��ж��������ʣ�
        /// </summary>
        public string activecode
        {
            set;
            get;
        }
        #endregion Model
    }
}

