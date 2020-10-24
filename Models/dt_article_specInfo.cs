using System;
namespace Hangjing.Model
{
	/// <summary>
	/// 实体类dt_article_spec 。(属性说明自动提取数据库字段的描述信息)
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
		/// 自增ID
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 所属频道
		/// </summary>
		public int channel_id
		{
			set{ _channel_id=value;}
			get{return _channel_id;}
		}
		/// <summary>
		/// 父节点ID
		/// </summary>
		public int parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		/// <summary>
		/// 规格标题
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 规格图片
		/// </summary>
		public string img_url
		{
			set{ _img_url=value;}
			get{return _img_url;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 排序数字
		/// </summary>
		public int sort_id
		{
			set{ _sort_id=value;}
			get{return _sort_id;}
		}
		#endregion Model

	}
}

