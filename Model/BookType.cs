using System;
namespace BookShop.Model
{
	/// <summary>
	/// BookType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BookType
	{
		public BookType()
		{}
		#region Model
		private string _typeid;
		private string _typetitle;
		private string _typeparentid;
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
		public string TypeTitle
		{
			set{ _typetitle=value;}
			get{return _typetitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeParentId
		{
			set{ _typeparentid=value;}
			get{return _typeparentid;}
		}
		#endregion Model

	}
}

