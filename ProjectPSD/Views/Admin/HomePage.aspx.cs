using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        RaisoRepository repo = new RaisoRepository();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/LogInPage.aspx");
            }

            List<MsStationery> stationeries = (from repo in repo.GetStationeries() select repo).ToList();

            StationeryGridView.DataSource = stationeries;

            StationeryGridView.DataBind();
        }

        
    }
}