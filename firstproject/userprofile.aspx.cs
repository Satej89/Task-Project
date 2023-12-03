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
    public partial class userprofile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["role"].Equals("user"))
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * from user_table2 where email='" + Session["email"] + "'OR phone='" + Session["phone"] + "'; ", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            TextBox12.Attributes["value"] = dr.GetValue(1).ToString();
                            TextBox13.Attributes["value"] = dr.GetValue(2).ToString();
                            TextBox14.Attributes["value"] = dr.GetValue(3).ToString();
                            TextBox15.Attributes["value"] = dr.GetValue(4).ToString();
                            TextBox16.Attributes["value"] = dr.GetValue(0).ToString();
                            TextBox17.Attributes["value"] = dr.GetValue(5).ToString();
                            Link_status.Text = dr.GetValue(7).ToString();

                        }
                    }

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else if (Session["role"].Equals("admin"))
            {
                Response.Write("<script>alert('Hello Admin');</script>");
                Response.Redirect("homepage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Not Logged in to Your Account');</script>");
            }


        }
        protected void Button21_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE user_table2 SET first_name = '" + TextBox12.Text.Trim() + "'  ,last_name ='" + TextBox13.Text.Trim() + "'   , email='" + TextBox14.Text.Trim() + "'  ,username='" + TextBox16.Text.Trim() + "'  , phone='" + TextBox15.Text.Trim() + "'  ,password = '" + TextBox18.Text.Trim() + "' ,confirm_pass= '" + TextBox20.Text.Trim() + "' WHERE email= '" + TextBox14.Text.Trim() + "' ;", con);
                if (TextBox18.Text.Length == 0 && TextBox20.Text.Length == 0) 
                {
                    Response.Write("<script>alert('The data can only update if you enter new password or old password in new place');</script>");
                    TextBox18.Attributes["value"] = TextBox17.Attributes["value"];
                    TextBox20.Attributes["value"] = TextBox17.Attributes["value"];
                }
                else if (TextBox18.Text.Length != TextBox20.Text.Length)
                {
                    Response.Write("<script>alert('Please Enter  Passowrd in both places correctly');</script>");
                }
                else if (TextBox18.Text.Length > 0 && TextBox18.Text.Trim() == TextBox20.Text.Trim())
                {
                    cmd.ExecuteNonQuery();
                    Session["role"] = "user";
                    Session["email"] = TextBox14.Text.Trim();
                    Session["phone"] = TextBox15.Text.Trim();
                    Session["status"] = "active";
                    Response.Write("<script>alert('Updated Details Successfully.');</script>");
                    Response.Redirect("homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Please Enter a Valid Passowrd');</script>");
                }
                con.Close();


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}