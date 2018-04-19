using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// BookCase:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BookCase
	{
		public BookCase()
		{}
		#region Model
		private int _caseid;
		private string _casename;
		/// <summary>
		/// 
		/// </summary>
		public int caseId
		{
			set{ _caseid=value;}
			get{return _caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string caseName
		{
			set{ _casename=value;}
			get{return _casename;}
		}
		#endregion Model

	}
}

