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
namespace MGM.Model
{
	/// <summary>
	/// OrderInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderInfo
	{
		public OrderInfo()
		{}
		#region Model
		private int _id;
		private string _nameinfo;
		private string _phone;
		private string _cardnum;
		private string _licensenum;
		private string _refereename;
		private string _refereephone;
		private int _stateinfo=0;
		private int? _remark1;
		private int? _remark2;
		private string _remark3;
		private string _remark4;
		private DateTime _addtime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NameInfo
		{
			set{ _nameinfo=value;}
			get{return _nameinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardNum
		{
			set{ _cardnum=value;}
			get{return _cardnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LicenseNum
		{
			set{ _licensenum=value;}
			get{return _licensenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RefereeName
		{
			set{ _refereename=value;}
			get{return _refereename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RefereePhone
		{
			set{ _refereephone=value;}
			get{return _refereephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StateInfo
		{
			set{ _stateinfo=value;}
			get{return _stateinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Remark1
		{
			set{ _remark1=value;}
			get{return _remark1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Remark2
		{
			set{ _remark2=value;}
			get{return _remark2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark3
		{
			set{ _remark3=value;}
			get{return _remark3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark4
		{
			set{ _remark4=value;}
			get{return _remark4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

