
// ETogoOpinionInfo���̼�����ʵ��.
// CopyRight (c) 2009-2010 HangJing Teconology. All Rights Reserved.
// update by yangxiaolong@ihangjing.com
// 2010-03-12

using System;
using System.Collections.Generic;

namespace Hangjing.Model
{
    /// <summary>
    /// �̼�����ʵ��
    /// </summary>
    [Serializable]
    public class GoodsOpinionInfo
    {
        private int _dataid;
        private int _userid;
        private int _togoid;
        private int _point;
        private string _comment;
        private DateTime _posttime;
        private int _servicegrade;
        private int _flavorgrade;
        private int _speedgrade;
        private string _username;
        private string _togoname;
        private DateTime _rtime;
        private string _rcontent;
        private int _rtype;
        private string _picture;
        private string _truename;

        /// <summary>
        /// ����ͼƬhtml
        /// </summary>
        public string pictags
        {
            get;
            set;
        }

        /// <summary>
        /// �û�ͼƬ
        /// </summary>
        public string picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        private string _picture1;
        /// <summary>
        /// ����ͼƬ1
        /// </summary>
        public string picture1
        {
            get { return _picture1; }
            set { _picture1 = value; }
        }
        private string _picture2;
        /// <summary>
        /// ����ͼƬ2
        /// </summary>
        public string picture2
        {
            get { return _picture2; }
            set { _picture2 = value; }
        }
        private string _picture3;
        /// <summary>
        /// ����ͼƬ3
        /// </summary>
        public string picture3
        {
            get { return _picture3; }
            set { _picture3 = value; }
        }
        private string _picture4;
        /// <summary>
        /// ����ͼƬ4
        /// </summary>
        public string picture4
        {
            get { return _picture4; }
            set { _picture4 = value; }
        }

        public string Rcontent
        {
            get { return _rcontent; }
            set { _rcontent = value; }
        }

        /// <summary>
        /// ��Ʒ��id
        /// </summary>
        public int Rtype
        {
            get { return _rtype; }
            set { _rtype = value; }
        }

        public DateTime Rtime
        {
            get { return _rtime; }
            set { _rtime = value; }
        }

        /// <summary>
        /// ���ݱ��
        /// </summary>
        public int DataID
        {
            set { _dataid = value; }
            get { return _dataid; }
        }

        /// <summary>
        /// �����߱��
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }

        /// <summary>
        /// �̼ұ��
        /// </summary>
        public int TogoID
        {
            set { _togoid = value; }
            get { return _togoid; }
        }

        /// <summary>
        /// 0��ʾû����ˣ�1��ʾ���
        /// </summary>
        public int Point
        {
            set { _point = value; }
            get { return _point; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Comment
        {
            set { _comment = value; }
            get { return _comment; }
        }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime PostTime
        {
            set { _posttime = value; }
            get { return _posttime; }
        }

        /// <summary>
        /// ����ȼ�
        /// </summary>
        public int ServiceGrade
        {
            set { _servicegrade = value; }
            get { return _servicegrade; }
        }

        /// <summary>
        /// ��ζ�ȼ�
        /// </summary>
        public int FlavorGrade
        {
            set { _flavorgrade = value; }
            get { return _flavorgrade; }
        }

        /// <summary>
        /// �ٶȵȼ�
        /// </summary>
        public int SpeedGrade
        {
            set { _speedgrade = value; }
            get { return _speedgrade; }
        }

        /// <summary>
        /// �û�����
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }

        /// <summary>
        /// �û�����
        /// </summary>
        public string TrueName
        {
            set { _truename = value; }
            get { return _truename; }
        }

        /// <summary>
        /// �̼�����
        /// </summary>
        public string TogoName
        {
            set { _togoname = value; }
            get { return _togoname; }
        }

        /// <summary>
        /// ����
        /// </summary>
        private int _pointA;
        public int pointA
        {
            get { return _pointA; }
            set { _pointA = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        private int _pointB;
        public int pointB
        {
            get { return _pointB; }
            set { _pointB = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        private int _pointC;
        public int pointC
        {
            get { return _pointC; }
            set { _pointC = value; }
        }

    }
}

