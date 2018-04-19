/**  版本信息模板在安装目录下，可自行修改。
* Readers.cs
*
* 功 能： N/A
* 类 名： Readers
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/12/30 14:27:02   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace YueDuLibrary.Model
{
	/// <summary>
	/// Readers:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Readers
	{
		public Readers()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _sex;
		private string _pertype;
		private string _pernumber;
		private int _readtypeid;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerType
		{
			set{ _pertype=value;}
			get{return _pertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerNumber
		{
			set{ _pernumber=value;}
			get{return _pernumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReadtypeID
		{
			set{ _readtypeid=value;}
			get{return _readtypeid;}
		}
		#endregion Model

	}
}

