using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// BookInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BookInfo
	{
		public BookInfo()
		{}
		#region Model
		private int _bookid;
		private string _bookcode;
		private string _bookname;
		private string _typeid;
		private string _author;
		private string _price;
		private int _bookcaseid;
		private int _bookpage;
		private string _publish;
		private int _operid;
		private int _storage;
		private DateTime? _increatetime;
		private string _bookimg;
		/// <summary>
		/// 
		/// </summary>
		public int bookId
		{
			set{ _bookid=value;}
			get{return _bookid;}
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
		public string bookName
		{
			set{ _bookname=value;}
			get{return _bookname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string typeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int bookCaseId
		{
			set{ _bookcaseid=value;}
			get{return _bookcaseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int bookPage
		{
			set{ _bookpage=value;}
			get{return _bookpage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string publish
		{
			set{ _publish=value;}
			get{return _publish;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int operId
		{
			set{ _operid=value;}
			get{return _operid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int storage
		{
			set{ _storage=value;}
			get{return _storage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InCreateTime
		{
			set{ _increatetime=value;}
			get{return _increatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bookImg
		{
			set{ _bookimg=value;}
			get{return _bookimg;}
		}
		#endregion Model

	}
}

