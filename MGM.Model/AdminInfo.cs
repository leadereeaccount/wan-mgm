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
namespace MGM.Model
{
	/// <summary>
	/// AdminInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AdminInfo
	{
		public AdminInfo()
		{}
		#region Model
		private int _id;
		private string _num;
		private string _account;
		private string _pwd;
		private string _nameinfo;
		private string _nickname;
		private string _phonenum;
		private string _telnum;
		private string _emailnum;
		private string _addressinfo;
		private int _sortnum=0;
		private int _stateinfo=1;
		private DateTime? _endlogintime;
		private DateTime? _nowlogintime;
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
		public string Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Account
		{
			set{ _account=value;}
			get{return _account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
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
		public string Nickname
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PhoneNum
		{
			set{ _phonenum=value;}
			get{return _phonenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TelNum
		{
			set{ _telnum=value;}
			get{return _telnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmailNum
		{
			set{ _emailnum=value;}
			get{return _emailnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddressInfo
		{
			set{ _addressinfo=value;}
			get{return _addressinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SortNum
		{
			set{ _sortnum=value;}
			get{return _sortnum;}
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
		public DateTime? EndLoginTime
		{
			set{ _endlogintime=value;}
			get{return _endlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NowLoginTime
		{
			set{ _nowlogintime=value;}
			get{return _nowlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

