using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueDuLibrary.DAL
{
	/// <summary>
	/// 数据访问类:BookType
	/// </summary>
	public partial class BookType
	{
		public BookType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("typeId", "BookType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int typeId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BookType");
			strSql.Append(" where typeId=@typeId");
			SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
			parameters[0].Value = typeId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(YueDuLibrary.Model.BookType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BookType(");
			strSql.Append("typeName,brDays)");
			strSql.Append(" values (");
			strSql.Append("@typeName,@brDays)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@typeName", SqlDbType.VarChar,20),
					new SqlParameter("@brDays", SqlDbType.Int,4)};
			parameters[0].Value = model.typeName;
			parameters[1].Value = model.brDays;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YueDuLibrary.Model.BookType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BookType set ");
			strSql.Append("typeName=@typeName,");
			strSql.Append("brDays=@brDays");
			strSql.Append(" where typeId=@typeId");
			SqlParameter[] parameters = {
					new SqlParameter("@typeName", SqlDbType.VarChar,20),
					new SqlParameter("@brDays", SqlDbType.Int,4),
					new SqlParameter("@typeId", SqlDbType.Int,4)};
			parameters[0].Value = model.typeName;
			parameters[1].Value = model.brDays;
			parameters[2].Value = model.typeId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int typeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookType ");
			strSql.Append(" where typeId=@typeId");
			SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
			parameters[0].Value = typeId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string typeIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookType ");
			strSql.Append(" where typeId in ("+typeIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueDuLibrary.Model.BookType GetModel(int typeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 typeId,typeName,brDays from BookType ");
			strSql.Append(" where typeId=@typeId");
			SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
			parameters[0].Value = typeId;

			YueDuLibrary.Model.BookType model=new YueDuLibrary.Model.BookType();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueDuLibrary.Model.BookType DataRowToModel(DataRow row)
		{
			YueDuLibrary.Model.BookType model=new YueDuLibrary.Model.BookType();
			if (row != null)
			{
				if(row["typeId"]!=null && row["typeId"].ToString()!="")
				{
					model.typeId=int.Parse(row["typeId"].ToString());
				}
				if(row["typeName"]!=null)
				{
					model.typeName=row["typeName"].ToString();
				}
				if(row["brDays"]!=null && row["brDays"].ToString()!="")
				{
					model.brDays=int.Parse(row["brDays"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select typeId,typeName,brDays ");
			strSql.Append(" FROM BookType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" typeId,typeName,brDays ");
			strSql.Append(" FROM BookType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM BookType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.typeId desc");
			}
			strSql.Append(")AS Row, T.*  from BookType T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "BookType";
			parameters[1].Value = "typeId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

