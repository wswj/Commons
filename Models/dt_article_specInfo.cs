using System;
namespace Hangjing.Model
{
	/// <summary>
	/// ʵ����dt_article_spec ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
     [Serializable]
	public class dt_article_specInfo
	{
		public dt_article_specInfo()
		{}
		#region Model
		private int _id;
		private int _channel_id;
		private int _parent_id;
		private string _title;
		private string _img_url;
		private string _remark;
		private int _sort_id;
		/// <summary>
		/// ����ID
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ����Ƶ��
		/// </summary>
		public int channel_id
		{
			set{ _channel_id=value;}
			get{return _channel_id;}
		}
		/// <summary>
		/// ���ڵ�ID
		/// </summary>
		public int parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// ���ͼƬ
		/// </summary>
		public string img_url
		{
			set{ _img_url=value;}
			get{return _img_url;}
		}
		/// <summary>
		/// ��ע˵��
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public int sort_id
		{
			set{ _sort_id=value;}
			get{return _sort_id;}
		}
		#endregion Model

	}
}

