using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueDuLibrary.DAL
{
	/// <summary>
	/// 数据访问类:BookCase
	/// </summary>
	public partial class BookCase
	{
		public BookCase()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("caseId", "BookCase"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int caseId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BookCase");
			strSql.Append(" where caseId=@caseId");
			SqlParameter[] parameters = {
					new SqlParameter("@caseId", SqlDbType.Int,4)
			};
			parameters[0].Value = caseId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(YueDuLibrary.Model.BookCase model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BookCase(");
			strSql.Append("caseName)");
			strSql.Append(" values (");
			strSql.Append("@caseName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@caseName", SqlDbType.VarChar,10)};
			parameters[0].Value = model.caseName;

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
		public bool Update(YueDuLibrary.Model.BookCase model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BookCase set ");
			strSql.Append("caseName=@caseName");
			strSql.Append(" where caseId=@caseId");
			SqlParameter[] parameters = {
					new SqlParameter("@caseName", SqlDbType.VarChar,10),
					new SqlParameter("@caseId", SqlDbType.Int,4)};
			parameters[0].Value = model.caseName;
			parameters[1].Value = model.caseId;

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
		public bool Delete(int caseId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookCase ");
			strSql.Append(" where caseId=@caseId");
			SqlParameter[] parameters = {
					new SqlParameter("@caseId", SqlDbType.Int,4)
			};
			parameters[0].Value = caseId;

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
		public bool DeleteList(string caseIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookCase ");
			strSql.Append(" where caseId in ("+caseIdlist + ")  ");
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
		public YueDuLibrary.Model.BookCase GetModel(int caseId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 caseId,caseName from BookCase ");
			strSql.Append(" where caseId=@caseId");
			SqlParameter[] parameters = {
					new SqlParameter("@caseId", SqlDbType.Int,4)
			};
			parameters[0].Value = caseId;

			YueDuLibrary.Model.BookCase model=new YueDuLibrary.Model.BookCase();
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
		public YueDuLibrary.Model.BookCase DataRowToModel(DataRow row)
		{
			YueDuLibrary.Model.BookCase model=new YueDuLibrary.Model.BookCase();
			if (row != null)
			{
				if(row["caseId"]!=null && row["caseId"].ToString()!="")
				{
					model.caseId=int.Parse(row["caseId"].ToString());
				}
				if(row["caseName"]!=null)
				{
					model.caseName=row["caseName"].ToString();
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
			strSql.Append("select caseId,caseName ");
			strSql.Append(" FROM BookCase ");
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
			strSql.Append(" caseId,caseName ");
			strSql.Append(" FROM BookCase ");
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
			strSql.Append("select count(1) FROM BookCase ");
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
				strSql.Append("order by T.caseId desc");
			}
			strSql.Append(")AS Row, T.*  from BookCase T ");
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
			parameters[0].Value = "BookCase";
			parameters[1].Value = "caseId";
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

