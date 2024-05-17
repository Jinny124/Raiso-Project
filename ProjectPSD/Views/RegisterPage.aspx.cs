using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        RAisoEntities1 db = new RAisoEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LogInPage.aspx");
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            int UserID;
            string UserName = nameLabel.Text;
            string UserGender = RadioButtonList1.Text;
            string UserDOB = dobLabel.Text;
            string UserPhone = phoneLabel.Text;
            string UserAddress = addressLabel.Text;
            string password = passBox.Text;
            string validationMessage;

            if (IsValidPassword(password, out validationMessage))
            {
                ValidationLabel.Text = "Password is valid.";
                ValidationLabel.ForeColor = System.Drawing.Color.Green;

                // Proceed with the registration logic
                // For example: Save user details to the database
                

                // Redirect to the login page after successful registration

                Response.Redirect("~/Views/LogInPage.aspx");
            }
            else
            {
                ValidationLabel.Text = validationMessage;
                ValidationLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool IsValidPassword(string password, out string message)
        {
            message = string.Empty;

            if (string.IsNullOrWhiteSpace(password))
            {
                message = "Password cannot be empty.";
                return false;
            }

            if (password.Length < 8)
            {
                message = "Password must be at least 8 characters long.";
                return false;
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                message = "Password must contain at least one uppercase letter.";
                return false;
            }

            if (!Regex.IsMatch(password, "[a-z]"))
            {
                message = "Password must contain at least one lowercase letter.";
                return false;
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                message = "Password must contain at least one digit.";
                return false;
            }

            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                message = "Password must contain at least one special character.";
                return false;
            }

            return true;
        }


    }

}
    
