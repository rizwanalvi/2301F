using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using LoginWeb.Model;
namespace LoginWeb
{
    public partial class index : System.Web.UI.Page
    {
        LoginDAO _logiDAO = new LoginDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //String UserName = "admin@gmail.com";
            //String Password = "123456789";
            int _isUser = _logiDAO.LoginUser(new Loginc { UserName = TextBox1.Text, Password = TextBox2.Text });
            if (_isUser>0)
            {
                FormsAuthentication.SetAuthCookie("useNAme", true);

                Response.Redirect("~/dashboard.aspx");
            }
            else {

                Label3.Text = "Please Enter Correct User/Password";
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            _logiDAO.RegisterUser(new Loginc {UserName = TextBox1.Text,Password = TextBox2.Text });
        }
    }
}