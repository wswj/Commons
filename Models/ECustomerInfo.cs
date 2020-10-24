using System;
namespace Hangjing.Model
{
	/// <summary>
	/// 实体类EUser 。(属性说明自动提取数据库字段的描述信息)
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
        /// 解绑次数
        /// </summary>
        public int jiebang
        {
            set { _jiebang = value; }
            get { return _jiebang; }
        }
        private decimal _gongxian;
        /// <summary>
        /// (助力值)贡献值
        /// </summary>
        public decimal gongxian
        {
            set { _gongxian = value; }
            get { return _gongxian; }
        }
        private int _tuiguang;
        /// <summary>
        /// 推广人数
        /// </summary>
        public int tuiguang
        {
            set { _tuiguang = value; }
            get { return _tuiguang; }
        }
        private int _grade;
        /// <summary>
        /// 认证等级状态（is_auth：0未通过任何认证 初级、高级认证按钮全部显示1://如果已支付，说明初级认证还没有通过 ，也显示初级、高级按钮）
        ///（is_auth：2初级认证已经通过  显示高级认证按钮  和  初级认证的认证章,3.高级认证通过  按钮初级高级按钮全隐藏 显示初级 高级认证章
        /// </summary>
        public int grade
        {
            set { _grade = value; }
            get { return _grade; }
        }
        private DateTime _buildtime;
        /// <summary>
        /// 用户是否还能购币
        /// </summary>
        public DateTime buildtime
        {
            set { _buildtime = value; }
            get { return _buildtime; }
        }

        private decimal _SumAmount;
        /// <summary>
        /// 计算用户收益
        /// </summary>
        public decimal SumAmount
        {
            set { _SumAmount = value; }
            get { return _SumAmount; }
        }

        private string _tuiPhone;
        /// <summary>
        /// 推荐人手机
        /// </summary>
        public string tuiPhone
        {
            set { _tuiPhone = value; }
            get { return _tuiPhone; }
        }

        private string _tuiname;
        /// <summary>
        /// 推荐人名称
        /// </summary>
        public string tuiname
        {
            set { _tuiname = value; }
            get { return _tuiname; }
        }

        private int _kjtotal;
        /// <summary>
        /// 购买总数
        /// </summary>
        public int kjtotal
        {
            set { _kjtotal = value; }
            get { return _kjtotal; }
        }

        /// <summary>
        ///上次下单日期
        /// </summary>
        public string lastordertime
        {
            set { _lastordertime = value; }
            get { return _lastordertime; }
        }

        /// <summary>
        /// 支付密码
        /// </summary>
        public string PayPassword
        {
            set { _PayPassword = value; }
            get { return _PayPassword; }
        }

        /// <summary>
        /// 经度
        /// </summary>
        public string PayPWDQuestion
        {
            set { _PayPWDQuestion = value; }
            get { return _PayPWDQuestion; }
        }

        /// <summary>
        /// 维度
        /// </summary>
        public string PayPWDAnswer
        {
            set { _PayPWDAnswer = value; }
            get { return _PayPWDAnswer; }
        }

