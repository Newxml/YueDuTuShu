using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// Reader:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Reader
	{
		public Reader()
		{}
		#region Model
		private string _numberid;
		private string _rdname;
		private int _rdtype;
		private DateTime _rdbirthday;
		private string _rdpapertype;
		private string _rdpapernum;
		private string _rdphone;
		private string _rdemail;
		private DateTime _rdcreatedate;
		private int _operid;
		private string _remark;
		private int? _rdborrownum=0;
		private int? _curnum=0;
		private string _rdsex;
		private string _rdimg;
		/// <summary>
		/// 
		/// </summary>
		public string numberId
		{
			set{ _numberid=value;}
			get{return _numberid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rdName
		{
			set{ _rdname=value;}
			get{return _rdname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int rdType
		{
			set{ _rdtype=value;}
			get{return _rdtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime rdBirthday
		{
			set{ _rdbirthday=value;}
			get{return _rdbirthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rdPaperType
		{
			set{ _rdpapertype=value;}
			get{return _rdpapertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rdPaperNum
		{
			set{ _rdpapernum=value;}
			get{return _rdpapernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rdPhone
		{
			set{ _rdphone=value;}
			get{return _rdphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rdEmail
		{
			set{ _rdemail=value;}
			get{return _rdemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime rdCreateDate
		{
			set{ _rdcreatedate=value;}
			get{return _rdcreatedate;}
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
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? rdBorrownum
		{
			set{ _rdborrownum=value;}
			get{return _rdborrownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? curNum
		{
			set{ _curnum=value;}
			get{return _curnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rdSex
		{
			set{ _rdsex=value;}
			get{return _rdsex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rdImg
		{
			set{ _rdimg=value;}
			get{return _rdimg;}
		}
		#endregion Model

	}
}

