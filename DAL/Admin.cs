using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueDuLibrary.DAL
{
	/// <summary>
	/// 数据访问类:Admin
	/// </summary>
	public partial class Admin
	{
		public Admin()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("adminId", "Admin"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int adminId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Admin");
			strSql.Append(" where adminId=@adminId");
			SqlParameter[] parameters = {
					new SqlParameter("@adminId", SqlDbType.Int,4)
			};
			parameters[0].Value = adminId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(YueDuLibrary.Model.Admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Admin(");
			strSql.Append("adminName,adminPass,adminType,adminImg)");
			strSql.Append(" values (");
			strSql.Append("@adminName,@adminPass,@adminType,@adminImg)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@adminName", SqlDbType.VarChar,25),
					new SqlParameter("@adminPass", SqlDbType.VarChar,100),
					new SqlParameter("@adminType", SqlDbType.Int,4),
					new SqlParameter("@adminImg", SqlDbType.VarChar,60)};
			parameters[0].Value = model.adminName;
			parameters[1].Value = model.adminPass;
			parameters[2].Value = model.adminType;
			parameters[3].Value = model.adminImg;

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
		public bool Update(YueDuLibrary.Model.Admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Admin set ");
			strSql.Append("adminName=@adminName,");
			strSql.Append("adminPass=@adminPass,");
			strSql.Append("adminType=@adminType,");
			strSql.Append("adminImg=@adminImg");
			strSql.Append(" where adminId=@adminId");
			SqlParameter[] parameters = {
					new SqlParameter("@adminName", SqlDbType.VarChar,25),
					new SqlParameter("@adminPass", SqlDbType.VarChar,100),
					new SqlParameter("@adminType", SqlDbType.Int,4),
					new SqlParameter("@adminImg", SqlDbType.VarChar,60),
					new SqlParameter("@adminId", SqlDbType.Int,4)};
			parameters[0].Value = model.adminName;
			parameters[1].Value = model.adminPass;
			parameters[2].Value = model.adminType;
			parameters[3].Value = model.adminImg;
			parameters[4].Value = model.adminId;

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
		public bool Delete(int adminId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Admin ");
			strSql.Append(" where adminId=@adminId");
			SqlParameter[] parameters = {
					new SqlParameter("@adminId", SqlDbType.Int,4)
			};
			parameters[0].Value = adminId;

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
		public bool DeleteList(string adminIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Admin ");
			strSql.Append(" where adminId in ("+adminIdlist + ")  ");
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
		public YueDuLibrary.Model.Admin GetModel(int adminId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 adminId,adminName,adminPass,adminType,adminImg from Admin ");
			strSql.Append(" where adminId=@adminId");
			SqlParameter[] parameters = {
					new SqlParameter("@adminId", SqlDbType.Int,4)
			};
			parameters[0].Value = adminId;

			YueDuLibrary.Model.Admin model=new YueDuLibrary.Model.Admin();
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
		public YueDuLibrary.Model.Admin DataRowToModel(DataRow row)
		{
			YueDuLibrary.Model.Admin model=new YueDuLibrary.Model.Admin();
			if (row != null)
			{
				if(row["adminId"]!=null && row["adminId"].ToString()!="")
				{
					model.adminId=int.Parse(row["adminId"].ToString());
				}
				if(row["adminName"]!=null)
				{
					model.adminName=row["adminName"].ToString();
				}
				if(row["adminPass"]!=null)
				{
					model.adminPass=row["adminPass"].ToString();
				}
				if(row["adminType"]!=null && row["adminType"].ToString()!="")
				{
					model.adminType=int.Parse(row["adminType"].ToString());
				}
				if(row["adminImg"]!=null)
				{
					model.adminImg=row["adminImg"].ToString();
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
			strSql.Append("select adminId,adminName,adminPass,adminType,adminImg ");
			strSql.Append(" FROM Admin ");
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
			strSql.Append(" adminId,adminName,adminPass,adminType,adminImg ");
			strSql.Append(" FROM Admin ");
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
			strSql.Append("select count(1) FROM Admin ");
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
				strSql.Append("order by T.adminId desc");
			}
			strSql.Append(")AS Row, T.*  from Admin T ");
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
			parameters[0].Value = "Admin";
			parameters[1].Value = "adminId";
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

