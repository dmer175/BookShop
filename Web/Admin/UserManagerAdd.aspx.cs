using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.Web.Admin
{
    public partial class UserManagerAdd : System.Web.UI.Page
    {
        public string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["uname"]))
            {
                BookShop.Model.UserManager umModel = new Model.UserManager()
                {
                    UserId = Convert.ToInt32( Request["uid"]),
                    UserName = Request["uname"],
                    UserPwd = Request["upwd"]
                };
                BookShop.BLL.UserManager umBll = new BLL.UserManager();
                if (umBll.Add(umModel))
                {
                    Response.Redirect("UserManagerList.aspx");
                }
                else
                {
                    Msg = "添加失败";
                }
            }
        }
    }
}