using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// BorrowandBack:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BorrowandBack
	{
		public BorrowandBack()
		{}
		#region Model
		private int _id;
		private string _readerid;
		private string _bookcode;
		private DateTime _borrowtime;
		private DateTime _shouldbacktime;
		private DateTime? _realbacktime;
		private int _borrowoperid;
		private int? _backoperid;
		private bool _isback= false;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string readerId
		{
			set{ _readerid=value;}
			get{return _readerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bookCode
		{
			set{ _bookcode=value;}
			get{return _bookcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime borrowTime
		{
			set{ _borrowtime=value;}
			get{return _borrowtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime shouldBackTime
		{
			set{ _shouldbacktime=value;}
			get{return _shouldbacktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? realBackTime
		{
			set{ _realbacktime=value;}
			get{return _realbacktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int borrowoperId
		{
			set{ _borrowoperid=value;}
			get{return _borrowoperid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? backoperId
		{
			set{ _backoperid=value;}
			get{return _backoperid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isBack
		{
			set{ _isback=value;}
			get{return _isback;}
		}
		#endregion Model

	}
}

