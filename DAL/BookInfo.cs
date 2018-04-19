using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueDuLibrary.DAL
{
	/// <summary>
	/// 数据访问类:BookInfo
	/// </summary>
	public partial class BookInfo
	{
		public BookInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("bookId", "BookInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int bookId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BookInfo");
			strSql.Append(" where bookId=@bookId");
			SqlParameter[] parameters = {
					new SqlParameter("@bookId", SqlDbType.Int,4)
			};
			parameters[0].Value = bookId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(YueDuLibrary.Model.BookInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BookInfo(");
			strSql.Append("bookCode,bookName,typeId,author,price,bookCaseId,bookPage,publish,operId,storage,bookImg)");
			strSql.Append(" values (");
			strSql.Append("@bookCode,@bookName,@typeId,@author,@price,@bookCaseId,@bookPage,@publish,@operId,@storage,@bookImg)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@bookCode", SqlDbType.VarChar,15),
					new SqlParameter("@bookName", SqlDbType.VarChar,40),
					new SqlParameter("@typeId", SqlDbType.VarChar,30),
					new SqlParameter("@author", SqlDbType.VarChar,30),
					new SqlParameter("@price", SqlDbType.VarChar,10),
					new SqlParameter("@bookCaseId", SqlDbType.Int,4),
					new SqlParameter("@bookPage", SqlDbType.Int,4),
					new SqlParameter("@publish", SqlDbType.VarChar,100),
					new SqlParameter("@operId", SqlDbType.Int,4),
					new SqlParameter("@storage", SqlDbType.Int,4),
				
					new SqlParameter("@bookImg", SqlDbType.VarChar,60)};
			parameters[0].Value = model.bookCode;
			parameters[1].Value = model.bookName;
			parameters[2].Value = model.typeId;
			parameters[3].Value = model.author;
			parameters[4].Value = model.price;
			parameters[5].Value = model.bookCaseId;
			parameters[6].Value = model.bookPage;
			parameters[7].Value = model.publish;
			parameters[8].Value = model.operId;
			parameters[9].Value = model.storage;
			parameters[10].Value = model.bookImg;

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
		public bool Update(YueDuLibrary.Model.BookInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BookInfo set ");
			strSql.Append("bookCode=@bookCode,");
			strSql.Append("bookName=@bookName,");
			strSql.Append("typeId=@typeId,");
			strSql.Append("author=@author,");
			strSql.Append("price=@price,");
			strSql.Append("bookCaseId=@bookCaseId,");
			strSql.Append("bookPage=@bookPage,");
			strSql.Append("publish=@publish,");
			strSql.Append("operId=@operId,");
			strSql.Append("storage=@storage,");
			strSql.Append("InCreateTime=@InCreateTime,");
			strSql.Append("bookImg=@bookImg");
			strSql.Append(" where bookId=@bookId");
			SqlParameter[] parameters = {
					new SqlParameter("@bookCode", SqlDbType.VarChar,15),
					new SqlParameter("@bookName", SqlDbType.VarChar,40),
					new SqlParameter("@typeId", SqlDbType.VarChar,30),
					new SqlParameter("@author", SqlDbType.VarChar,30),
					new SqlParameter("@price", SqlDbType.VarChar,10),
					new SqlParameter("@bookCaseId", SqlDbType.Int,4),
					new SqlParameter("@bookPage", SqlDbType.Int,4),
					new SqlParameter("@publish", SqlDbType.VarChar,100),
					new SqlParameter("@operId", SqlDbType.Int,4),
					new SqlParameter("@storage", SqlDbType.Int,4),
					new SqlParameter("@InCreateTime", SqlDbType.DateTime),
					new SqlParameter("@bookImg", SqlDbType.VarChar,60),
					new SqlParameter("@bookId", SqlDbType.Int,4)};
			parameters[0].Value = model.bookCode;
			parameters[1].Value = model.bookName;
			parameters[2].Value = model.typeId;
			parameters[3].Value = model.author;
			parameters[4].Value = model.price;
			parameters[5].Value = model.bookCaseId;
			parameters[6].Value = model.bookPage;
			parameters[7].Value = model.publish;
			parameters[8].Value = model.operId;
			parameters[9].Value = model.storage;
			parameters[10].Value = model.InCreateTime;
			parameters[11].Value = model.bookImg;
			parameters[12].Value = model.bookId;

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
		public bool Delete(int bookId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookInfo ");
			strSql.Append(" where bookId=@bookId");
			SqlParameter[] parameters = {
					new SqlParameter("@bookId", SqlDbType.Int,4)
			};
			parameters[0].Value = bookId;

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
		public bool DeleteList(string bookIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookInfo ");
			strSql.Append(" where bookId in ("+bookIdlist + ")  ");
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
		public YueDuLibrary.Model.BookInfo GetModel(int bookId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 bookId,bookCode,bookName,typeId,author,price,bookCaseId,bookPage,publish,operId,storage,InCreateTime,bookImg from BookInfo ");
			strSql.Append(" where bookId=@bookId");
			SqlParameter[] parameters = {
					new SqlParameter("@bookId", SqlDbType.Int,4)
			};
			parameters[0].Value = bookId;

			YueDuLibrary.Model.BookInfo model=new YueDuLibrary.Model.BookInfo();
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
        /// 通过bookCode得到一个对象实体
        /// </summary>
        public YueDuLibrary.Model.BookInfo GetModeBybookCode(string bookCode)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 bookId,bookCode,bookName,typeId,author,price,bookCaseId,bookPage,publish,operId,storage,InCreateTime,bookImg from BookInfo ");
            strSql.Append(" where bookCode=@bookCode");
            SqlParameter[] parameters = {
                    new SqlParameter("@bookCode", SqlDbType.NVarChar,15)
            };
            parameters[0].Value = bookCode;

            YueDuLibrary.Model.BookInfo model = new YueDuLibrary.Model.BookInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public YueDuLibrary.Model.BookInfo DataRowToModel(DataRow row)
		{
			YueDuLibrary.Model.BookInfo model=new YueDuLibrary.Model.BookInfo();
			if (row != null)
			{
				if(row["bookId"]!=null && row["bookId"].ToString()!="")
				{
					model.bookId=int.Parse(row["bookId"].ToString());
				}
				if(row["bookCode"]!=null)
				{
					model.bookCode=row["bookCode"].ToString();
				}
				if(row["bookName"]!=null)
				{
					model.bookName=row["bookName"].ToString();
				}
				if(row["typeId"]!=null)
				{
					model.typeId=row["typeId"].ToString();
				}
				if(row["author"]!=null)
				{
					model.author=row["author"].ToString();
				}
				if(row["price"]!=null)
				{
					model.price=row["price"].ToString();
				}
				if(row["bookCaseId"]!=null && row["bookCaseId"].ToString()!="")
				{
					model.bookCaseId=int.Parse(row["bookCaseId"].ToString());
				}
				if(row["bookPage"]!=null && row["bookPage"].ToString()!="")
				{
					model.bookPage=int.Parse(row["bookPage"].ToString());
				}
				if(row["publish"]!=null)
				{
					model.publish=row["publish"].ToString();
				}
				if(row["operId"]!=null && row["operId"].ToString()!="")
				{
					model.operId=int.Parse(row["operId"].ToString());
				}
				if(row["storage"]!=null && row["storage"].ToString()!="")
				{
					model.storage=int.Parse(row["storage"].ToString());
				}
				if(row["InCreateTime"]!=null && row["InCreateTime"].ToString()!="")
				{
					model.InCreateTime=DateTime.Parse(row["InCreateTime"].ToString());
				}
				if(row["bookImg"]!=null)
				{
					model.bookImg=row["bookImg"].ToString();
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
			strSql.Append("select bookId,bookCode,bookName,typeId,author,price,bookCaseId,bookPage,publish,operId,storage,InCreateTime,bookImg ");
			strSql.Append(" FROM BookInfo ");
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
			strSql.Append(" bookId,bookCode,bookName,typeId,author,price,bookCaseId,bookPage,publish,operId,storage,InCreateTime,bookImg ");
			strSql.Append(" FROM BookInfo ");
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
			strSql.Append("select count(1) FROM BookInfo ");
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
				strSql.Append("order by T.bookId desc");
			}
			strSql.Append(")AS Row, T.*  from BookInfo T ");
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
			parameters[0].Value = "BookInfo";
			parameters[1].Value = "bookId";
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

