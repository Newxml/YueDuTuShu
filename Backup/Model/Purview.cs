using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// Purview:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Purview
	{
		public Purview()
		{}
		#region Model
		private string _id;
		private bool _sysset= false;
		private bool _readset= false;
		private bool _bookset= false;
		private bool _borrowback= true;
		private bool _sysquery= false;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool sysSet
		{
			set{ _sysset=value;}
			get{return _sysset;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool readSet
		{
			set{ _readset=value;}
			get{return _readset;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bookSet
		{
			set{ _bookset=value;}
			get{return _bookset;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool borrowBack
		{
			set{ _borrowback=value;}
			get{return _borrowback;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool sysQuery
		{
			set{ _sysquery=value;}
			get{return _sysquery;}
		}
		#endregion Model

	}
}

