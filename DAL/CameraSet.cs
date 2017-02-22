using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace TJMonitor.DAL
{
    /// <summary>
    /// 数据访问类:CameraSet
    /// </summary>
    public partial class CameraSet
    {
        public CameraSet()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CameraSet");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(TJMonitor.Model.CameraSet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CameraSet(");
            strSql.Append("SavePath,ScanLines,OnceScanLines,TimeLeval,CCDPixels,CustomPixels,OtherPara1,OtherPara2,OtherPara3,OtherPara4,OtherPara5)");
            strSql.Append(" values (");
            strSql.Append("@SavePath,@ScanLines,@OnceScanLines,@TimeLeval,@CCDPixels,@CustomPixels,@OtherPara1,@OtherPara2,@OtherPara3,@OtherPara4,@OtherPara5)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@SavePath", OleDbType.VarChar,255),
					new OleDbParameter("@ScanLines", OleDbType.Integer,4),
					new OleDbParameter("@OnceScanLines", OleDbType.Integer,4),
					new OleDbParameter("@TimeLeval", OleDbType.Integer,4),
					new OleDbParameter("@CCDPixels", OleDbType.Integer,4),
					new OleDbParameter("@CustomPixels", OleDbType.Integer,4),
					new OleDbParameter("@OtherPara1", OleDbType.VarChar,255),
					new OleDbParameter("@OtherPara2", OleDbType.VarChar,255),
					new OleDbParameter("@OtherPara3", OleDbType.VarChar,255),
					new OleDbParameter("@OtherPara4", OleDbType.VarChar,255),
					new OleDbParameter("@OtherPara5", OleDbType.VarChar,255)};
            parameters[0].Value = model.SavePath;
            parameters[1].Value = model.ScanLines;
            parameters[2].Value = model.OnceScanLines;
            parameters[3].Value = model.TimeLeval;
            parameters[4].Value = model.CCDPixels;
            parameters[5].Value = model.CustomPixels;
            parameters[6].Value = model.OtherPara1;
            parameters[7].Value = model.OtherPara2;
            parameters[8].Value = model.OtherPara3;
            parameters[9].Value = model.OtherPara4;
            parameters[10].Value = model.OtherPara5;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(TJMonitor.Model.CameraSet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CameraSet set ");
            strSql.Append("SavePath=@SavePath,");
            strSql.Append("ScanLines=@ScanLines,");
            strSql.Append("OnceScanLines=@OnceScanLines,");
            strSql.Append("TimeLeval=@TimeLeval,");
            strSql.Append("CCDPixels=@CCDPixels,");
            strSql.Append("CustomPixels=@CustomPixels,");
            strSql.Append("OtherPara1=@OtherPara1,");
            strSql.Append("OtherPara2=@OtherPara2,");
            strSql.Append("OtherPara3=@OtherPara3,");
            strSql.Append("OtherPara4=@OtherPara4,");
            strSql.Append("OtherPara5=@OtherPara5");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@SavePath", OleDbType.VarChar,255),
					new OleDbParameter("@ScanLines", OleDbType.Integer,4),
					new OleDbParameter("@OnceScanLines", OleDbType.Integer,4),
					new OleDbParameter("@TimeLeval", OleDbType.Integer,4),
					new OleDbParameter("@CCDPixels", OleDbType.Integer,4),
					new OleDbParameter("@CustomPixels", OleDbType.Integer,4),
					new OleDbParameter("@OtherPara1", OleDbType.VarChar,255),
					new OleDbParameter("@OtherPara2", OleDbType.VarChar,255),
					new OleDbParameter("@OtherPara3", OleDbType.VarChar,255),
					new OleDbParameter("@OtherPara4", OleDbType.VarChar,255),
					new OleDbParameter("@OtherPara5", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.SavePath;
            parameters[1].Value = model.ScanLines;
            parameters[2].Value = model.OnceScanLines;
            parameters[3].Value = model.TimeLeval;
            parameters[4].Value = model.CCDPixels;
            parameters[5].Value = model.CustomPixels;
            parameters[6].Value = model.OtherPara1;
            parameters[7].Value = model.OtherPara2;
            parameters[8].Value = model.OtherPara3;
            parameters[9].Value = model.OtherPara4;
            parameters[10].Value = model.OtherPara5;
            parameters[11].Value = model.ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CameraSet ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CameraSet ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString());
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
        public TJMonitor.Model.CameraSet GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,SavePath,ScanLines,OnceScanLines,TimeLeval,CCDPixels,CustomPixels,OtherPara1,OtherPara2,OtherPara3,OtherPara4,OtherPara5 from CameraSet ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            TJMonitor.Model.CameraSet model = new TJMonitor.Model.CameraSet();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
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
        public TJMonitor.Model.CameraSet DataRowToModel(DataRow row)
        {
            TJMonitor.Model.CameraSet model = new TJMonitor.Model.CameraSet();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["SavePath"] != null)
                {
                    model.SavePath = row["SavePath"].ToString();
                }
                if (row["ScanLines"] != null && row["ScanLines"].ToString() != "")
                {
                    model.ScanLines = int.Parse(row["ScanLines"].ToString());
                }
                if (row["OnceScanLines"] != null && row["OnceScanLines"].ToString() != "")
                {
                    model.OnceScanLines = int.Parse(row["OnceScanLines"].ToString());
                }
                if (row["TimeLeval"] != null && row["TimeLeval"].ToString() != "")
                {
                    model.TimeLeval = int.Parse(row["TimeLeval"].ToString());
                }
                if (row["CCDPixels"] != null && row["CCDPixels"].ToString() != "")
                {
                    model.CCDPixels = int.Parse(row["CCDPixels"].ToString());
                }
                if (row["CustomPixels"] != null && row["CustomPixels"].ToString() != "")
                {
                    model.CustomPixels = int.Parse(row["CustomPixels"].ToString());
                }
                if (row["OtherPara1"] != null)
                {
                    model.OtherPara1 = row["OtherPara1"].ToString();
                }
                if (row["OtherPara2"] != null)
                {
                    model.OtherPara2 = row["OtherPara2"].ToString();
                }
                if (row["OtherPara3"] != null)
                {
                    model.OtherPara3 = row["OtherPara3"].ToString();
                }
                if (row["OtherPara4"] != null)
                {
                    model.OtherPara4 = row["OtherPara4"].ToString();
                }
                if (row["OtherPara5"] != null)
                {
                    model.OtherPara5 = row["OtherPara5"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,SavePath,ScanLines,OnceScanLines,TimeLeval,CCDPixels,CustomPixels,OtherPara1,OtherPara2,OtherPara3,OtherPara4,OtherPara5 ");
            strSql.Append(" FROM CameraSet ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM CameraSet ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from CameraSet T ");
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
            parameters[0].Value = "CameraSet";
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

