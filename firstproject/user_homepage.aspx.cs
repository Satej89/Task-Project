using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace firstproject
{
    public partial class user_homepage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["status"] != null && Session["email"] != null && Session["phone"] != null)
            {
                // your existing code
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
                                cell1.Text = dr.GetValue(0).ToString();
                                cell2.Text = dr.GetValue(1).ToString();
                                cell3.Text = dr.GetValue(2).ToString();
                                cell4.Text = dr.GetValue(3).ToString();
                                cell5.Text = dr.GetValue(4).ToString();
                                cell6.Text = dr.GetValue(7).ToString();
                                hello_user.InnerHtml = "Hello " + dr.GetString(0);
                                Session["file"] = dr.GetValue(8).ToString();
                            }
                        }
                        
                        if (!IsPostBack)
                        {
                            // Assuming Session["file"] contains the path to the image
                            string imagePath = Session["file"] as string;

                            if (!string.IsNullOrEmpty(imagePath))
                            {
                                imgview.ImageUrl = imagePath;
                            }
                            else
                            {
                                // Set a default image path or handle the case where the Session["file"] is not set
                                imgview.ImageUrl = "user_images/user.png";
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
                    Response.Redirect("homepage.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Not logged in');</script>");
                //Response.Redirect("homepage.aspx");
            }




        }
    }
}