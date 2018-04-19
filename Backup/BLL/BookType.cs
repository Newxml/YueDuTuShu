using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using YueDuLibrary.Model;
namespace YueDuLibrary.BLL
{
	/// <summary>
	/// BookType
	/// </summary>
	public partial class BookType
	{
		private readonly YueDuLibrary.DAL.BookType dal=new YueDuLibrary.DAL.BookType();
		public BookType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int typeId)
		{
			return dal.Exists(typeId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(YueDuLibrary.Model.BookType model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YueDuLibrary.Model.BookType model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int typeId)
		{
			
			return dal.Delete(typeId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string typeIdlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(typeIdlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueDuLibrary.Model.BookType GetModel(int typeId)
		{
			
			return dal.GetModel(typeId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YueDuLibrary.Model.BookType GetModelByCache(int typeId)
		{
			
			string CacheKey = "BookTypeModel-" + typeId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(typeId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YueDuLibrary.Model.BookType)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YueDuLibrary.Model.BookType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YueDuLibrary.Model.BookType> DataTableToList(DataTable dt)
		{
			List<YueDuLibrary.Model.BookType> modelList = new List<YueDuLibrary.Model.BookType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YueDuLibrary.Model.BookType model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

