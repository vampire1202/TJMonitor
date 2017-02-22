using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace TJMonitor.DAL
{
	/// <summary>
	/// 数据访问类:MonitorInfo
	/// </summary>
	public partial class MonitorInfo
	{
		public MonitorInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("ID", "MonitorInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MonitorInfo");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TJMonitor.Model.MonitorInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MonitorInfo(");
			strSql.Append("carLicense,carDirection,scanTime,scanDataPath,cameraPic,parameter1,parameter2,parameter3,parameter4,parameter5,sigh,isBlack)");
			strSql.Append(" values (");
			strSql.Append("@carLicense,@carDirection,@scanTime,@scanDataPath,@cameraPic,@parameter1,@parameter2,@parameter3,@parameter4,@parameter5,@sigh,@isBlack)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@carLicense", OleDbType.VarChar,255),
					new OleDbParameter("@carDirection", OleDbType.VarChar,255),
					new OleDbParameter("@scanTime", OleDbType.Date),
					new OleDbParameter("@scanDataPath", OleDbType.VarChar,255),
					new OleDbParameter("@cameraPic", OleDbType.VarChar,255),
					new OleDbParameter("@parameter1", OleDbType.VarChar,255),
					new OleDbParameter("@parameter2", OleDbType.VarChar,255),
					new OleDbParameter("@parameter3", OleDbType.VarChar,255),
					new OleDbParameter("@parameter4", OleDbType.VarChar,255),
					new OleDbParameter("@parameter5", OleDbType.VarChar,255),
					new OleDbParameter("@sigh", OleDbType.VarChar,0),
					new OleDbParameter("@isBlack", OleDbType.Boolean,1)};
			parameters[0].Value = model.carLicense;
			parameters[1].Value = model.carDirection;
			parameters[2].Value = model.scanTime;
			parameters[3].Value = model.scanDataPath;
			parameters[4].Value = model.cameraPic;
			parameters[5].Value = model.parameter1;
			parameters[6].Value = model.parameter2;
			parameters[7].Value = model.parameter3;
			parameters[8].Value = model.parameter4;
			parameters[9].Value = model.parameter5;
			parameters[10].Value = model.sigh;
			parameters[11].Value = model.isBlack;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(TJMonitor.Model.MonitorInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MonitorInfo set ");
			strSql.Append("carLicense=@carLicense,");
			strSql.Append("carDirection=@carDirection,");
			strSql.Append("scanTime=@scanTime,");
			strSql.Append("scanDataPath=@scanDataPath,");
			strSql.Append("cameraPic=@cameraPic,");
			strSql.Append("parameter1=@parameter1,");
			strSql.Append("parameter2=@parameter2,");
			strSql.Append("parameter3=@parameter3,");
			strSql.Append("parameter4=@parameter4,");
			strSql.Append("parameter5=@parameter5,");
			strSql.Append("sigh=@sigh,");
			strSql.Append("isBlack=@isBlack");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@carLicense", OleDbType.VarChar,255),
					new OleDbParameter("@carDirection", OleDbType.VarChar,255),
					new OleDbParameter("@scanTime", OleDbType.Date),
					new OleDbParameter("@scanDataPath", OleDbType.VarChar,255),
					new OleDbParameter("@cameraPic", OleDbType.VarChar,255),
					new OleDbParameter("@parameter1", OleDbType.VarChar,255),
					new OleDbParameter("@parameter2", OleDbType.VarChar,255),
					new OleDbParameter("@parameter3", OleDbType.VarChar,255),
					new OleDbParameter("@parameter4", OleDbType.VarChar,255),
					new OleDbParameter("@parameter5", OleDbType.VarChar,255),
					new OleDbParameter("@sigh", OleDbType.VarChar,0),
					new OleDbParameter("@isBlack", OleDbType.Boolean,1),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = model.carLicense;
			parameters[1].Value = model.carDirection;
			parameters[2].Value = model.scanTime;
			parameters[3].Value = model.scanDataPath;
			parameters[4].Value = model.cameraPic;
			parameters[5].Value = model.parameter1;
			parameters[6].Value = model.parameter2;
			parameters[7].Value = model.parameter3;
			parameters[8].Value = model.parameter4;
			parameters[9].Value = model.parameter5;
			parameters[10].Value = model.sigh;
			parameters[11].Value = model.isBlack;
			parameters[12].Value = model.ID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MonitorInfo ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MonitorInfo ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
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
		public TJMonitor.Model.MonitorInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,carLicense,carDirection,scanTime,scanDataPath,cameraPic,parameter1,parameter2,parameter3,parameter4,parameter5,sigh,isBlack from MonitorInfo ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			TJMonitor.Model.MonitorInfo model=new TJMonitor.Model.MonitorInfo();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
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
		public TJMonitor.Model.MonitorInfo DataRowToModel(DataRow row)
		{
			TJMonitor.Model.MonitorInfo model=new TJMonitor.Model.MonitorInfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["carLicense"]!=null)
				{
					model.carLicense=row["carLicense"].ToString();
				}
				if(row["carDirection"]!=null)
				{
					model.carDirection=row["carDirection"].ToString();
				}
				if(row["scanTime"]!=null && row["scanTime"].ToString()!="")
				{
					model.scanTime=DateTime.Parse(row["scanTime"].ToString());
				}
				if(row["scanDataPath"]!=null)
				{
					model.scanDataPath=row["scanDataPath"].ToString();
				}
				if(row["cameraPic"]!=null)
				{
					model.cameraPic=row["cameraPic"].ToString();
				}
				if(row["parameter1"]!=null)
				{
					model.parameter1=row["parameter1"].ToString();
				}
				if(row["parameter2"]!=null)
				{
					model.parameter2=row["parameter2"].ToString();
				}
				if(row["parameter3"]!=null)
				{
					model.parameter3=row["parameter3"].ToString();
				}
				if(row["parameter4"]!=null)
				{
					model.parameter4=row["parameter4"].ToString();
				}
				if(row["parameter5"]!=null)
				{
					model.parameter5=row["parameter5"].ToString();
				}
				if(row["sigh"]!=null)
				{
					model.sigh=row["sigh"].ToString();
				}
				if(row["isBlack"]!=null && row["isBlack"].ToString()!="")
				{
					if((row["isBlack"].ToString()=="1")||(row["isBlack"].ToString().ToLower()=="true"))
					{
						model.isBlack=true;
					}
					else
					{
						model.isBlack=false;
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
			strSql.Append("select ID,carLicense as [车牌号码],carDirection as [方向],scanTime as [扫描时间],scanDataPath as [车底图像],cameraPic as [车辆照片],isBlack as [黑名单]");
			strSql.Append(" FROM MonitorInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM MonitorInfo ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from MonitorInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "MonitorInfo";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

