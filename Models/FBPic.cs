using System;
namespace Hangjing.Model
{
	/// <summary>
	/// ��ƷͼƬ��(�ɶ���)
	/// </summary>
	public class FBPicInfo
	{
		private int _pid;
		private int _fid;
		private string _pic;
		private DateTime _adddate;
		private int _pri;
		private int _inve;
		private string _inve2;
		/// <summary>
		/// 
		/// </summary>
		public int pid
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// ��Ʒ���
		/// </summary>
		public int fid
		{
			set{ _fid=value;}
			get{return _fid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pic
		{
			set{ _pic=value;}
			get{return _pic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime adddate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pri
		{
			set{ _pri=value;}
			get{return _pri;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Inve
		{
			set{ _inve=value;}
			get{return _inve;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Inve2
		{
			set{ _inve2=value;}
			get{return _inve2;}
		}
	}
}

