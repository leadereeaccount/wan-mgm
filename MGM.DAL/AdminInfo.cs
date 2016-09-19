/**  版本信息模板在安装目录下，可自行修改。
* AdminInfo.cs
*
* 功 能： N/A
* 类 名： AdminInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/9/13 11:02:10   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Microsoft.DBUtility;//Please add references
namespace MGM.DAL
{
	/// <summary>
	/// 数据访问类:AdminInfo
	/// </summary>
	public partial class AdminInfo
	{
		public AdminInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "tb_AdminInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_AdminInfo");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MGM.Model.AdminInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_AdminInfo(");
			strSql.Append("Num,Account,Pwd,NameInfo,Nickname,PhoneNum,TelNum,EmailNum,AddressInfo,SortNum,StateInfo,EndLoginTime,NowLoginTime,AddTime)");
			strSql.Append(" values (");
			strSql.Append("@Num,@Account,@Pwd,@NameInfo,@Nickname,@PhoneNum,@TelNum,@EmailNum,@AddressInfo,@SortNum,@StateInfo,@EndLoginTime,@NowLoginTime,@AddTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Account", SqlDbType.NVarChar,100),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,100),
					new SqlParameter("@NameInfo", SqlDbType.NVarChar,100),
					new SqlParameter("@Nickname", SqlDbType.NVarChar,100),
					new SqlParameter("@PhoneNum", SqlDbType.NVarChar,100),
					new SqlParameter("@TelNum", SqlDbType.NVarChar,100),
					new SqlParameter("@EmailNum", SqlDbType.NVarChar,100),
					new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@SortNum", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@EndLoginTime", SqlDbType.DateTime),
					new SqlParameter("@NowLoginTime", SqlDbType.DateTime),
					new SqlParameter("@AddTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Num;
			parameters[1].Value = model.Account;
			parameters[2].Value = model.Pwd;
			parameters[3].Value = model.NameInfo;
			parameters[4].Value = model.Nickname;
			parameters[5].Value = model.PhoneNum;
			parameters[6].Value = model.TelNum;
			parameters[7].Value = model.EmailNum;
			parameters[8].Value = model.AddressInfo;
			parameters[9].Value = model.SortNum;
			parameters[10].Value = model.StateInfo;
			parameters[11].Value = model.EndLoginTime;
			parameters[12].Value = model.NowLoginTime;
			parameters[13].Value = model.AddTime;

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
		public bool Update(MGM.Model.AdminInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_AdminInfo set ");
			strSql.Append("Num=@Num,");
			strSql.Append("Account=@Account,");
			strSql.Append("Pwd=@Pwd,");
			strSql.Append("NameInfo=@NameInfo,");
			strSql.Append("Nickname=@Nickname,");
			strSql.Append("PhoneNum=@PhoneNum,");
			strSql.Append("TelNum=@TelNum,");
			strSql.Append("EmailNum=@EmailNum,");
			strSql.Append("AddressInfo=@AddressInfo,");
			strSql.Append("SortNum=@SortNum,");
			strSql.Append("StateInfo=@StateInfo,");
			strSql.Append("EndLoginTime=@EndLoginTime,");
			strSql.Append("NowLoginTime=@NowLoginTime,");
			strSql.Append("AddTime=@AddTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Account", SqlDbType.NVarChar,100),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,100),
					new SqlParameter("@NameInfo", SqlDbType.NVarChar,100),
					new SqlParameter("@Nickname", SqlDbType.NVarChar,100),
					new SqlParameter("@PhoneNum", SqlDbType.NVarChar,100),
					new SqlParameter("@TelNum", SqlDbType.NVarChar,100),
					new SqlParameter("@EmailNum", SqlDbType.NVarChar,100),
					new SqlParameter("@AddressInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@SortNum", SqlDbType.Int,4),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@EndLoginTime", SqlDbType.DateTime),
					new SqlParameter("@NowLoginTime", SqlDbType.DateTime),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Num;
			parameters[1].Value = model.Account;
			parameters[2].Value = model.Pwd;
			parameters[3].Value = model.NameInfo;
			parameters[4].Value = model.Nickname;
			parameters[5].Value = model.PhoneNum;
			parameters[6].Value = model.TelNum;
			parameters[7].Value = model.EmailNum;
			parameters[8].Value = model.AddressInfo;
			parameters[9].Value = model.SortNum;
			parameters[10].Value = model.StateInfo;
			parameters[11].Value = model.EndLoginTime;
			parameters[12].Value = model.NowLoginTime;
			parameters[13].Value = model.AddTime;
			parameters[14].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_AdminInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_AdminInfo ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public MGM.Model.AdminInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Num,Account,Pwd,NameInfo,Nickname,PhoneNum,TelNum,EmailNum,AddressInfo,SortNum,StateInfo,EndLoginTime,NowLoginTime,AddTime from tb_AdminInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			MGM.Model.AdminInfo model=new MGM.Model.AdminInfo();
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
		public MGM.Model.AdminInfo DataRowToModel(DataRow row)
		{
			MGM.Model.AdminInfo model=new MGM.Model.AdminInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Num"]!=null)
				{
					model.Num=row["Num"].ToString();
				}
				if(row["Account"]!=null)
				{
					model.Account=row["Account"].ToString();
				}
				if(row["Pwd"]!=null)
				{
					model.Pwd=row["Pwd"].ToString();
				}
				if(row["NameInfo"]!=null)
				{
					model.NameInfo=row["NameInfo"].ToString();
				}
				if(row["Nickname"]!=null)
				{
					model.Nickname=row["Nickname"].ToString();
				}
				if(row["PhoneNum"]!=null)
				{
					model.PhoneNum=row["PhoneNum"].ToString();
				}
				if(row["TelNum"]!=null)
				{
					model.TelNum=row["TelNum"].ToString();
				}
				if(row["EmailNum"]!=null)
				{
					model.EmailNum=row["EmailNum"].ToString();
				}
				if(row["AddressInfo"]!=null)
				{
					model.AddressInfo=row["AddressInfo"].ToString();
				}
				if(row["SortNum"]!=null && row["SortNum"].ToString()!="")
				{
					model.SortNum=int.Parse(row["SortNum"].ToString());
				}
				if(row["StateInfo"]!=null && row["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(row["StateInfo"].ToString());
				}
				if(row["EndLoginTime"]!=null && row["EndLoginTime"].ToString()!="")
				{
					model.EndLoginTime=DateTime.Parse(row["EndLoginTime"].ToString());
				}
				if(row["NowLoginTime"]!=null && row["NowLoginTime"].ToString()!="")
				{
					model.NowLoginTime=DateTime.Parse(row["NowLoginTime"].ToString());
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
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
			strSql.Append("select Id,Num,Account,Pwd,NameInfo,Nickname,PhoneNum,TelNum,EmailNum,AddressInfo,SortNum,StateInfo,EndLoginTime,NowLoginTime,AddTime ");
			strSql.Append(" FROM tb_AdminInfo ");
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
			strSql.Append(" Id,Num,Account,Pwd,NameInfo,Nickname,PhoneNum,TelNum,EmailNum,AddressInfo,SortNum,StateInfo,EndLoginTime,NowLoginTime,AddTime ");
			strSql.Append(" FROM tb_AdminInfo ");
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
			strSql.Append("select count(1) FROM tb_AdminInfo ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_AdminInfo T ");
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
			parameters[0].Value = "tb_AdminInfo";
			parameters[1].Value = "Id";
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

