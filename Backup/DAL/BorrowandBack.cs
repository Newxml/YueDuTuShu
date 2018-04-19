using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueDuLibrary.DAL
{
	/// <summary>
	/// 数据访问类:BorrowandBack
	/// </summary>
	public partial class BorrowandBack
	{
		public BorrowandBack()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "BorrowandBack"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BorrowandBack");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(YueDuLibrary.Model.BorrowandBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BorrowandBack(");
			strSql.Append("readerId,bookCode,borrowTime,shouldBackTime,realBackTime,borrowoperId,backoperId,isBack)");
			strSql.Append(" values (");
			strSql.Append("@readerId,@bookCode,@borrowTime,@shouldBackTime,@realBackTime,@borrowoperId,@backoperId,@isBack)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@readerId", SqlDbType.VarChar,12),
					new SqlParameter("@bookCode", SqlDbType.VarChar,15),
					new SqlParameter("@borrowTime", SqlDbType.DateTime),
					new SqlParameter("@shouldBackTime", SqlDbType.DateTime),
					new SqlParameter("@realBackTime", SqlDbType.DateTime),
					new SqlParameter("@borrowoperId", SqlDbType.Int,4),
					new SqlParameter("@backoperId", SqlDbType.Int,4),
					new SqlParameter("@isBack", SqlDbType.Bit,1)};
			parameters[0].Value = model.readerId;
			parameters[1].Value = model.bookCode;
			parameters[2].Value = model.borrowTime;
			parameters[3].Value = model.shouldBackTime;
			parameters[4].Value = model.realBackTime;
			parameters[5].Value = model.borrowoperId;
			parameters[6].Value = model.backoperId;
			parameters[7].Value = model.isBack;

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
		public bool Update(YueDuLibrary.Model.BorrowandBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BorrowandBack set ");
			strSql.Append("readerId=@readerId,");
			strSql.Append("bookCode=@bookCode,");
			strSql.Append("borrowTime=@borrowTime,");
			strSql.Append("shouldBackTime=@shouldBackTime,");
			strSql.Append("realBackTime=@realBackTime,");
			strSql.Append("borrowoperId=@borrowoperId,");
			strSql.Append("backoperId=@backoperId,");
			strSql.Append("isBack=@isBack");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@readerId", SqlDbType.VarChar,12),
					new SqlParameter("@bookCode", SqlDbType.VarChar,15),
					new SqlParameter("@borrowTime", SqlDbType.DateTime),
					new SqlParameter("@shouldBackTime", SqlDbType.DateTime),
					new SqlParameter("@realBackTime", SqlDbType.DateTime),
					new SqlParameter("@borrowoperId", SqlDbType.Int,4),
					new SqlParameter("@backoperId", SqlDbType.Int,4),
					new SqlParameter("@isBack", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.readerId;
			parameters[1].Value = model.bookCode;
			parameters[2].Value = model.borrowTime;
			parameters[3].Value = model.shouldBackTime;
			parameters[4].Value = model.realBackTime;
			parameters[5].Value = model.borrowoperId;
			parameters[6].Value = model.backoperId;
			parameters[7].Value = model.isBack;
			parameters[8].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BorrowandBack ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
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
			strSql.Append("delete from BorrowandBack ");
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
		public YueDuLibrary.Model.BorrowandBack GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,readerId,bookCode,borrowTime,shouldBackTime,realBackTime,borrowoperId,backoperId,isBack from BorrowandBack ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			YueDuLibrary.Model.BorrowandBack model=new YueDuLibrary.Model.BorrowandBack();
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
		public YueDuLibrary.Model.BorrowandBack DataRowToModel(DataRow row)
		{
			YueDuLibrary.Model.BorrowandBack model=new YueDuLibrary.Model.BorrowandBack();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["readerId"]!=null)
				{
					model.readerId=row["readerId"].ToString();
				}
				if(row["bookCode"]!=null)
				{
					model.bookCode=row["bookCode"].ToString();
				}
				if(row["borrowTime"]!=null && row["borrowTime"].ToString()!="")
				{
					model.borrowTime=DateTime.Parse(row["borrowTime"].ToString());
				}
				if(row["shouldBackTime"]!=null && row["shouldBackTime"].ToString()!="")
				{
					model.shouldBackTime=DateTime.Parse(row["shouldBackTime"].ToString());
				}
				if(row["realBackTime"]!=null && row["realBackTime"].ToString()!="")
				{
					model.realBackTime=DateTime.Parse(row["realBackTime"].ToString());
				}
				if(row["borrowoperId"]!=null && row["borrowoperId"].ToString()!="")
				{
					model.borrowoperId=int.Parse(row["borrowoperId"].ToString());
				}
				if(row["backoperId"]!=null && row["backoperId"].ToString()!="")
				{
					model.backoperId=int.Parse(row["backoperId"].ToString());
				}
				if(row["isBack"]!=null && row["isBack"].ToString()!="")
				{
					if((row["isBack"].ToString()=="1")||(row["isBack"].ToString().ToLower()=="true"))
					{
						model.isBack=true;
					}
					else
					{
						model.isBack=false;
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
			strSql.Append("select id,readerId,bookCode,borrowTime,shouldBackTime,realBackTime,borrowoperId,backoperId,isBack ");
			strSql.Append(" FROM BorrowandBack ");
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
			strSql.Append(" id,readerId,bookCode,borrowTime,shouldBackTime,realBackTime,borrowoperId,backoperId,isBack ");
			strSql.Append(" FROM BorrowandBack ");
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
			strSql.Append("select count(1) FROM BorrowandBack ");
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
			strSql.Append(")AS Row, T.*  from BorrowandBack T ");
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
			parameters[0].Value = "BorrowandBack";
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

