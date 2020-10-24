using System;
namespace Hangjing.Model
{
    /// <summary>
    /// 手机话费充值记录
    /// </summary>
    [Serializable]
    public partial class mobileTopUpmodel
    {
        private int _id;
        private DateTime? _ut;
        private DateTime? _ct;
        private string _phone;
        private decimal? _price;
        private string _orderid;
        private int? _reqcode;
        private string _reqreason;
        private string _reqresult;
        private int? _finalecode;
        private string _finareason;
        private string _finalresult;
        private int? _gamestate;

        /// <summary>
        /// 用户编号
        /// </summary>
        public int userid
        {
            get;
            set;
        }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string username
        {
            get;
            set;
        }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string userPicture
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? ut
        {
            set { _ut = value; }
            get { return _ut; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? ct
        {
            set { _ct = value; }
            get { return _ct; }
        }
        /// <summary>
        /// 手机号
        /// </summary>
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 充值金额
        /// </summary>
        public decimal? price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderid
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 请求完成的状态
        /// </summary>
        public int? reqCode
        {
            set { _reqcode = value; }
            get { return _reqcode; }
        }
        /// <summary>
        /// 请求返回内容
        /// </summary>
        public string reqReason
        {
            set { _reqreason = value; }
            get { return _reqreason; }
        }
        /// <summary>
        /// 请求返回json
        /// </summary>
        public string reqResult
        {
            set { _reqresult = value; }
            get { return _reqresult; }
        }
        /// <summary>
        /// 最终状态（根据查询接口）
        /// </summary>
        public int? finaleCode
        {
            set { _finalecode = value; }
            get { return _finalecode; }
        }
        /// <summary>
        /// 查询结果说明
        /// </summary>
        public string finaReason
        {
            set { _finareason = value; }
            get { return _finareason; }
        }
        /// <summary>
        /// 最终的json
        /// </summary>
        public string finalResult
        {
            set { _finalresult = value; }
            get { return _finalresult; }
        }
        /// <summary>
        /// 充值状态 状态 1:成功 9:失败 0：充值中
        /// </summary>
        public int? gameState
        {
            set { _gamestate = value; }
            get { return _gamestate; }
        }

    }
}

