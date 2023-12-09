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
    public partial class userlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from user_table2 where email= '" + TextBox1.Text.Trim() + "'OR phone='" + TextBox1.Text.Trim() + "'AND password='" + TextBox2.Text.Trim() + "'; ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        if(dr.GetValue(7).ToString() !="deactive")
                        {
                            Response.Write("<script> alert('Login successful:= " + dr.GetValue(0).ToString() + "');</script>");
                            Session["email"] = dr.GetValue(3).ToString();
                            Session["name"] = dr.GetValue(0).ToString();
                            Session["phone"] = dr.GetValue(4).ToString();
                            Session["password"] = dr.GetValue(5).ToString();
                            Session["role"] = "user";
                            Session["status"] = dr.GetValue(7).ToString();
                            Response.Redirect("user_homepage.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('The user status is deactive.Contact the Admin');</script>");

                        }

                    }
                    
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials .');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}