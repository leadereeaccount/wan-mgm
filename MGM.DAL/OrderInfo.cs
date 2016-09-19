/**  版本信息模板在安装目录下，可自行修改。
* OrderInfo.cs
*
* 功 能： N/A
* 类 名： OrderInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/9/13 11:02:11   N/A    初版
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
	/// 数据访问类:OrderInfo
	/// </summary>
	public partial class OrderInfo
	{
		public OrderInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "tb_OrderInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_OrderInfo");
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
		public int Add(MGM.Model.OrderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_OrderInfo(");
			strSql.Append("NameInfo,Phone,CardNum,LicenseNum,RefereeName,RefereePhone,StateInfo,Remark1,Remark2,Remark3,Remark4,Addtime)");
			strSql.Append(" values (");
			strSql.Append("@NameInfo,@Phone,@CardNum,@LicenseNum,@RefereeName,@RefereePhone,@StateInfo,@Remark1,@Remark2,@Remark3,@Remark4,@Addtime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NameInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@Phone", SqlDbType.NVarChar,100),
					new SqlParameter("@CardNum", SqlDbType.NVarChar,100),
					new SqlParameter("@LicenseNum", SqlDbType.NVarChar,200),
					new SqlParameter("@RefereeName", SqlDbType.NVarChar,200),
					new SqlParameter("@RefereePhone", SqlDbType.NVarChar,100),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@Remark1", SqlDbType.Int,4),
					new SqlParameter("@Remark2", SqlDbType.Int,4),
					new SqlParameter("@Remark3", SqlDbType.NVarChar,-1),
					new SqlParameter("@Remark4", SqlDbType.NVarChar,-1),
					new SqlParameter("@Addtime", SqlDbType.DateTime)};
			parameters[0].Value = model.NameInfo;
			parameters[1].Value = model.Phone;
			parameters[2].Value = model.CardNum;
			parameters[3].Value = model.LicenseNum;
			parameters[4].Value = model.RefereeName;
			parameters[5].Value = model.RefereePhone;
			parameters[6].Value = model.StateInfo;
			parameters[7].Value = model.Remark1;
			parameters[8].Value = model.Remark2;
			parameters[9].Value = model.Remark3;
			parameters[10].Value = model.Remark4;
			parameters[11].Value = model.Addtime;

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
		public bool Update(MGM.Model.OrderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_OrderInfo set ");
			strSql.Append("NameInfo=@NameInfo,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("CardNum=@CardNum,");
			strSql.Append("LicenseNum=@LicenseNum,");
			strSql.Append("RefereeName=@RefereeName,");
			strSql.Append("RefereePhone=@RefereePhone,");
			strSql.Append("StateInfo=@StateInfo,");
			strSql.Append("Remark1=@Remark1,");
			strSql.Append("Remark2=@Remark2,");
			strSql.Append("Remark3=@Remark3,");
			strSql.Append("Remark4=@Remark4,");
			strSql.Append("Addtime=@Addtime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@NameInfo", SqlDbType.NVarChar,200),
					new SqlParameter("@Phone", SqlDbType.NVarChar,100),
					new SqlParameter("@CardNum", SqlDbType.NVarChar,100),
					new SqlParameter("@LicenseNum", SqlDbType.NVarChar,200),
					new SqlParameter("@RefereeName", SqlDbType.NVarChar,200),
					new SqlParameter("@RefereePhone", SqlDbType.NVarChar,100),
					new SqlParameter("@StateInfo", SqlDbType.Int,4),
					new SqlParameter("@Remark1", SqlDbType.Int,4),
					new SqlParameter("@Remark2", SqlDbType.Int,4),
					new SqlParameter("@Remark3", SqlDbType.NVarChar,-1),
					new SqlParameter("@Remark4", SqlDbType.NVarChar,-1),
					new SqlParameter("@Addtime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.NameInfo;
			parameters[1].Value = model.Phone;
			parameters[2].Value = model.CardNum;
			parameters[3].Value = model.LicenseNum;
			parameters[4].Value = model.RefereeName;
			parameters[5].Value = model.RefereePhone;
			parameters[6].Value = model.StateInfo;
			parameters[7].Value = model.Remark1;
			parameters[8].Value = model.Remark2;
			parameters[9].Value = model.Remark3;
			parameters[10].Value = model.Remark4;
			parameters[11].Value = model.Addtime;
			parameters[12].Value = model.Id;

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
			strSql.Append("delete from tb_OrderInfo ");
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
			strSql.Append("delete from tb_OrderInfo ");
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
		public MGM.Model.OrderInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,NameInfo,Phone,CardNum,LicenseNum,RefereeName,RefereePhone,StateInfo,Remark1,Remark2,Remark3,Remark4,Addtime from tb_OrderInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			MGM.Model.OrderInfo model=new MGM.Model.OrderInfo();
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
		public MGM.Model.OrderInfo DataRowToModel(DataRow row)
		{
			MGM.Model.OrderInfo model=new MGM.Model.OrderInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["NameInfo"]!=null)
				{
					model.NameInfo=row["NameInfo"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["CardNum"]!=null)
				{
					model.CardNum=row["CardNum"].ToString();
				}
				if(row["LicenseNum"]!=null)
				{
					model.LicenseNum=row["LicenseNum"].ToString();
				}
				if(row["RefereeName"]!=null)
				{
					model.RefereeName=row["RefereeName"].ToString();
				}
				if(row["RefereePhone"]!=null)
				{
					model.RefereePhone=row["RefereePhone"].ToString();
				}
				if(row["StateInfo"]!=null && row["StateInfo"].ToString()!="")
				{
					model.StateInfo=int.Parse(row["StateInfo"].ToString());
				}
				if(row["Remark1"]!=null && row["Remark1"].ToString()!="")
				{
					model.Remark1=int.Parse(row["Remark1"].ToString());
				}
				if(row["Remark2"]!=null && row["Remark2"].ToString()!="")
				{
					model.Remark2=int.Parse(row["Remark2"].ToString());
				}
				if(row["Remark3"]!=null)
				{
					model.Remark3=row["Remark3"].ToString();
				}
				if(row["Remark4"]!=null)
				{
					model.Remark4=row["Remark4"].ToString();
				}
				if(row["Addtime"]!=null && row["Addtime"].ToString()!="")
				{
					model.Addtime=DateTime.Parse(row["Addtime"].ToString());
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
			strSql.Append("select Id,NameInfo,Phone,CardNum,LicenseNum,RefereeName,RefereePhone,StateInfo,Remark1,Remark2,Remark3,Remark4,Addtime ");
			strSql.Append(" FROM tb_OrderInfo ");
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
			strSql.Append(" Id,NameInfo,Phone,CardNum,LicenseNum,RefereeName,RefereePhone,StateInfo,Remark1,Remark2,Remark3,Remark4,Addtime ");
			strSql.Append(" FROM tb_OrderInfo ");
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
			strSql.Append("select count(1) FROM tb_OrderInfo ");
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
			strSql.Append(")AS Row, T.*  from tb_OrderInfo T ");
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
			parameters[0].Value = "tb_OrderInfo";
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

