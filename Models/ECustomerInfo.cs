using System;
namespace Hangjing.Model
{
	/// <summary>
	/// ʵ����EUser ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ECustomerInfo
	{
        private int _dataid;
        private string _name;
        private string _truename;
        private string _sex;
        private string _tell;
        private string _phone;
        private string _qq;
        private string _msn;
        private DateTime _regtime;
        private decimal _point;
        private string _picture;
        private string _state;
        private string _email;
        private string _password;
        private int _isavtivate;
        private string _avtivatecode;
        private decimal _groupid;
        private string _website;
        private string _rid;
        private decimal _usermoney;
        private int _phoneActivate;

        private string _PayPassword;
        private string _PayPWDQuestion;
        private string _PayPWDAnswer;
        private string _lastordertime;
        private string _bigpicture;
        private string _openid;
        private string _wtype;
        private decimal _xiaoquact;
        private int _jiebang;
        private string _introduce;
        private int _RsCount;

        /// <summary>
        /// ������
        /// </summary>
        public int jiebang
        {
            set { _jiebang = value; }
            get { return _jiebang; }
        }
        private decimal _gongxian;
        /// <summary>
        /// (����ֵ)����ֵ
        /// </summary>
        public decimal gongxian
        {
            set { _gongxian = value; }
            get { return _gongxian; }
        }
        private int _tuiguang;
        /// <summary>
        /// �ƹ�����
        /// </summary>
        public int tuiguang
        {
            set { _tuiguang = value; }
            get { return _tuiguang; }
        }
        private int _grade;
        /// <summary>
        /// ��֤�ȼ�״̬��is_auth��0δͨ���κ���֤ �������߼���֤��ťȫ����ʾ1://�����֧����˵��������֤��û��ͨ�� ��Ҳ��ʾ�������߼���ť��
        ///��is_auth��2������֤�Ѿ�ͨ��  ��ʾ�߼���֤��ť  ��  ������֤����֤��,3.�߼���֤ͨ��  ��ť�����߼���ťȫ���� ��ʾ���� �߼���֤��
        /// </summary>
        public int grade
        {
            set { _grade = value; }
            get { return _grade; }
        }
        private DateTime _buildtime;
        /// <summary>
        /// �û��Ƿ��ܹ���
        /// </summary>
        public DateTime buildtime
        {
            set { _buildtime = value; }
            get { return _buildtime; }
        }

        private decimal _SumAmount;
        /// <summary>
        /// �����û�����
        /// </summary>
        public decimal SumAmount
        {
            set { _SumAmount = value; }
            get { return _SumAmount; }
        }

        private string _tuiPhone;
        /// <summary>
        /// �Ƽ����ֻ�
        /// </summary>
        public string tuiPhone
        {
            set { _tuiPhone = value; }
            get { return _tuiPhone; }
        }

        private string _tuiname;
        /// <summary>
        /// �Ƽ�������
        /// </summary>
        public string tuiname
        {
            set { _tuiname = value; }
            get { return _tuiname; }
        }

        private int _kjtotal;
        /// <summary>
        /// ��������
        /// </summary>
        public int kjtotal
        {
            set { _kjtotal = value; }
            get { return _kjtotal; }
        }

        /// <summary>
        ///�ϴ��µ�����
        /// </summary>
        public string lastordertime
        {
            set { _lastordertime = value; }
            get { return _lastordertime; }
        }

        /// <summary>
        /// ֧������
        /// </summary>
        public string PayPassword
        {
            set { _PayPassword = value; }
            get { return _PayPassword; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string PayPWDQuestion
        {
            set { _PayPWDQuestion = value; }
            get { return _PayPWDQuestion; }
        }

        /// <summary>
        /// ά��
        /// </summary>
        public string PayPWDAnswer
        {
            set { _PayPWDAnswer = value; }
            get { return _PayPWDAnswer; }
        }

        /// <summary>
        /// �ֻ���֤��Ĭ��Ϊ0����֤�ɹ�Ϊ1��
        /// </summary>
        public int PhoneActivate
        {
            get { return _phoneActivate; }
            set { _phoneActivate = value; }
        }
        /// <summary>
        /// �û��˻����
        /// </summary>
        public decimal Usermoney
        {
            get { return _usermoney; }
            set { _usermoney = value; }
        }
         /// <summary>
        ///�û����
        /// </summary>
        public string Introduce
        {
            set { _introduce = value; }
            get { return _introduce; }
        }
        /// <summary>
        ///�û����
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid; }
        }
        /// <summary>
        /// �ǳ�
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// ��ʵ����
        /// </summary>
        public string TrueName
        {
            set { _truename = value; }
            get { return _truename; }
        }
        /// <summary>
        /// �Ա� (0:��1��Ů)
        /// </summary>
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// ΢�ź�
        /// </summary>
        public string Tell
        {
            set { _tell = value; }
            get { return _tell; }
        }
        /// <summary>
        /// �绰
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// GUID(��Ա��ź���ʹ�ô��ֶ�Ϊ��ȡ�û�)
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// �����û��Ƽ��루�����룩
        /// </summary>
        public string MSN
        {
            set { _msn = value; }
            get { return _msn; }
        }
        /// <summary>
        /// ע��ʱ��
        /// </summary>
        public DateTime RegTime
        {
            set { _regtime = value; }
            get { return _regtime; }
        }
        /// <summary>
        ///�ҵ��ǹ�
        /// </summary>
        public decimal Point
        {
            set { _point = value; }
            get { return _point; }
        }
        /// <summary>
        /// ͷ��
        /// </summary>
        public string Picture
        {
            set { _picture = value; }
            get { return _picture; }
        } 
 
        /// <summary>
        /// ����
        /// </summary>
        public string bigPicture
        {
            set { _bigpicture = value; }
            get { return _bigpicture; }
        }
        /// <summary>
        /// �û�״̬//�����û�(��Ч�û�)0��ֹ ��¼
        /// </summary>
        public string State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// Ŀǰ�洢�Ƽ��˵��Ƽ�����
        /// </summary>
        public string EMAIL
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        /// <summary>
        /// �Ƿ���Ч�û�
        /// </summary>
        public int IsActivate
        {
            set
            {
                _isavtivate = value;
            }
            get
            {
                return _isavtivate;
            }
        } 
        /// <summary>
        /// ���߶�������
        /// </summary>
        public int RsCount
        {
            set
            {
                _RsCount = value;
            }
            get
            {
                return _RsCount;
            }
        }

        /// <summary>
        /// ����Ǯ����ַ
        /// </summary>
        public string ActivateCode
        {
            set
            {
                _avtivatecode = value;
            }
            get
            {
                return _avtivatecode;
            }
        }

        /// <summary>
        ///��ǰ�û���Ծ��
        /// </summary>
        public decimal GroupID
        {
            set
            {
                _groupid = value;
            }
            get
            {
                return _groupid;
            }
        }  
        
        /// <summary>
        ///��ǰ�û�С����Ծ��
        /// </summary>
        public decimal xiaoquact
        {
            set
            {
                _xiaoquact = value;
            }
            get
            {
                return _xiaoquact;
            }
        }

        /// <summary>
        /// Ϊ�ջ���0Ϊδʵ����֤(���֤����)
        /// </summary>
        public string WebSite
        {
            set
            {
                _website = value;
            }
            get
            {
                return _website;
            }
        }

        /// <summary>
        /// �Ƽ��˵ı��
        /// </summary>
        public string RID
        {
            set
            {
                _rid = value;
            }
            get
            {
                return _rid;
            }
        }

        /// <summary>
        /// �����ʺŵ�¼�������õ��ı��
        /// </summary>
        public string openid
        {
            set { _openid = value; }
            get { return _openid; }
        }

        /// <summary>
        /// ��¼��ʲô���͵�(�������������������)
        /// </summary>
        public string wtype
        {
            set { _wtype = value; }
            get { return _wtype; }
        }

        /// <summary>
        /// ��Ӧ�û�ip��ַ
        /// </summary>
        public string UC_ID
        {
            set;
            get;
        }

        private string _company;
        /// <summary>
        /// //�û����ڳ���
        /// </summary>
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        private string _department;
        /// <summary>
        /// deviceId�����û����豸
        /// </summary>
        public string department
        {
            get { return _department; }
            set { _department = value; }
        }


        private int _reveint1;
        /// <summary>
        /// δʹ��
        /// </summary>
        public int reveint1
        {
            get { return _reveint1; }
            set { _reveint1 = value; }
        }

        private int _reveint2;
        /// <summary>
        /// �û�����0.��ͨ�û���1.һ�ǻ�Ա��2,���ǻ�Ա,3,���ǻ�Ա,4.���ǻ�Ա��5.���ǻ�Ա��
        /// </summary>
        public int reveint2
        {
            get { return _reveint2; }
            set { _reveint2 = value; }
        }

        private string _reveint3;
        /// <summary>
        /// ��ĿǰΪ������֤��δʹ��
        /// </summary>
        public string reveint3
        {
            get { return _reveint3; }
            set { _reveint3 = value; }
        }

        /// <summary>
        /// ԭ���û����ƣ�ʹ����֧���ɹ�������Ϣ��
        /// </summary>
        public string UN_old
        {
            set;
            get;
        }
        /// <summary>
        /// �����û����ƣ�ʹ����֧���ɹ�������Ϣ��
        /// </summary>
        public string UN_new
        {
            set;
            get;
        }
        /// <summary>
        /// Ҫ���͵��û�openid��ʹ����֧���ɹ�������Ϣ��
        /// </summary>
        public string UN_openid
        {
            set;
            get;
        }

        /// <summary>
        /// �û�������
        /// </summary>
        public decimal todayMoney
        {
            set;
            get;
        }

        /// <summary>
        /// �Ŷ��ܻ�Ծ��
        /// </summary>
        public decimal waitMoney
        {
            set;
            get;
        }

        /// <summary>
        /// �û��ƹ�����
        /// </summary>
        public int tuiNum
        {
            set;
            get;
        }

        /// <summary>
        /// �û������Ƿ�ǩ����0δǩ����1ǩ����
        /// </summary>
        public int isSignin
        {
            set;
            get;
        }

        /// <summary>
        /// �û�����������
        /// </summary>
        public int OrderCount
        {
            set;
            get;
        }
        /// <summary>
        /// �û��ۻ���ֵ���ƹ㽱��ֻ���ͷţ�
        /// </summary>
        public decimal cscpoint
        {
            set;
            get;
        }
        /// <summary>
        /// �û������������
        /// </summary>
        public int taskcount
        {
            set;
            get;
        }
        /// <summary>
        /// �û���õ��ܶ���
        /// </summary>
        public decimal stockpoint
        {
            set;
            get;
        }
        /// <summary>
        /// �û������Ѿ����ǹ�����
        /// </summary>
        public decimal todayPoint
        {
            set;
            get;
        }

        /// <summary>
        /// ���ݵ�ǰ�����ж��û�����Ӧ������
        /// </summary>
        public decimal TruetodayPoint
        {
            set;
            get;
        }

        /// <summary>
        /// �û��������ߵĻ�Ծ���ܺ�
        /// </summary>
        public decimal sumgroupid
        {
            set;
            get;
        }

        /// <summary>
        /// �㼶��ϵ   gpath=�ϼ���path+ id/
        /// </summary>
        public String gpath
        {
            set;
            get;
        } 
        /// <summary>
        /// ʵ����֤Ϊʵ�����֤���
        /// </summary>
        public string Card
        {
            set;
            get;
        }
        /// <summary>
        /// ֧�����տ���
        /// </summary>
        public string zfbPic
        {
            set;
            get;
        } 
        /// <summary>
        /// �жϵ����ȡ����������û����������
        /// </summary>
        public int tasknew
        {
            set;
            get;
        }

        /// <summary>
        /// �ۼ����� 
        /// </summary>
        public decimal totalMoney
        {
            set;
            get;
        }

        /// <summary>
        /// �Ŷ������� 
        /// </summary>
        public int totalPerson
        {
            set;
            get;
        }

        /// <summary>
        /// ����ֱ������������ʹ�ã� 
        /// </summary>
        public int todayPerson
        {
            set;
            get;
        }

        /// <summary>
        /// ���û��Ƿ���ȡ�����˺��0δ��ȡ��1�Ѿ���ȡ
        /// </summary>
        public int ishongbao
        {
            set;
            get;
        }
        /// <summary>
        /// �������߱��
        /// </summary>
        public int BianHao
        {
            set;
            get;
        }
     
        /// <summary>
        /// ����gpath
        /// </summary>
        public string pxgpath
        {
            set;
            get;
        }
    }
}

