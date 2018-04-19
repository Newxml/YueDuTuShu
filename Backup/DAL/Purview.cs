using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueDuLibrary.DAL
{
	/// <summary>
	/// 数据访问类:Purview
	/// </summary>
	public partial class Purview
	{
		public Purview()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Purview");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,50)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueDuLibrary.Model.Purview model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Purview(");
			strSql.Append("id,sysSet,readSet,bookSet,borrowBack,sysQuery)");
			strSql.Append(" values (");
			strSql.Append("@id,@sysSet,@readSet,@bookSet,@borrowBack,@sysQuery)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,50),
					new SqlParameter("@sysSet", SqlDbType.Bit,1),
					new SqlParameter("@readSet", SqlDbType.Bit,1),
					new SqlParameter("@bookSet", SqlDbType.Bit,1),
					new SqlParameter("@borrowBack", SqlDbType.Bit,1),
					new SqlParameter("@sysQuery", SqlDbType.Bit,1)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.sysSet;
			parameters[2].Value = model.readSet;
			parameters[3].Value = model.bookSet;
			parameters[4].Value = model.borrowBack;
			parameters[5].Value = model.sysQuery;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(YueDuLibrary.Model.Purview model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Purview set ");
			strSql.Append("sysSet=@sysSet,");
			strSql.Append("readSet=@readSet,");
			strSql.Append("bookSet=@bookSet,");
			strSql.Append("borrowBack=@borrowBack,");
			strSql.Append("sysQuery=@sysQuery");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@sysSet", SqlDbType.Bit,1),
					new SqlParameter("@readSet", SqlDbType.Bit,1),
					new SqlParameter("@bookSet", SqlDbType.Bit,1),
					new SqlParameter("@borrowBack", SqlDbType.Bit,1),
					new SqlParameter("@sysQuery", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.sysSet;
			parameters[1].Value = model.readSet;
			parameters[2].Value = model.bookSet;
			parameters[3].Value = model.borrowBack;
			parameters[4].Value = model.sysQuery;
			parameters[5].Value = model.id;

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
		public bool Delete(string id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Purview ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,50)			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Purview ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public YueDuLibrary.Model.Purview GetModel(string id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,sysSet,readSet,bookSet,borrowBack,sysQuery from Purview ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,50)			};
			parameters[0].Value = id;

			YueDuLibrary.Model.Purview model=new YueDuLibrary.Model.Purview();
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
		public YueDuLibrary.Model.Purview DataRowToModel(DataRow row)
		{
			YueDuLibrary.Model.Purview model=new YueDuLibrary.Model.Purview();
			if (row != null)
			{
				if(row["id"]!=null)
				{
					model.id=row["id"].ToString();
				}
				if(row["sysSet"]!=null && row["sysSet"].ToString()!="")
				{
					if((row["sysSet"].ToString()=="1")||(row["sysSet"].ToString().ToLower()=="true"))
					{
						model.sysSet=true;
					}
					else
					{
						model.sysSet=false;
					}
				}
				if(row["readSet"]!=null && row["readSet"].ToString()!="")
				{
					if((row["readSet"].ToString()=="1")||(row["readSet"].ToString().ToLower()=="true"))
					{
						model.readSet=true;
					}
					else
					{
						model.readSet=false;
					}
				}
				if(row["bookSet"]!=null && row["bookSet"].ToString()!="")
				{
					if((row["bookSet"].ToString()=="1")||(row["bookSet"].ToString().ToLower()=="true"))
					{
						model.bookSet=true;
					}
					else
					{
						model.bookSet=false;
					}
				}
				if(row["borrowBack"]!=null && row["borrowBack"].ToString()!="")
				{
					if((row["borrowBack"].ToString()=="1")||(row["borrowBack"].ToString().ToLower()=="true"))
					{
						model.borrowBack=true;
					}
					else
					{
						model.borrowBack=false;
					}
				}
				if(row["sysQuery"]!=null && row["sysQuery"].ToString()!="")
				{
					if((row["sysQuery"].ToString()=="1")||(row["sysQuery"].ToString().ToLower()=="true"))
					{
						model.sysQuery=true;
					}
					else
					{
						model.sysQuery=false;
					}
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
			strSql.Append("select id,sysSet,readSet,bookSet,borrowBack,sysQuery ");
			strSql.Append(" FROM Purview ");
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
			strSql.Append(" id,sysSet,readSet,bookSet,borrowBack,sysQuery ");
			strSql.Append(" FROM Purview ");
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
			strSql.Append("select count(1) FROM Purview ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from Purview T ");
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
			parameters[0].Value = "Purview";
			parameters[1].Value = "id";
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

