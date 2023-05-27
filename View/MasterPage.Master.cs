﻿using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NavAdmin.Visible = false;
            NavCustomer.Visible = false;
            NavGuest.Visible = false;

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                NavGuest.Visible = true;
            }
            else
            {
                KpopZtationDBEntities db = new KpopZtationDBEntities();
                Customer cust;
                if (Session["user"] == null)
                {
                    var id = Int32.Parse(Request.Cookies["user_cookie"].Value);
                    cust = (from x in db.Customers where x.CustomerID == id select x).FirstOrDefault();
                    Session["user"] = cust;
                }
                else
                {
                    cust = (Customer)Session["user"];
                }

                // if role is admin
                if (cust.CustomerRole.Equals("ADM"))
                {
                    NavAdmin.Visible = true;
                }
                // if role is customer
                else
                {
                    NavCustomer.Visible = true;
                }
            }
        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login");
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Register");
        }

        protected void BtnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Cart");
        }

        protected void BtnTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("/TransactionHistory");
        }

        protected void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UpdateProfile");
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;

            foreach (string c in cookies)
            {
                Response.Cookies[c].Expires = DateTime.Now.AddDays(-2);
            }

            Application["online_user"] = ((int)Application["online_user"]) - 1;
            Session.Remove("user");
            Response.Redirect("/Login");
        }

        protected void BtnTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("/TransactionReport");
        }
    }
}