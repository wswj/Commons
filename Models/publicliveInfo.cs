using System;
namespace Hangjing.Model
{
	/// <summary>
    /// ʵ����publicliveInfo ��(���Ļ�����Ϣ)
	/// </summary>
    public class publicliveInfo
	{
		private int _dataid;
		private string _picture;
        private decimal _link;
		private string _introduce;
        private int _state;
		private string _title;
        private decimal _width;
        private DateTime _height;

        private decimal _allmoney;
        /// <summary>
        /// �ۼƾ���
        /// </summary>
        public decimal allmoney
        {
            set { _allmoney = value; }
            get { return _allmoney; }
        }

		/// <summary>
		/// �Զ�����
		/// </summary>
		public int DataId
		{
			set{ _dataid=value;}
			get{return _dataid;}
		}
		/// <summary>
        /// ����ͼƬ
		/// </summary>
		public string Picture
		{
			set{ _picture=value;}
			get{return _picture;}
		}
		/// <summary>
        /// ���ľ���
		/// </summary>
		public decimal Link
		{
			set{ _link=value;}
			get{return _link;}
		}
		/// <summary>
        /// δ��
		/// </summary>
		public string Introduce
		{
			set{ _introduce=value;}
			get{return _introduce;}
		}
		/// <summary>
        ///  �ۼƾ������ٴ�
		/// </summary>
        public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
        /// ���ı���
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		///��������
		/// </summary>
        public decimal Width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
        public DateTime Height
		{
			set{ _height=value;}
			get{return _height;}
		}
	}
}

