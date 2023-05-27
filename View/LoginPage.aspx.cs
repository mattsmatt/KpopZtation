using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("/Home");
            }
        }

        // NOTE: Submit hanya bisa kalau tekan tombol, jangan tekan ENTER
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            String email = TxtEmail.Text;
            String password = TxtPassword.Text;
            bool isRemember = CBRemember.Checked;

            string error = CustomerController.LoginCustomer(email, password);

            if (error.Equals(""))
            {
                Customer cust = CustomerRepository.GetCustomerByEmailAndPassword(email, password);

                Session["user"] = cust;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = cust.CustomerID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(4);
                    Response.Cookies.Add(cookie);
                }

                if (Application["online_user"] == null)
                {
                    Application["online_user"] = 1;
                }
                else
                {
                    Application["online_user"] = ((int)Application["online_user"]) + 1;
                }

                Response.Redirect("/Home");
            }
            else
            {
                LblError.Text = error;
            }
        }
    }
}