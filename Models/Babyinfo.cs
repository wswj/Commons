using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    //配送员（站）信息
    [Serializable]
    public class BabyinfoInfo
    {
        private int _dataid;
        private string _codeid;
        private string _name;
        private string _phone;
        private string _section;
        private int _status;
        private string _gpsimei;
        private int _ordernum;
        private string _username;
        private string _password;
        private int _inve1;
        private string _inve2;
        private DateTime _adddate;
        
        //坐标相关
        private string _lat;
        private string _lng;
        private DateTime _loacltime;
        private string _pichtml;
        private int _distance;

        private int _direction;

        private decimal _speed;

        private string _carstate;


        private string _reve1;
        private string _reve2;
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string reve1
        {
            set { _reve1 = value; }
            get { return _reve1; }
        }
        /// <summary>
        /// 店铺地址
        /// </summary>
        public string reve2
        {
            set { _reve2 = value; }
            get { return _reve2; }
        }


        /// <summary>
        /// 用户第五张图片
        /// </summary>
        public string carstate
        {
            set { _carstate = value; }
            get { return _carstate; }
        }
        /// <summary>
        /// 图片html
        /// </summary>
        public string pichtml
        {
            set { _pichtml = value; }
            get { return _pichtml; }
        }
        /// <summary>
        /// 排名序号
        /// </summary>
        public int direction
        {
            set { _direction = value; }
            get { return _direction; }
        }

        /// <summary>
        /// 未用
        /// </summary>
        public decimal speed
        {
            set { _speed = value; }
            get { return _speed; }
        }


        /// <summary>
        /// 未用
        /// </summary>
        public int distance
        {
            set { _distance = value; }
            get { return _distance; }
        }


        /// <summary>
        /// 编号主键
        /// </summary>
        public int DataId
        {
            set { _dataid = value; }
            get { return _dataid; }
        }

        /// <summary>
        /// 用户图片3
        /// </summary>
        public string CodeId
        {
            set { _codeid = value; }
            get { return _codeid; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
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
        ///萌宝宣言
        /// </summary>
        public string Section
        {
            set { _section = value; }
            get { return _section; }
        }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public int Status
        {
            set { _status = value; }
            get { return _status; }
        }

        /// <summary>
        /// 用户图片3
        /// </summary>
        public string GpsIMEI
        {
            set { _gpsimei = value; }
            get { return _gpsimei; }
        }

        /// <summary>
        /// 投的票数
        /// </summary>
        public int OrderNum
        {
            set { _ordernum = value; }
            get { return _ordernum; }
        }

        /// <summary>
        /// 用户图片1
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }

        /// <summary>
        /// 用户图片2
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        /// <summary>
        /// 排序字段
        /// </summary>
        public int Inve1
        {
            set { _inve1 = value; }
            get { return _inve1; }
        }

        /// <summary>
        /// Serverid
        /// </summary>
        public string Inve2
        {
            set { _inve2 = value; }
            get { return _inve2; }
        }

        /// <summary>
        /// 添加日期
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }

        /// <summary>
        /// 用户图片4
        /// </summary>
        public string Lat
        {
            set { _lat = value; }
            get { return _lat; }
        }

        /// <summary>
        ///  用户图片5
        /// </summary>
        public string Lng
        {
            set { _lng = value; }
            get { return _lng; }
        }

        /// <summary>
        /// 未用
        /// </summary>
        public DateTime LocalTime
        {
            set { _loacltime = value; }
            get { return _loacltime; }
        }
    }
}
