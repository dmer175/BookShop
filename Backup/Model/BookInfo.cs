﻿using System;
namespace BookShop.Model
{
	/// <summary>
	/// BookInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BookInfo
	{
		public BookInfo()
		{}
		#region Model
		private string _bid;
		private string _title;
		private string _titlehot;
		private decimal? _priceold;
		private decimal? _pricenew;
		private string _author;
		private string _publisher;
		private DateTime? _publishdate;
		private DateTime? _onsaledate;
		private string _isbn;
		private string _typeid;
		private string _detalis;
		private string _imgtitle;
		/// <summary>
		/// 
		/// </summary>
		public string Bid
		{
			set{ _bid=value;}
			get{return _bid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Titlehot
		{
			set{ _titlehot=value;}
			get{return _titlehot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PriceOld
		{
			set{ _priceold=value;}
			get{return _priceold;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PriceNew
		{
			set{ _pricenew=value;}
			get{return _pricenew;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Publisher
		{
			set{ _publisher=value;}
			get{return _publisher;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PublishDate
		{
			set{ _publishdate=value;}
			get{return _publishdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OnSaleDate
		{
			set{ _onsaledate=value;}
			get{return _onsaledate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISBN
		{
			set{ _isbn=value;}
			get{return _isbn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Detalis
		{
			set{ _detalis=value;}
			get{return _detalis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgTitle
		{
			set{ _imgtitle=value;}
			get{return _imgtitle;}
		}
		#endregion Model

	}
}

