using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// BookType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BookType
	{
		public BookType()
		{}
		#region Model
		private int _typeid;
		private string _typename;
		private int _brdays;
		/// <summary>
		/// 
		/// </summary>
		public int typeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string typeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int brDays
		{
			set{ _brdays=value;}
			get{return _brdays;}
		}
		#endregion Model

	}
}

