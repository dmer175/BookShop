using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace BookShop.Web
{   
    public partial class Default : System.Web.UI.Page
    {
        public List<Model.BookType> List { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.BookType bookTypeService = new BLL.BookType();
            DataSet ds = bookTypeService.GetAllList();
            List<Model.BookType> list = null;
            if (ds.Tables[0].Rows.Count>0)
            {
                list = new List<Model.BookType>();
                Model.BookType bookTypeModel = null;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    bookTypeModel = new Model.BookType();
                    LoadEnitity(row, bookTypeModel);
                    list.Add(bookTypeModel);
                }
            }
            List = list;
        }

        public void LoadEnitity(DataRow row, Model.BookType bookType)
        {
            bookType.TypeId = row[0].ToString();
            bookType.TypeTitle = row[1].ToString();
            bookType.TypeParentId = row[2].ToString();
        }
    }
}
