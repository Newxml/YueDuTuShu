using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// Library:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Library
	{
		public Library()
		{}
		#region Model
		private string _libarayname;
		private string _curator;
		private string _tel;
		private string _addresss;
		private string _email;
		private string _url;
		private DateTime? _createdate;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string libarayName
		{
			set{ _libarayname=value;}
			get{return _libarayname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string curator
		{
			set{ _curator=value;}
			get{return _curator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Addresss
		{
			set{ _addresss=value;}
			get{return _addresss;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

