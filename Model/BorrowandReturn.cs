/**  版本信息模板在安装目录下，可自行修改。
* BorrowandReturn.cs
*
* 功 能： N/A
* 类 名： BorrowandReturn
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
	/// BorrowandReturn:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BorrowandReturn
	{
		public BorrowandReturn()
		{}
		#region Model
		private int _id;
		private int _readerid;
		private string _bookcode;
		private DateTime _borrowtime= DateTime.Now;
		private DateTime? _backtime;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReaderID
		{
			set{ _readerid=value;}
			get{return _readerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BookCode
		{
			set{ _bookcode=value;}
			get{return _bookcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BorrowTime
		{
			set{ _borrowtime=value;}
			get{return _borrowtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BackTime
		{
			set{ _backtime=value;}
			get{return _backtime;}
		}
		#endregion Model

	}
}

