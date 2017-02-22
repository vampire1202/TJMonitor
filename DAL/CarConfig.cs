using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace TJMonitor.DAL
{
    /// <summary>
    /// 数据访问类:CarConfig
    /// </summary>
    public partial class CarConfig
    {
        public CarConfig()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperOleDb.GetMaxID("id", "CarConfig");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CarConfig");
            strSql.Append(" where id=@id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)			};
            parameters[0].Value = id;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(TJMonitor.Model.CarConfig model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CarConfig(");
            strSql.Append("id,firstLetter,brand,carSeries,saleStatus,seriesName,modelYear,price,exhaust,manufacturer,leval,engine,transmissionBox,size,structure,maxSpeed,official0to100,actual0to100,actualBrake,actual,oilconsumption,groundClearance,minGroundClearance,warranty,length,width,height,wheelbase,frontTrack,rearWheel,weigh,cardoors,carseats,tankVolume,trunkVolume,engineModel,MaxPs,maxP,maxPRpm,maxTorque,maxRpm,gears,transmissionBoxMode,frontSuspension,backSuspension,helpStyle,carStructure,frontTireSize,backTireSize,spareTireSize,appearanceColor,appearanceColorCode,innerColor,innerColorCode,packingBoxSize,underPic)");
            strSql.Append(" values (");
            strSql.Append("@id,@firstLetter,@brand,@carSeries,@saleStatus,@seriesName,@modelYear,@price,@exhaust,@manufacturer,@leval,@engine,@transmissionBox,@size,@structure,@maxSpeed,@official0to100,@actual0to100,@actualBrake,@actual,@oilconsumption,@groundClearance,@minGroundClearance,@warranty,@length,@width,@height,@wheelbase,@frontTrack,@rearWheel,@weigh,@cardoors,@carseats,@tankVolume,@trunkVolume,@engineModel,@MaxPs,@maxP,@maxPRpm,@maxTorque,@maxRpm,@gears,@transmissionBoxMode,@frontSuspension,@backSuspension,@helpStyle,@carStructure,@frontTireSize,@backTireSize,@spareTireSize,@appearanceColor,@appearanceColorCode,@innerColor,@innerColorCode,@packingBoxSize,@underPic)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4),
					new OleDbParameter("@firstLetter", OleDbType.VarChar,150),
					new OleDbParameter("@brand", OleDbType.VarChar,150),
					new OleDbParameter("@carSeries", OleDbType.VarChar,150),
					new OleDbParameter("@saleStatus", OleDbType.VarChar,150),
					new OleDbParameter("@seriesName", OleDbType.VarChar,0),
					new OleDbParameter("@modelYear", OleDbType.VarChar,150),
					new OleDbParameter("@price", OleDbType.VarChar,150),
					new OleDbParameter("@exhaust", OleDbType.VarChar,150),
					new OleDbParameter("@manufacturer", OleDbType.VarChar,150),
					new OleDbParameter("@leval", OleDbType.VarChar,150),
					new OleDbParameter("@engine", OleDbType.VarChar,150),
					new OleDbParameter("@transmissionBox", OleDbType.VarChar,150),
					new OleDbParameter("@size", OleDbType.VarChar,150),
					new OleDbParameter("@structure", OleDbType.VarChar,150),
					new OleDbParameter("@maxSpeed", OleDbType.VarChar,150),
					new OleDbParameter("@official0to100", OleDbType.VarChar,150),
					new OleDbParameter("@actual0to100", OleDbType.VarChar,150),
					new OleDbParameter("@actualBrake", OleDbType.VarChar,150),
					new OleDbParameter("@actual", OleDbType.VarChar,150),
					new OleDbParameter("@oilconsumption", OleDbType.VarChar,150),
					new OleDbParameter("@groundClearance", OleDbType.VarChar,150),
					new OleDbParameter("@minGroundClearance", OleDbType.VarChar,150),
					new OleDbParameter("@warranty", OleDbType.VarChar,150),
					new OleDbParameter("@length", OleDbType.VarChar,150),
					new OleDbParameter("@width", OleDbType.VarChar,150),
					new OleDbParameter("@height", OleDbType.VarChar,150),
					new OleDbParameter("@wheelbase", OleDbType.VarChar,150),
					new OleDbParameter("@frontTrack", OleDbType.VarChar,150),
					new OleDbParameter("@rearWheel", OleDbType.VarChar,150),
					new OleDbParameter("@weigh", OleDbType.VarChar,150),
					new OleDbParameter("@cardoors", OleDbType.VarChar,150),
					new OleDbParameter("@carseats", OleDbType.VarChar,150),
					new OleDbParameter("@tankVolume", OleDbType.VarChar,150),
					new OleDbParameter("@trunkVolume", OleDbType.VarChar,150),
					new OleDbParameter("@engineModel", OleDbType.VarChar,150),
					new OleDbParameter("@MaxPs", OleDbType.VarChar,150),
					new OleDbParameter("@maxP", OleDbType.VarChar,150),
					new OleDbParameter("@maxPRpm", OleDbType.VarChar,150),
					new OleDbParameter("@maxTorque", OleDbType.VarChar,150),
					new OleDbParameter("@maxRpm", OleDbType.VarChar,150),
					new OleDbParameter("@gears", OleDbType.VarChar,150),
					new OleDbParameter("@transmissionBoxMode", OleDbType.VarChar,150),
					new OleDbParameter("@frontSuspension", OleDbType.VarChar,150),
					new OleDbParameter("@backSuspension", OleDbType.VarChar,150),
					new OleDbParameter("@helpStyle", OleDbType.VarChar,150),
					new OleDbParameter("@carStructure", OleDbType.VarChar,150),
					new OleDbParameter("@frontTireSize", OleDbType.VarChar,150),
					new OleDbParameter("@backTireSize", OleDbType.VarChar,150),
					new OleDbParameter("@spareTireSize", OleDbType.VarChar,150),
					new OleDbParameter("@appearanceColor", OleDbType.VarChar,0),
					new OleDbParameter("@appearanceColorCode", OleDbType.VarChar,0),
					new OleDbParameter("@innerColor", OleDbType.VarChar,0),
					new OleDbParameter("@innerColorCode", OleDbType.VarChar,0),
					new OleDbParameter("@packingBoxSize", OleDbType.VarChar,150),
					new OleDbParameter("@underPic", OleDbType.VarChar,255)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.firstLetter;
            parameters[2].Value = model.brand;
            parameters[3].Value = model.carSeries;
            parameters[4].Value = model.saleStatus;
            parameters[5].Value = model.seriesName;
            parameters[6].Value = model.modelYear;
            parameters[7].Value = model.price;
            parameters[8].Value = model.exhaust;
            parameters[9].Value = model.manufacturer;
            parameters[10].Value = model.leval;
            parameters[11].Value = model.engine;
            parameters[12].Value = model.transmissionBox;
            parameters[13].Value = model.size;
            parameters[14].Value = model.structure;
            parameters[15].Value = model.maxSpeed;
            parameters[16].Value = model.official0to100;
            parameters[17].Value = model.actual0to100;
            parameters[18].Value = model.actualBrake;
            parameters[19].Value = model.actual;
            parameters[20].Value = model.oilconsumption;
            parameters[21].Value = model.groundClearance;
            parameters[22].Value = model.minGroundClearance;
            parameters[23].Value = model.warranty;
            parameters[24].Value = model.length;
            parameters[25].Value = model.width;
            parameters[26].Value = model.height;
            parameters[27].Value = model.wheelbase;
            parameters[28].Value = model.frontTrack;
            parameters[29].Value = model.rearWheel;
            parameters[30].Value = model.weigh;
            parameters[31].Value = model.cardoors;
            parameters[32].Value = model.carseats;
            parameters[33].Value = model.tankVolume;
            parameters[34].Value = model.trunkVolume;
            parameters[35].Value = model.engineModel;
            parameters[36].Value = model.MaxPs;
            parameters[37].Value = model.maxP;
            parameters[38].Value = model.maxPRpm;
            parameters[39].Value = model.maxTorque;
            parameters[40].Value = model.maxRpm;
            parameters[41].Value = model.gears;
            parameters[42].Value = model.transmissionBoxMode;
            parameters[43].Value = model.frontSuspension;
            parameters[44].Value = model.backSuspension;
            parameters[45].Value = model.helpStyle;
            parameters[46].Value = model.carStructure;
            parameters[47].Value = model.frontTireSize;
            parameters[48].Value = model.backTireSize;
            parameters[49].Value = model.spareTireSize;
            parameters[50].Value = model.appearanceColor;
            parameters[51].Value = model.appearanceColorCode;
            parameters[52].Value = model.innerColor;
            parameters[53].Value = model.innerColorCode;
            parameters[54].Value = model.packingBoxSize;
            parameters[55].Value = model.underPic;

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
        public bool Update(TJMonitor.Model.CarConfig model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CarConfig set ");
            strSql.Append("firstLetter=@firstLetter,");
            strSql.Append("brand=@brand,");
            strSql.Append("carSeries=@carSeries,");
            strSql.Append("saleStatus=@saleStatus,");
            strSql.Append("seriesName=@seriesName,");
            strSql.Append("modelYear=@modelYear,");
            strSql.Append("price=@price,");
            strSql.Append("exhaust=@exhaust,");
            strSql.Append("manufacturer=@manufacturer,");
            strSql.Append("leval=@leval,");
            strSql.Append("engine=@engine,");
            strSql.Append("transmissionBox=@transmissionBox,");
            strSql.Append("size=@size,");
            strSql.Append("structure=@structure,");
            strSql.Append("maxSpeed=@maxSpeed,");
            strSql.Append("official0to100=@official0to100,");
            strSql.Append("actual0to100=@actual0to100,");
            strSql.Append("actualBrake=@actualBrake,");
            strSql.Append("actual=@actual,");
            strSql.Append("oilconsumption=@oilconsumption,");
            strSql.Append("groundClearance=@groundClearance,");
            strSql.Append("minGroundClearance=@minGroundClearance,");
            strSql.Append("warranty=@warranty,");
            strSql.Append("length=@length,");
            strSql.Append("width=@width,");
            strSql.Append("height=@height,");
            strSql.Append("wheelbase=@wheelbase,");
            strSql.Append("frontTrack=@frontTrack,");
            strSql.Append("rearWheel=@rearWheel,");
            strSql.Append("weigh=@weigh,");
            strSql.Append("cardoors=@cardoors,");
            strSql.Append("carseats=@carseats,");
            strSql.Append("tankVolume=@tankVolume,");
            strSql.Append("trunkVolume=@trunkVolume,");
            strSql.Append("engineModel=@engineModel,");
            strSql.Append("MaxPs=@MaxPs,");
            strSql.Append("maxP=@maxP,");
            strSql.Append("maxPRpm=@maxPRpm,");
            strSql.Append("maxTorque=@maxTorque,");
            strSql.Append("maxRpm=@maxRpm,");
            strSql.Append("gears=@gears,");
            strSql.Append("transmissionBoxMode=@transmissionBoxMode,");
            strSql.Append("frontSuspension=@frontSuspension,");
            strSql.Append("backSuspension=@backSuspension,");
            strSql.Append("helpStyle=@helpStyle,");
            strSql.Append("carStructure=@carStructure,");
            strSql.Append("frontTireSize=@frontTireSize,");
            strSql.Append("backTireSize=@backTireSize,");
            strSql.Append("spareTireSize=@spareTireSize,");
            strSql.Append("appearanceColor=@appearanceColor,");
            strSql.Append("appearanceColorCode=@appearanceColorCode,");
            strSql.Append("innerColor=@innerColor,");
            strSql.Append("innerColorCode=@innerColorCode,");
            strSql.Append("packingBoxSize=@packingBoxSize,");
            strSql.Append("underPic=@underPic");
            strSql.Append(" where id=@id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@firstLetter", OleDbType.VarChar,150),
					new OleDbParameter("@brand", OleDbType.VarChar,150),
					new OleDbParameter("@carSeries", OleDbType.VarChar,150),
					new OleDbParameter("@saleStatus", OleDbType.VarChar,150),
					new OleDbParameter("@seriesName", OleDbType.VarChar,0),
					new OleDbParameter("@modelYear", OleDbType.VarChar,150),
					new OleDbParameter("@price", OleDbType.VarChar,150),
					new OleDbParameter("@exhaust", OleDbType.VarChar,150),
					new OleDbParameter("@manufacturer", OleDbType.VarChar,150),
					new OleDbParameter("@leval", OleDbType.VarChar,150),
					new OleDbParameter("@engine", OleDbType.VarChar,150),
					new OleDbParameter("@transmissionBox", OleDbType.VarChar,150),
					new OleDbParameter("@size", OleDbType.VarChar,150),
					new OleDbParameter("@structure", OleDbType.VarChar,150),
					new OleDbParameter("@maxSpeed", OleDbType.VarChar,150),
					new OleDbParameter("@official0to100", OleDbType.VarChar,150),
					new OleDbParameter("@actual0to100", OleDbType.VarChar,150),
					new OleDbParameter("@actualBrake", OleDbType.VarChar,150),
					new OleDbParameter("@actual", OleDbType.VarChar,150),
					new OleDbParameter("@oilconsumption", OleDbType.VarChar,150),
					new OleDbParameter("@groundClearance", OleDbType.VarChar,150),
					new OleDbParameter("@minGroundClearance", OleDbType.VarChar,150),
					new OleDbParameter("@warranty", OleDbType.VarChar,150),
					new OleDbParameter("@length", OleDbType.VarChar,150),
					new OleDbParameter("@width", OleDbType.VarChar,150),
					new OleDbParameter("@height", OleDbType.VarChar,150),
					new OleDbParameter("@wheelbase", OleDbType.VarChar,150),
					new OleDbParameter("@frontTrack", OleDbType.VarChar,150),
					new OleDbParameter("@rearWheel", OleDbType.VarChar,150),
					new OleDbParameter("@weigh", OleDbType.VarChar,150),
					new OleDbParameter("@cardoors", OleDbType.VarChar,150),
					new OleDbParameter("@carseats", OleDbType.VarChar,150),
					new OleDbParameter("@tankVolume", OleDbType.VarChar,150),
					new OleDbParameter("@trunkVolume", OleDbType.VarChar,150),
					new OleDbParameter("@engineModel", OleDbType.VarChar,150),
					new OleDbParameter("@MaxPs", OleDbType.VarChar,150),
					new OleDbParameter("@maxP", OleDbType.VarChar,150),
					new OleDbParameter("@maxPRpm", OleDbType.VarChar,150),
					new OleDbParameter("@maxTorque", OleDbType.VarChar,150),
					new OleDbParameter("@maxRpm", OleDbType.VarChar,150),
					new OleDbParameter("@gears", OleDbType.VarChar,150),
					new OleDbParameter("@transmissionBoxMode", OleDbType.VarChar,150),
					new OleDbParameter("@frontSuspension", OleDbType.VarChar,150),
					new OleDbParameter("@backSuspension", OleDbType.VarChar,150),
					new OleDbParameter("@helpStyle", OleDbType.VarChar,150),
					new OleDbParameter("@carStructure", OleDbType.VarChar,150),
					new OleDbParameter("@frontTireSize", OleDbType.VarChar,150),
					new OleDbParameter("@backTireSize", OleDbType.VarChar,150),
					new OleDbParameter("@spareTireSize", OleDbType.VarChar,150),
					new OleDbParameter("@appearanceColor", OleDbType.VarChar,0),
					new OleDbParameter("@appearanceColorCode", OleDbType.VarChar,0),
					new OleDbParameter("@innerColor", OleDbType.VarChar,0),
					new OleDbParameter("@innerColorCode", OleDbType.VarChar,0),
					new OleDbParameter("@packingBoxSize", OleDbType.VarChar,150),
					new OleDbParameter("@underPic", OleDbType.VarChar,255),
					new OleDbParameter("@id", OleDbType.Integer,4)};
            parameters[0].Value = model.firstLetter;
            parameters[1].Value = model.brand;
            parameters[2].Value = model.carSeries;
            parameters[3].Value = model.saleStatus;
            parameters[4].Value = model.seriesName;
            parameters[5].Value = model.modelYear;
            parameters[6].Value = model.price;
            parameters[7].Value = model.exhaust;
            parameters[8].Value = model.manufacturer;
            parameters[9].Value = model.leval;
            parameters[10].Value = model.engine;
            parameters[11].Value = model.transmissionBox;
            parameters[12].Value = model.size;
            parameters[13].Value = model.structure;
            parameters[14].Value = model.maxSpeed;
            parameters[15].Value = model.official0to100;
            parameters[16].Value = model.actual0to100;
            parameters[17].Value = model.actualBrake;
            parameters[18].Value = model.actual;
            parameters[19].Value = model.oilconsumption;
            parameters[20].Value = model.groundClearance;
            parameters[21].Value = model.minGroundClearance;
            parameters[22].Value = model.warranty;
            parameters[23].Value = model.length;
            parameters[24].Value = model.width;
            parameters[25].Value = model.height;
            parameters[26].Value = model.wheelbase;
            parameters[27].Value = model.frontTrack;
            parameters[28].Value = model.rearWheel;
            parameters[29].Value = model.weigh;
            parameters[30].Value = model.cardoors;
            parameters[31].Value = model.carseats;
            parameters[32].Value = model.tankVolume;
            parameters[33].Value = model.trunkVolume;
            parameters[34].Value = model.engineModel;
            parameters[35].Value = model.MaxPs;
            parameters[36].Value = model.maxP;
            parameters[37].Value = model.maxPRpm;
            parameters[38].Value = model.maxTorque;
            parameters[39].Value = model.maxRpm;
            parameters[40].Value = model.gears;
            parameters[41].Value = model.transmissionBoxMode;
            parameters[42].Value = model.frontSuspension;
            parameters[43].Value = model.backSuspension;
            parameters[44].Value = model.helpStyle;
            parameters[45].Value = model.carStructure;
            parameters[46].Value = model.frontTireSize;
            parameters[47].Value = model.backTireSize;
            parameters[48].Value = model.spareTireSize;
            parameters[49].Value = model.appearanceColor;
            parameters[50].Value = model.appearanceColorCode;
            parameters[51].Value = model.innerColor;
            parameters[52].Value = model.innerColorCode;
            parameters[53].Value = model.packingBoxSize;
            parameters[54].Value = model.underPic;
            parameters[55].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CarConfig ");
            strSql.Append(" where id=@id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CarConfig ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public TJMonitor.Model.CarConfig GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,firstLetter,brand,carSeries,saleStatus,seriesName,modelYear,price,exhaust,manufacturer,leval,engine,transmissionBox,size,structure,maxSpeed,official0to100,actual0to100,actualBrake,actual,oilconsumption,groundClearance,minGroundClearance,warranty,length,width,height,wheelbase,frontTrack,rearWheel,weigh,cardoors,carseats,tankVolume,trunkVolume,engineModel,MaxPs,maxP,maxPRpm,maxTorque,maxRpm,gears,transmissionBoxMode,frontSuspension,backSuspension,helpStyle,carStructure,frontTireSize,backTireSize,spareTireSize,appearanceColor,appearanceColorCode,innerColor,innerColorCode,packingBoxSize,underPic from CarConfig ");
            strSql.Append(" where id=@id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)			};
            parameters[0].Value = id;

            TJMonitor.Model.CarConfig model = new TJMonitor.Model.CarConfig();
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

        public TJMonitor.Model.CarConfig GetModel(string carSeries)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 [id],firstLetter,brand,carSeries,saleStatus,seriesName,modelYear,[price],[exhaust],[manufacturer],[leval],[engine],transmissionBox,[size],[structure],maxSpeed,official0to100,actual0to100,actualBrake,[actual],oilconsumption,groundClearance,minGroundClearance,warranty,[length],[width],[height],wheelbase,frontTrack,rearWheel,[weigh],cardoors,carseats,tankVolume,trunkVolume,engineModel,MaxPs,maxP,maxPRpm,maxTorque,maxRpm,gears,transmissionBoxMode,frontSuspension,backSuspension,helpStyle,carStructure,frontTireSize,backTireSize,spareTireSize,appearanceColor,appearanceColorCode,innerColor,innerColorCode,packingBoxSize,underPic from CarConfig ");
            strSql.Append(" where carSeries=@carSeries ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@carSeries", OleDbType.VarChar)			};
            parameters[0].Value = carSeries;

            TJMonitor.Model.CarConfig model = new TJMonitor.Model.CarConfig();
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
        public TJMonitor.Model.CarConfig DataRowToModel(DataRow row)
        {
            TJMonitor.Model.CarConfig model = new TJMonitor.Model.CarConfig();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["firstLetter"] != null)
                {
                    model.firstLetter = row["firstLetter"].ToString();
                }
                if (row["brand"] != null)
                {
                    model.brand = row["brand"].ToString();
                }
                if (row["carSeries"] != null)
                {
                    model.carSeries = row["carSeries"].ToString();
                }
                if (row["saleStatus"] != null)
                {
                    model.saleStatus = row["saleStatus"].ToString();
                }
                if (row["seriesName"] != null)
                {
                    model.seriesName = row["seriesName"].ToString();
                }
                if (row["modelYear"] != null)
                {
                    model.modelYear = row["modelYear"].ToString();
                }
                if (row["price"] != null)
                {
                    model.price = row["price"].ToString();
                }
                if (row["exhaust"] != null)
                {
                    model.exhaust = row["exhaust"].ToString();
                }
                if (row["manufacturer"] != null)
                {
                    model.manufacturer = row["manufacturer"].ToString();
                }
                if (row["leval"] != null)
                {
                    model.leval = row["leval"].ToString();
                }
                if (row["engine"] != null)
                {
                    model.engine = row["engine"].ToString();
                }
                if (row["transmissionBox"] != null)
                {
                    model.transmissionBox = row["transmissionBox"].ToString();
                }
                if (row["size"] != null)
                {
                    model.size = row["size"].ToString();
                }
                if (row["structure"] != null)
                {
                    model.structure = row["structure"].ToString();
                }
                if (row["maxSpeed"] != null)
                {
                    model.maxSpeed = row["maxSpeed"].ToString();
                }
                if (row["official0to100"] != null)
                {
                    model.official0to100 = row["official0to100"].ToString();
                }
                if (row["actual0to100"] != null)
                {
                    model.actual0to100 = row["actual0to100"].ToString();
                }
                if (row["actualBrake"] != null)
                {
                    model.actualBrake = row["actualBrake"].ToString();
                }
                if (row["actual"] != null)
                {
                    model.actual = row["actual"].ToString();
                }
                if (row["oilconsumption"] != null)
                {
                    model.oilconsumption = row["oilconsumption"].ToString();
                }
                if (row["groundClearance"] != null)
                {
                    model.groundClearance = row["groundClearance"].ToString();
                }
                if (row["minGroundClearance"] != null)
                {
                    model.minGroundClearance = row["minGroundClearance"].ToString();
                }
                if (row["warranty"] != null)
                {
                    model.warranty = row["warranty"].ToString();
                }
                if (row["length"] != null)
                {
                    model.length = row["length"].ToString();
                }
                if (row["width"] != null)
                {
                    model.width = row["width"].ToString();
                }
                if (row["height"] != null)
                {
                    model.height = row["height"].ToString();
                }
                if (row["wheelbase"] != null)
                {
                    model.wheelbase = row["wheelbase"].ToString();
                }
                if (row["frontTrack"] != null)
                {
                    model.frontTrack = row["frontTrack"].ToString();
                }
                if (row["rearWheel"] != null)
                {
                    model.rearWheel = row["rearWheel"].ToString();
                }
                if (row["weigh"] != null)
                {
                    model.weigh = row["weigh"].ToString();
                }
                if (row["cardoors"] != null)
                {
                    model.cardoors = row["cardoors"].ToString();
                }
                if (row["carseats"] != null)
                {
                    model.carseats = row["carseats"].ToString();
                }
                if (row["tankVolume"] != null)
                {
                    model.tankVolume = row["tankVolume"].ToString();
                }
                if (row["trunkVolume"] != null)
                {
                    model.trunkVolume = row["trunkVolume"].ToString();
                }
                if (row["engineModel"] != null)
                {
                    model.engineModel = row["engineModel"].ToString();
                }
                if (row["MaxPs"] != null)
                {
                    model.MaxPs = row["MaxPs"].ToString();
                }
                if (row["maxP"] != null)
                {
                    model.maxP = row["maxP"].ToString();
                }
                if (row["maxPRpm"] != null)
                {
                    model.maxPRpm = row["maxPRpm"].ToString();
                }
                if (row["maxTorque"] != null)
                {
                    model.maxTorque = row["maxTorque"].ToString();
                }
                if (row["maxRpm"] != null)
                {
                    model.maxRpm = row["maxRpm"].ToString();
                }
                if (row["gears"] != null)
                {
                    model.gears = row["gears"].ToString();
                }
                if (row["transmissionBoxMode"] != null)
                {
                    model.transmissionBoxMode = row["transmissionBoxMode"].ToString();
                }
                if (row["frontSuspension"] != null)
                {
                    model.frontSuspension = row["frontSuspension"].ToString();
                }
                if (row["backSuspension"] != null)
                {
                    model.backSuspension = row["backSuspension"].ToString();
                }
                if (row["helpStyle"] != null)
                {
                    model.helpStyle = row["helpStyle"].ToString();
                }
                if (row["carStructure"] != null)
                {
                    model.carStructure = row["carStructure"].ToString();
                }
                if (row["frontTireSize"] != null)
                {
                    model.frontTireSize = row["frontTireSize"].ToString();
                }
                if (row["backTireSize"] != null)
                {
                    model.backTireSize = row["backTireSize"].ToString();
                }
                if (row["spareTireSize"] != null)
                {
                    model.spareTireSize = row["spareTireSize"].ToString();
                }
                if (row["appearanceColor"] != null)
                {
                    model.appearanceColor = row["appearanceColor"].ToString();
                }
                if (row["appearanceColorCode"] != null)
                {
                    model.appearanceColorCode = row["appearanceColorCode"].ToString();
                }
                if (row["innerColor"] != null)
                {
                    model.innerColor = row["innerColor"].ToString();
                }
                if (row["innerColorCode"] != null)
                {
                    model.innerColorCode = row["innerColorCode"].ToString();
                }
                if (row["packingBoxSize"] != null)
                {
                    model.packingBoxSize = row["packingBoxSize"].ToString();
                }
                if (row["underPic"] != null)
                {
                    model.underPic = row["underPic"].ToString();
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
            strSql.Append("select [id],firstLetter,brand,carSeries,saleStatus,seriesName,modelYear,[price],exhaust,manufacturer,[leval],engine,transmissionBox,[size],[structure],maxSpeed,official0to100,actual0to100,actualBrake,actual,oilconsumption,groundClearance,minGroundClearance,warranty,[length],[width],[height],wheelbase,frontTrack,rearWheel,[weigh],cardoors,carseats,tankVolume,trunkVolume,engineModel,MaxPs,maxP,maxPRpm,maxTorque,maxRpm,gears,transmissionBoxMode,frontSuspension,backSuspension,helpStyle,carStructure,frontTireSize,backTireSize,spareTireSize,appearanceColor,appearanceColorCode,innerColor,innerColorCode,packingBoxSize,underPic ");
            strSql.Append(" FROM CarConfig ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        public DataSet GetDistinctList(string field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Distinct ");
            strSql.Append(field); 
            strSql.Append(" FROM CarConfig "); 
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM CarConfig ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from CarConfig T ");
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
            parameters[0].Value = "CarConfig";
            parameters[1].Value = "id";
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

