using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueDuLibrary.DAL
{
	/// <summary>
	/// 数据访问类:Library
	/// </summary>
	public partial class Library
	{
		public Library()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueDuLibrary.Model.Library model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Library(");
			strSql.Append("libarayName,curator,tel,Addresss,email,url,createDate,remark)");
			strSql.Append(" values (");
			strSql.Append("@libarayName,@curator,@tel,@Addresss,@email,@url,@createDate,@remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@libarayName", SqlDbType.VarChar,50),
					new SqlParameter("@curator", SqlDbType.VarChar,20),
					new SqlParameter("@tel", SqlDbType.VarChar,20),
					new SqlParameter("@Addresss", SqlDbType.VarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,100),
					new SqlParameter("@url", SqlDbType.VarChar,100),
					new SqlParameter("@createDate", SqlDbType.DateTime),
					new SqlParameter("@remark", SqlDbType.Text)};
			parameters[0].Value = model.libarayName;
			parameters[1].Value = model.curator;
			parameters[2].Value = model.tel;
			parameters[3].Value = model.Addresss;
			parameters[4].Value = model.email;
			parameters[5].Value = model.url;
			parameters[6].Value = model.createDate;
			parameters[7].Value = model.remark;

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
		public bool Update(YueDuLibrary.Model.Library model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Library set ");
			strSql.Append("libarayName=@libarayName,");
			strSql.Append("curator=@curator,");
			strSql.Append("tel=@tel,");
			strSql.Append("Addresss=@Addresss,");
			strSql.Append("email=@email,");
			strSql.Append("url=@url,");
			strSql.Append("createDate=@createDate,");
			strSql.Append("remark=@remark");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@libarayName", SqlDbType.VarChar,50),
					new SqlParameter("@curator", SqlDbType.VarChar,20),
					new SqlParameter("@tel", SqlDbType.VarChar,20),
					new SqlParameter("@Addresss", SqlDbType.VarChar,100),
					new SqlParameter("@email", SqlDbType.VarChar,100),
					new SqlParameter("@url", SqlDbType.VarChar,100),
					new SqlParameter("@createDate", SqlDbType.DateTime),
					new SqlParameter("@remark", SqlDbType.Text)};
			parameters[0].Value = model.libarayName;
			parameters[1].Value = model.curator;
			parameters[2].Value = model.tel;
			parameters[3].Value = model.Addresss;
			parameters[4].Value = model.email;
			parameters[5].Value = model.url;
			parameters[6].Value = model.createDate;
			parameters[7].Value = model.remark;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Library ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public YueDuLibrary.Model.Library GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 libarayName,curator,tel,Addresss,email,url,createDate,remark from Library ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			YueDuLibrary.Model.Library model=new YueDuLibrary.Model.Library();
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
		public YueDuLibrary.Model.Library DataRowToModel(DataRow row)
		{
			YueDuLibrary.Model.Library model=new YueDuLibrary.Model.Library();
			if (row != null)
			{
				if(row["libarayName"]!=null)
				{
					model.libarayName=row["libarayName"].ToString();
				}
				if(row["curator"]!=null)
				{
					model.curator=row["curator"].ToString();
				}
				if(row["tel"]!=null)
				{
					model.tel=row["tel"].ToString();
				}
				if(row["Addresss"]!=null)
				{
					model.Addresss=row["Addresss"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["url"]!=null)
				{
					model.url=row["url"].ToString();
				}
				if(row["createDate"]!=null && row["createDate"].ToString()!="")
				{
					model.createDate=DateTime.Parse(row["createDate"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
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
			strSql.Append("select libarayName,curator,tel,Addresss,email,url,createDate,remark ");
			strSql.Append(" FROM Library ");
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
			strSql.Append(" libarayName,curator,tel,Addresss,email,url,createDate,remark ");
			strSql.Append(" FROM Library ");
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
			strSql.Append("select count(1) FROM Library ");
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
			strSql.Append(")AS Row, T.*  from Library T ");
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
			parameters[0].Value = "Library";
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

