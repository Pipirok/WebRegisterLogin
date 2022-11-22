using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRegisterLogin.lib;

namespace WebRegisterLogin
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxPassword.Attributes["type"] = "password";
            TextBoxPasswordRepeat.Attributes["type"] = "password";
        }

        protected bool IsUsernameCorrect = false;
        protected bool IsPasswordCorrect = false;
        protected bool DoPasswordsMatch = false;

        protected bool IsSubmitEnabled = false;

        protected void CalculateButtonIsEnabled()
        {
            if (IsUsernameCorrect && IsPasswordCorrect && DoPasswordsMatch)
            {
                IsSubmitEnabled = true;
                return;
            }
            IsSubmitEnabled= false;
        }

        protected void CalculateDoPasswordsMatch()
        {
            if (TextBoxPassword.Text == TextBoxPasswordRepeat.Text)
            {
                DoPasswordsMatch = true;
                LabelPasswordRepeatFlavourText.Text = "";
                LabelPasswordRepeatFlavourText.CssClass = "";
            }
            else
            {
                DoPasswordsMatch = false;
                LabelPasswordRepeatFlavourText.Text = "Passwords do not match!";
                LabelPasswordRepeatFlavourText.CssClass = "help is-danger";
            }
            CalculateButtonIsEnabled();
        }

        protected void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            if(UserLib.DoesUserExist(username))
            {
                LabelUsernameFlavourText.Text = "Username already taken!";
                LabelUsernameFlavourText.CssClass = "is-danger help";
                IsUsernameCorrect = false;
            }
            else if (Regex.IsMatch(username, @"[^A-Za-z0-9_-]") || username.Length > 20 || username.Length < 4)
            {
                LabelUsernameFlavourText.Text = "Username must be 4-20 alphanumeric letters, '_' or '-'";
                LabelUsernameFlavourText.CssClass = "is-danger help";
                IsUsernameCorrect = false;
            }
            else
            {
                LabelUsernameFlavourText.Text = "";
                LabelUsernameFlavourText.CssClass = "";
                IsUsernameCorrect = true;
            }
            CalculateButtonIsEnabled();
        }

        protected void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = TextBoxPassword.Text;
            bool hasPasswordUppercase = Regex.IsMatch(password, @"[A-Z]");
            bool hasPasswordNumber = Regex.IsMatch(password, @"[0-9]");
            bool hasSpecialCharacter = Regex.IsMatch(password, @"[^0-9A-Za-z]");
            bool isPasswordLegalLength = password.Length > 6 && password.Length < 64;

            if (!hasPasswordNumber || !hasSpecialCharacter || !isPasswordLegalLength || !hasPasswordUppercase)
            {
                LabelPasswordFlavourText.Text = "Password must be 7-63 characters, and must contain at least 1 number, capital letter and a special symbol";
                LabelPasswordFlavourText.CssClass = "help is-danger";
                IsPasswordCorrect = false;
            }
            else
            {
                LabelPasswordFlavourText.Text = "";
                LabelPasswordFlavourText.CssClass = "";
                IsPasswordCorrect = true;
            }

            CalculateDoPasswordsMatch();
        }

        protected void TextBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            CalculateDoPasswordsMatch();
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            
            bool registerSuccess = UserLib.Register(TextBoxUsername.Text, TextBoxPassword.Text);
            if (registerSuccess)
            {
                Response.Redirect($"/User.aspx?username={TextBoxUsername.Text}");
            }
            else
            {
                modal.Attributes.Add("class", "is-active");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            modal.Attributes.Remove("class");
            modal.Attributes.Add("class", "modal");
        }
    }
}