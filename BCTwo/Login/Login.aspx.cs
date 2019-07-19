using BCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCTwo.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            CRent rent = new CRent();

            if ((rent.Employee.Where( ce => ce.UserName == txtUser.Text && ce.Password == txtPass.Text).FirstOrDefault()) != null )
            {
                Session["UserName"] = txtUser.Text;
                Response.Redirect("~/Home/Index");
            }
            else
            {
                Label1.Text = "帳號或者密碼有誤!";
            }
        }
    }
}