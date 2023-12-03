using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstproject
{
    public partial class UserManagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void LinkButton123_Click(object sender, EventArgs e)
        {

            get_user();

        }
        //green or active button
        protected void LinkButton41_Click(object sender, EventArgs e)
        {
            Status_to_change("active");
            get_user();
            Response.Write("<script>alert('in pending  function');</script>");
        }
        //yellow or pending button
        protected void LinkButton42_Click(object sender, EventArgs e)
        {
            Status_to_change("pending");           
            get_user();
            Response.Write("<script>alert('in pending  function');</script>");
        }
        //red or deactivate button
        protected void LinkButton43_Click(object sender, EventArgs e)
        {
            Status_to_change("deactive");
            get_user();
            Response.Write("<script>alert('in deactive  function');</script>");

        }
        //delete button
        protected void Button2_Click(object sender, EventArgs e)
        {

        }
        void get_user()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT * from user_table2 where email='" + TextBox1.Text + "'OR phone='" + TextBox1.Text + "'; ", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        TextBox14.Attributes["value"] = dr.GetValue(3).ToString();
                        TextBox12.Attributes["value"] = dr.GetValue(1).ToString();
                        TextBox13.Attributes["value"] = dr.GetValue(2).ToString();
                        TextBox15.Attributes["value"] = dr.GetValue(4).ToString();
                        TextBox2.Attributes["value"] = dr.GetValue(7).ToString();
                        Session["email"] = dr.GetValue(3);
                        Session["phone"] = dr.GetValue(4);
                    }
                }
                else
                {
                    Response.Write("<script>alert('There is no such element that have you entered email id');</script>");
                }
                 
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void Status_to_change(string stat)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT * from user_table2 where email='" + TextBox1.Text + "'OR phone='" + TextBox1.Text + "'; ", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    
                    while (dr.Read())
                    {
                        
                        SqlCommand cmd2 = new SqlCommand("UPDATE user_table2 SET account_status='" + stat + "'where email='" + TextBox1.Text + "'OR phone='" + TextBox1.Text + "'; ", con);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                         
                        //Response.Write("<script>alert('status changed');</script>");
                        //TextBox2.Attributes["value"] = "testing";
                        //TextBox2.Attributes["value"] = stat;
                        Response.Write("<script>alert('The status has been changed to ");
                        //Response.Redirect(Request.RawUrl);
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}