using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueDuLibrary.DAL
{
	/// <summary>
	/// 数据访问类:Reader
	/// </summary>
	public partial class Reader
	{
		public Reader()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string numberId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Reader");
			strSql.Append(" where numberId=@numberId ");
			SqlParameter[] parameters = {
					new SqlParameter("@numberId", SqlDbType.VarChar,20)			};
			parameters[0].Value = numberId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueDuLibrary.Model.Reader model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Reader(");
			strSql.Append("numberId,rdName,rdType,rdBirthday,rdPaperType,rdPaperNum,rdPhone,rdEmail,rdCreateDate,operId,remark,rdBorrownum,curNum,rdSex,rdImg)");
			strSql.Append(" values (");
			strSql.Append("@numberId,@rdName,@rdType,@rdBirthday,@rdPaperType,@rdPaperNum,@rdPhone,@rdEmail,@rdCreateDate,@operId,@remark,@rdBorrownum,@curNum,@rdSex,@rdImg)");
			SqlParameter[] parameters = {
					new SqlParameter("@numberId", SqlDbType.VarChar,20),
					new SqlParameter("@rdName", SqlDbType.VarChar,20),
					new SqlParameter("@rdType", SqlDbType.Int,4),
					new SqlParameter("@rdBirthday", SqlDbType.DateTime),
					new SqlParameter("@rdPaperType", SqlDbType.VarChar,14),
					new SqlParameter("@rdPaperNum", SqlDbType.VarChar,20),
					new SqlParameter("@rdPhone", SqlDbType.VarChar,11),
					new SqlParameter("@rdEmail", SqlDbType.VarChar,30),
					new SqlParameter("@rdCreateDate", SqlDbType.DateTime),
					new SqlParameter("@operId", SqlDbType.Int,4),
					new SqlParameter("@remark", SqlDbType.VarChar,50),
					new SqlParameter("@rdBorrownum", SqlDbType.Int,4),
					new SqlParameter("@curNum", SqlDbType.Int,4),
					new SqlParameter("@rdSex", SqlDbType.VarChar,4),
					new SqlParameter("@rdImg", SqlDbType.VarChar,60)};
			parameters[0].Value = model.numberId;
			parameters[1].Value = model.rdName;
			parameters[2].Value = model.rdType;
			parameters[3].Value = model.rdBirthday;
			parameters[4].Value = model.rdPaperType;
			parameters[5].Value = model.rdPaperNum;
			parameters[6].Value = model.rdPhone;
			parameters[7].Value = model.rdEmail;
			parameters[8].Value = model.rdCreateDate;
			parameters[9].Value = model.operId;
			parameters[10].Value = model.remark;
			parameters[11].Value = model.rdBorrownum;
			parameters[12].Value = model.curNum;
			parameters[13].Value = model.rdSex;
			parameters[14].Value = model.rdImg;

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
		public bool Update(YueDuLibrary.Model.Reader model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Reader set ");
			strSql.Append("rdName=@rdName,");
			strSql.Append("rdType=@rdType,");
			strSql.Append("rdBirthday=@rdBirthday,");
			strSql.Append("rdPaperType=@rdPaperType,");
			strSql.Append("rdPaperNum=@rdPaperNum,");
			strSql.Append("rdPhone=@rdPhone,");
			strSql.Append("rdEmail=@rdEmail,");
			strSql.Append("rdCreateDate=@rdCreateDate,");
			strSql.Append("operId=@operId,");
			strSql.Append("remark=@remark,");
			strSql.Append("rdBorrownum=@rdBorrownum,");
			strSql.Append("curNum=@curNum,");
			strSql.Append("rdSex=@rdSex,");
			strSql.Append("rdImg=@rdImg");
			strSql.Append(" where numberId=@numberId ");
			SqlParameter[] parameters = {
					new SqlParameter("@rdName", SqlDbType.VarChar,20),
					new SqlParameter("@rdType", SqlDbType.Int,4),
					new SqlParameter("@rdBirthday", SqlDbType.DateTime),
					new SqlParameter("@rdPaperType", SqlDbType.VarChar,14),
					new SqlParameter("@rdPaperNum", SqlDbType.VarChar,20),
					new SqlParameter("@rdPhone", SqlDbType.VarChar,11),
					new SqlParameter("@rdEmail", SqlDbType.VarChar,30),
					new SqlParameter("@rdCreateDate", SqlDbType.DateTime),
					new SqlParameter("@operId", SqlDbType.Int,4),
					new SqlParameter("@remark", SqlDbType.VarChar,50),
					new SqlParameter("@rdBorrownum", SqlDbType.Int,4),
					new SqlParameter("@curNum", SqlDbType.Int,4),
					new SqlParameter("@rdSex", SqlDbType.VarChar,4),
					new SqlParameter("@rdImg", SqlDbType.VarChar,60),
					new SqlParameter("@numberId", SqlDbType.VarChar,20)};
			parameters[0].Value = model.rdName;
			parameters[1].Value = model.rdType;
			parameters[2].Value = model.rdBirthday;
			parameters[3].Value = model.rdPaperType;
			parameters[4].Value = model.rdPaperNum;
			parameters[5].Value = model.rdPhone;
			parameters[6].Value = model.rdEmail;
			parameters[7].Value = model.rdCreateDate;
			parameters[8].Value = model.operId;
			parameters[9].Value = model.remark;
			parameters[10].Value = model.rdBorrownum;
			parameters[11].Value = model.curNum;
			parameters[12].Value = model.rdSex;
			parameters[13].Value = model.rdImg;
			parameters[14].Value = model.numberId;

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
		public bool Delete(string numberId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Reader ");
			strSql.Append(" where numberId=@numberId ");
			SqlParameter[] parameters = {
					new SqlParameter("@numberId", SqlDbType.VarChar,20)			};
			parameters[0].Value = numberId;

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
		public bool DeleteList(string numberIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Reader ");
			strSql.Append(" where numberId in ("+numberIdlist + ")  ");
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
		public YueDuLibrary.Model.Reader GetModel(string numberId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 numberId,rdName,rdType,rdBirthday,rdPaperType,rdPaperNum,rdPhone,rdEmail,rdCreateDate,operId,remark,rdBorrownum,curNum,rdSex,rdImg from Reader ");
			strSql.Append(" where numberId=@numberId ");
			SqlParameter[] parameters = {
					new SqlParameter("@numberId", SqlDbType.VarChar,20)			};
			parameters[0].Value = numberId;

			YueDuLibrary.Model.Reader model=new YueDuLibrary.Model.Reader();
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
		public YueDuLibrary.Model.Reader DataRowToModel(DataRow row)
		{
			YueDuLibrary.Model.Reader model=new YueDuLibrary.Model.Reader();
			if (row != null)
			{
				if(row["numberId"]!=null)
				{
					model.numberId=row["numberId"].ToString();
				}
				if(row["rdName"]!=null)
				{
					model.rdName=row["rdName"].ToString();
				}
				if(row["rdType"]!=null && row["rdType"].ToString()!="")
				{
					model.rdType=int.Parse(row["rdType"].ToString());
				}
				if(row["rdBirthday"]!=null && row["rdBirthday"].ToString()!="")
				{
					model.rdBirthday=DateTime.Parse(row["rdBirthday"].ToString());
				}
				if(row["rdPaperType"]!=null)
				{
					model.rdPaperType=row["rdPaperType"].ToString();
				}
				if(row["rdPaperNum"]!=null)
				{
					model.rdPaperNum=row["rdPaperNum"].ToString();
				}
				if(row["rdPhone"]!=null)
				{
					model.rdPhone=row["rdPhone"].ToString();
				}
				if(row["rdEmail"]!=null)
				{
					model.rdEmail=row["rdEmail"].ToString();
				}
				if(row["rdCreateDate"]!=null && row["rdCreateDate"].ToString()!="")
				{
					model.rdCreateDate=DateTime.Parse(row["rdCreateDate"].ToString());
				}
				if(row["operId"]!=null && row["operId"].ToString()!="")
				{
					model.operId=int.Parse(row["operId"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["rdBorrownum"]!=null && row["rdBorrownum"].ToString()!="")
				{
					model.rdBorrownum=int.Parse(row["rdBorrownum"].ToString());
				}
				if(row["curNum"]!=null && row["curNum"].ToString()!="")
				{
					model.curNum=int.Parse(row["curNum"].ToString());
				}
				if(row["rdSex"]!=null)
				{
					model.rdSex=row["rdSex"].ToString();
				}
				if(row["rdImg"]!=null)
				{
					model.rdImg=row["rdImg"].ToString();
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
			strSql.Append("select numberId,rdName,rdType,rdBirthday,rdPaperType,rdPaperNum,rdPhone,rdEmail,rdCreateDate,operId,remark,rdBorrownum,curNum,rdSex,rdImg ");
			strSql.Append(" FROM Reader ");
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
			strSql.Append(" numberId,rdName,rdType,rdBirthday,rdPaperType,rdPaperNum,rdPhone,rdEmail,rdCreateDate,operId,remark,rdBorrownum,curNum,rdSex,rdImg ");
			strSql.Append(" FROM Reader ");
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
			strSql.Append("select count(1) FROM Reader ");
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
				strSql.Append("order by T.numberId desc");
			}
			strSql.Append(")AS Row, T.*  from Reader T ");
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
			parameters[0].Value = "Reader";
			parameters[1].Value = "numberId";
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