        /// <summary>
        /// 手机验证（默认为0，验证成功为1）
        /// </summary>
        public int PhoneActivate
        {
            get { return _phoneActivate; }
            set { _phoneActivate = value; }
        }
        /// <summary>
        /// 用户账户余额
        /// </summary>
        public decimal Usermoney
        {
            get { return _usermoney; }
            set { _usermoney = value; }
        }
         /// <summary>
        ///用户简介
        /// </summary>
        public string Introduce
        {
            set { _introduce = value; }
            get { return _introduce; }
        }
        /// <summary>
        ///用户编号
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid; }
        }
        /// <summary>
        /// 昵称
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 真实名称
        /// </summary>
        public string TrueName
        {
            set { _truename = value; }
            get { return _truename; }
        }
        /// <summary>
        /// 性别 (0:男1，女)
        /// </summary>
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 微信号
        /// </summary>
        public string Tell
        {
            set { _tell = value; }
            get { return _tell; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// GUID(会员编号后面使用此字段为获取用户)
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 保存用户推荐码（邀请码）
        /// </summary>
        public string MSN
        {
            set { _msn = value; }
            get { return _msn; }
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegTime
        {
            set { _regtime = value; }
            get { return _regtime; }
        }
        /// <summary>
        ///我的糖果
        /// </summary>
        public decimal Point
        {
            set { _point = value; }
            get { return _point; }
        }
        /// <summary>
        /// 头像
        /// </summary>
        public string Picture
        {
            set { _picture = value; }
            get { return _picture; }
        } 
 
        /// <summary>
        /// 封面
        /// </summary>
        public string bigPicture
        {
            set { _bigpicture = value; }
            get { return _bigpicture; }
        }
        /// <summary>
        /// 用户状态//激活用户(有效用户)0禁止 登录
        /// </summary>
        public string State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 目前存储推荐人的推荐编码
        /// </summary>
        public string EMAIL
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        /// <summary>
        /// 是否有效用户
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
        /// 排线队伍人数
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
        /// 数字钱包地址
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
        ///当前用户活跃度
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
        ///当前用户小区活跃度
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
        /// 为空或者0为未实名认证(身份证号码)
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
        /// 推荐人的编号
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
        /// 第三帐号登录过程中用到的编号
        /// </summary>
        public string openid
        {
            set { _openid = value; }
            get { return _openid; }
        }

        /// <summary>
        /// 记录是什么类型的(基本根据这个降手续费)
        /// </summary>
        public string wtype
        {
            set { _wtype = value; }
            get { return _wtype; }
        }

        /// <summary>
        /// 对应用户ip地址
        /// </summary>
        public string UC_ID
        {
            set;
            get;
        }

        private string _company;
        /// <summary>
        /// //用户所在城市
        /// </summary>
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        private string _department;
        /// <summary>
        /// deviceId用于用户绑定设备
        /// </summary>
        public string department
        {
            get { return _department; }
            set { _department = value; }
        }


        private int _reveint1;
        /// <summary>
        /// 未使用
        /// </summary>
        public int reveint1
        {
            get { return _reveint1; }
            set { _reveint1 = value; }
        }

        private int _reveint2;
        /// <summary>
        /// 用户级别（0.普通用户，1.一星会员，2,二星会员,3,三星会员,4.四星会员，5.五星会员）
        /// </summary>
        public int reveint2
        {
            get { return _reveint2; }
            set { _reveint2 = value; }
        }

        private string _reveint3;
        /// <summary>
        /// （目前为排线认证金额）未使用
        /// </summary>
        public string reveint3
        {
            get { return _reveint3; }
            set { _reveint3 = value; }
        }

        /// <summary>
        /// 原来用户名称（使用于支付成功发送消息）
        /// </summary>
        public string UN_old
        {
            set;
            get;
        }
        /// <summary>
        /// 现在用户名称（使用于支付成功发送消息）
        /// </summary>
        public string UN_new
        {
            set;
            get;
        }
        /// <summary>
        /// 要发送的用户openid（使用于支付成功发送消息）
        /// </summary>
        public string UN_openid
        {
            set;
            get;
        }

        /// <summary>
        /// 用户日收益
        /// </summary>
        public decimal todayMoney
        {
            set;
            get;
        }

        /// <summary>
        /// 团队总活跃度
        /// </summary>
        public decimal waitMoney
        {
            set;
            get;
        }

        /// <summary>
        /// 用户推广人数
        /// </summary>
        public int tuiNum
        {
            set;
            get;
        }

        /// <summary>
        /// 用户当天是否签到过0未签到，1签到过
        /// </summary>
        public int isSignin
        {
            set;
            get;
        }

        /// <summary>
        /// 用户任务奖励次数
        /// </summary>
        public int OrderCount
        {
            set;
            get;
        }
        /// <summary>
        /// 用户累火力值（推广奖励只能释放）
        /// </summary>
        public decimal cscpoint
        {
            set;
            get;
        }
        /// <summary>
        /// 用户正常卷轴个数
        /// </summary>
        public int taskcount
        {
            set;
            get;
        }
        /// <summary>
        /// 用户获得的总豆豆
        /// </summary>
        public decimal stockpoint
        {
            set;
            get;
        }
        /// <summary>
        /// 用户当天已经产糖果数量
        /// </summary>
        public decimal todayPoint
        {
            set;
            get;
        }

        /// <summary>
        /// 根据当前任务判断用户当天应产数量
        /// </summary>
        public decimal TruetodayPoint
        {
            set;
            get;
        }

        /// <summary>
        /// 用户所有下线的活跃度总和
        /// </summary>
        public decimal sumgroupid
        {
            set;
            get;
        }

        /// <summary>
        /// 层级关系   gpath=上级的path+ id/
        /// </summary>
        public String gpath
        {
            set;
            get;
        } 
        /// <summary>
        /// 实名认证为实名身份证编号
        /// </summary>
        public string Card
        {
            set;
            get;
        }
        /// <summary>
        /// 支付宝收款码
        /// </summary>
        public string zfbPic
        {
            set;
            get;
        } 
        /// <summary>
        /// 判断当天除取赠送任务有没有新增任务
        /// </summary>
        public int tasknew
        {
            set;
            get;
        }

        /// <summary>
        /// 累计收益 
        /// </summary>
        public decimal totalMoney
        {
            set;
            get;
        }

        /// <summary>
        /// 团队总人数 
        /// </summary>
        public int totalPerson
        {
            set;
            get;
        }

        /// <summary>
        /// 今日直推人数（排线使用） 
        /// </summary>
        public int todayPerson
        {
            set;
            get;
        }

        /// <summary>
        /// 新用户是否领取过新人红包0未领取，1已经领取
        /// </summary>
        public int ishongbao
        {
            set;
            get;
        }
        /// <summary>
        /// 独立排线编号
        /// </summary>
        public int BianHao
        {
            set;
            get;
        }
     
        /// <summary>
        /// 排线gpath
        /// </summary>
        public string pxgpath
        {
            set;
            get;
        }
    }
}

