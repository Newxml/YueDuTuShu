using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// ReaderType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReaderType
	{
		public ReaderType()
		{}
		#region Model
		private int _id;
		private string _typename;
		private int _number;
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
		public string typeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int number
		{
			set{ _number=value;}
			get{return _number;}
		}
		#endregion Model

	}
}

