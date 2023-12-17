using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstproject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["role"] != null  )
            {
                // your existing code
                if (Session["role"].Equals("user"))
                {
                    main_content.InnerHtml = "Welcome User to Homepage";
                }
                else if (Session["role"].Equals("admin"))
                {
                    main_content.InnerHtml = "Welcome Admin. Acess the Admin functions from Footer of the Website...";
                }
                else
                {
                    main_content.InnerHtml = "The role is not defined";
                }
            }
            

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}