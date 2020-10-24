using System;
namespace Hangjing.Model
{
	/// <summary>
	/// ʵ����Record ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class RecordInfo
	{
		private int _rid;
		private string _startstate;
		private string _endstate;
		private string _adminname;
		private DateTime _addtime;
		private int _reve1;
		private string _reve2;
		/// <summary>
		/// 
		/// </summary>
		public int rid
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
        /// ��ʼ�۸�����۸�
		/// </summary>
		public string startstate
		{
			set{ _startstate=value;}
			get{return _startstate;}
		}
		/// <summary>
        /// �����Ƕ���
		/// </summary>
		public string endstate
		{
			set{ _endstate=value;}
			get{return _endstate;}
		}
		/// <summary>
		/// ��¼��ע
		/// </summary>
		public string adminname
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		/// <summary>
		/// ʱ��
		/// </summary>
		public DateTime addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
        /// <summary>
        /// ���ͣ�1ϵͳ�����۸�
        /// </summary>
        public int Reve1
        {
            set { _reve1 = value; }
            get { return _reve1; }
        }
        /// <summary>
        /// ����" + addusercount + "�û�
        /// </summary>
        public string Reve2
        {
            set { _reve2 = value; }
            get { return _reve2; }
        }

        private string _orderid;
        /// <summary>
        /// �������
        /// </summary>
        public string orderid
        {
            get { return _orderid; }
            set { _orderid = value; }
        }

	}
}

