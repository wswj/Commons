using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// 俱乐部（组队）信息
    /// </summary>
    public class ETogoLocalInfo
    {
        private int _dataid;
        private int _togoid;
        private string _lat;
        private string _lng;
        private string _polygon;
        private int _radius;

        private decimal _totalActive;
        /// <summary>
        /// 团队总活跃度
        /// </summary>
        public decimal totalActive
        {
            set { _totalActive = value; }
            get { return _totalActive; }
        }
        private int _isjoinClub;
        //识别用户有没有加入过俱乐部
        public int isjoinClub
        {
            set { _isjoinClub = value; }
            get { return _isjoinClub; }
        } 
        
        private string _Name;
        //队名称
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }

        private int _personcount;
        //统计组人数
        public int personcount
        {
            set { _personcount = value; }
            get { return _personcount; }
        }

        private string _Images;
        /// <summary>
        /// 对标头像
        /// </summary>
        public string Images
        {
            set { _Images = value; }
            get { return _Images; }
        }
        private string _Area;
        /// <summary>
        ///  城市名称
        /// </summary>
        public string Area
        {
            set { _Area = value; }
            get { return _Area; }
        }
        private string _areaName;
        /// <summary>
        ///  地区
        /// </summary>
        public string areaName
        {
            set { _areaName = value; }
            get { return _areaName; }
        }

        private string _UserName;
        //创建队人名称
        public string UserName
        {
            set { _UserName = value; }
            get { return _UserName; }
        }
        private string _UserId;
        /// <summary>
        ///  用户唯一编号
        /// </summary>
        public string UserId
        {
            set { _UserId = value; }
            get { return _UserId; }
        }
        private DateTime _AddTime;
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime
        {
            set { _AddTime = value; }
            get { return _AddTime; }
        }

        public int DataId
        {
            set { _dataid = value; }
            get { return _dataid; }
        }

        /// <summary>
        ///0表示该队已经删除，1表示正常组队
        /// </summary>
        public int TogoId
        {
            set { _togoid = value; }
            get { return _togoid; }
        }

        /// <summary>
        /// 队简介
        /// </summary>
        public string Polygon
        {
            set { _polygon = value; }
            get { return _polygon; }
        }

        /// <summary>
        /// 纬度坐标 横坐标
        /// </summary>
        public string Lat
        {
            set { _lat = value; }
            get { return _lat; }
        }

        /// <summary>
        /// 经度坐标 纵坐标
        /// </summary>
        public string Lng
        {
            set { _lng = value; }
            get { return _lng; }
        }

        /// <summary>
        /// 标注是0是俱乐部，1是组队
        /// </summary>
        public int Radius
        {
            set { _radius = value; }
            get { return _radius; }
        }
    }
}
