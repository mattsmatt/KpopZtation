﻿using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("/Home");
            }
        }

        // NOTE: Submit hanya bisa kalau tekan tombol, jangan tekan ENTER
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string email = TxtEmail.Text;
            string gender = RBLGender.SelectedValue;
            string address = TxtAddress.Text;
            string password = TxtPassword.Text;
            bool isTerms = CBTerms.Checked;

            string error = CustomerController.RegisterCustomer(name, email, gender, address, password, isTerms);

            if (error.Equals(""))
            {
                Response.Redirect("/Login");
            }
            else
            {
                LblError.Text = error;
            }
        }
    }
}