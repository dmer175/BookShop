using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace BookShop.DAL
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
		/// 增加一条数据
		/// </summary>
		public bool Add(BookShop.Model.BookInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BookInfo(");
			strSql.Append("Bid,Title,Titlehot,PriceOld,PriceNew,Author,Publisher,PublishDate,OnSaleDate,ISBN,TypeId,Detalis,ImgTitle)");
			strSql.Append(" values (");
			strSql.Append("@Bid,@Title,@Titlehot,@PriceOld,@PriceNew,@Author,@Publisher,@PublishDate,@OnSaleDate,@ISBN,@TypeId,@Detalis,@ImgTitle)");
			SqlParameter[] parameters = {
					new SqlParameter("@Bid", SqlDbType.VarChar,500),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Titlehot", SqlDbType.NVarChar,200),
					new SqlParameter("@PriceOld", SqlDbType.Decimal,5),
					new SqlParameter("@PriceNew", SqlDbType.Decimal,5),
					new SqlParameter("@Author", SqlDbType.NVarChar,20),
					new SqlParameter("@Publisher", SqlDbType.NVarChar,50),
					new SqlParameter("@PublishDate", SqlDbType.Date,3),
					new SqlParameter("@OnSaleDate", SqlDbType.Date,3),
					new SqlParameter("@ISBN", SqlDbType.VarChar,50),
					new SqlParameter("@TypeId", SqlDbType.NVarChar,50),
					new SqlParameter("@Detalis", SqlDbType.NVarChar,500),
					new SqlParameter("@ImgTitle", SqlDbType.VarChar,500)};
			parameters[0].Value = model.Bid;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Titlehot;
			parameters[3].Value = model.PriceOld;
			parameters[4].Value = model.PriceNew;
			parameters[5].Value = model.Author;
			parameters[6].Value = model.Publisher;
			parameters[7].Value = model.PublishDate;
			parameters[8].Value = model.OnSaleDate;
			parameters[9].Value = model.ISBN;
			parameters[10].Value = model.TypeId;
			parameters[11].Value = model.Detalis;
			parameters[12].Value = model.ImgTitle;

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
		public bool Update(BookShop.Model.BookInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BookInfo set ");
			strSql.Append("Bid=@Bid,");
			strSql.Append("Title=@Title,");
			strSql.Append("Titlehot=@Titlehot,");
			strSql.Append("PriceOld=@PriceOld,");
			strSql.Append("PriceNew=@PriceNew,");
			strSql.Append("Author=@Author,");
			strSql.Append("Publisher=@Publisher,");
			strSql.Append("PublishDate=@PublishDate,");
			strSql.Append("OnSaleDate=@OnSaleDate,");
			strSql.Append("ISBN=@ISBN,");
			strSql.Append("TypeId=@TypeId,");
			strSql.Append("Detalis=@Detalis,");
			strSql.Append("ImgTitle=@ImgTitle");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Bid", SqlDbType.VarChar,500),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Titlehot", SqlDbType.NVarChar,200),
					new SqlParameter("@PriceOld", SqlDbType.Decimal,5),
					new SqlParameter("@PriceNew", SqlDbType.Decimal,5),
					new SqlParameter("@Author", SqlDbType.NVarChar,20),
					new SqlParameter("@Publisher", SqlDbType.NVarChar,50),
					new SqlParameter("@PublishDate", SqlDbType.Date,3),
					new SqlParameter("@OnSaleDate", SqlDbType.Date,3),
					new SqlParameter("@ISBN", SqlDbType.VarChar,50),
					new SqlParameter("@TypeId", SqlDbType.NVarChar,50),
					new SqlParameter("@Detalis", SqlDbType.NVarChar,500),
					new SqlParameter("@ImgTitle", SqlDbType.VarChar,500)};
			parameters[0].Value = model.Bid;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Titlehot;
			parameters[3].Value = model.PriceOld;
			parameters[4].Value = model.PriceNew;
			parameters[5].Value = model.Author;
			parameters[6].Value = model.Publisher;
			parameters[7].Value = model.PublishDate;
			parameters[8].Value = model.OnSaleDate;
			parameters[9].Value = model.ISBN;
			parameters[10].Value = model.TypeId;
			parameters[11].Value = model.Detalis;
			parameters[12].Value = model.ImgTitle;

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
			strSql.Append("delete from BookInfo ");
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
		public BookShop.Model.BookInfo GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Bid,Title,Titlehot,PriceOld,PriceNew,Author,Publisher,PublishDate,OnSaleDate,ISBN,TypeId,Detalis,ImgTitle from BookInfo ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			BookShop.Model.BookInfo model=new BookShop.Model.BookInfo();
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
		public BookShop.Model.BookInfo DataRowToModel(DataRow row)
		{
			BookShop.Model.BookInfo model=new BookShop.Model.BookInfo();
			if (row != null)
			{
				if(row["Bid"]!=null)
				{
					model.Bid=row["Bid"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Titlehot"]!=null)
				{
					model.Titlehot=row["Titlehot"].ToString();
				}
				if(row["PriceOld"]!=null && row["PriceOld"].ToString()!="")
				{
					model.PriceOld=decimal.Parse(row["PriceOld"].ToString());
				}
				if(row["PriceNew"]!=null && row["PriceNew"].ToString()!="")
				{
					model.PriceNew=decimal.Parse(row["PriceNew"].ToString());
				}
				if(row["Author"]!=null)
				{
					model.Author=row["Author"].ToString();
				}
				if(row["Publisher"]!=null)
				{
					model.Publisher=row["Publisher"].ToString();
				}
				if(row["PublishDate"]!=null && row["PublishDate"].ToString()!="")
				{
					model.PublishDate=DateTime.Parse(row["PublishDate"].ToString());
				}
				if(row["OnSaleDate"]!=null && row["OnSaleDate"].ToString()!="")
				{
					model.OnSaleDate=DateTime.Parse(row["OnSaleDate"].ToString());
				}
				if(row["ISBN"]!=null)
				{
					model.ISBN=row["ISBN"].ToString();
				}
				if(row["TypeId"]!=null)
				{
					model.TypeId=row["TypeId"].ToString();
				}
				if(row["Detalis"]!=null)
				{
					model.Detalis=row["Detalis"].ToString();
				}
				if(row["ImgTitle"]!=null)
				{
					model.ImgTitle=row["ImgTitle"].ToString();
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
			strSql.Append("select Bid,Title,Titlehot,PriceOld,PriceNew,Author,Publisher,PublishDate,OnSaleDate,ISBN,TypeId,Detalis,ImgTitle ");
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
			strSql.Append(" Bid,Title,Titlehot,PriceOld,PriceNew,Author,Publisher,PublishDate,OnSaleDate,ISBN,TypeId,Detalis,ImgTitle ");
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
				strSql.Append("order by T. desc");
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
			parameters[1].Value = "";
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

