using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// Admin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Admin
	{
		public Admin()
		{}
		#region Model
		private int _adminid;
		private string _adminname;
		private string _adminpass;
		private int _admintype;
		private string _adminimg;
		/// <summary>
		/// 
		/// </summary>
		public int adminId
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminName
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminPass
		{
			set{ _adminpass=value;}
			get{return _adminpass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int adminType
		{
			set{ _admintype=value;}
			get{return _admintype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminImg
		{
			set{ _adminimg=value;}
			get{return _adminimg;}
		}
		#endregion Model

	}
}

