using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRegisterLogin.lib;

namespace WebRegisterLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            bool loginSuccess = UserLib.Login(TextBoxUsername.Text, TextBoxPassword.Text);
            if (loginSuccess)
            {
                Response.Redirect($"/User.aspx?username={TextBoxUsername.Text}");
            }
            else
            {
                modal.Attributes.Add("class", "is-active");
            }
        }

        protected void ButtonModalClose_Click(object sender, EventArgs e)
        {
            modal.Attributes.Remove("class");
            modal.Attributes.Add("class", "modal");
        }
    }
}