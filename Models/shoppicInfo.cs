using System;
namespace Hangjing.Model
{
	/// <summary>
    /// ª∑æ≥Õº∆¨
	/// </summary>
	public class shoppicInfo
	{
		private int _rid;
		private int _tid;
		private DateTime _addtime;
        private string _picture;
		private string _title;
		private int _reveint1;
		private int _reveint2;
		private string _revevar1;
		private string _revevar2;
        private string _togoname;

        public string TogoName
        {
            set { _togoname = value; }
            get { return _togoname; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Picture
        {
            set { _picture = value; }
            get { return _picture; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int rId
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tid
		{
			set{ _tid=value;}
			get{return _tid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// ≈≈–Ú(Ωµ–Ú)
		/// </summary>
		public int ReveInt1
		{
			set{ _reveint1=value;}
			get{return _reveint1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReveInt2
		{
			set{ _reveint2=value;}
			get{return _reveint2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReveVar1
		{
			set{ _revevar1=value;}
			get{return _revevar1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReveVar2
		{
			set{ _revevar2=value;}
			get{return _revevar2;}
		}

	}
}

