using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRegisterLogin.lib;
using WebRegisterLogin.Models;

namespace WebRegisterLogin
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"];
            UserModel user = UserDAL.GetUserByUsername(username);

            LabelID.Text = user.id.ToString();
            LabelUsername.Text = user.username.ToString();
            LabelRegisterDate.Text = user.register_date.ToString();
            LabelHash.Text = user.password.ToString();
        }
    }
}