using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace firstproject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals("user"))
                    {
                        LinkButton1.Visible = false;
                        LinkButton2.Visible = false;
                        LinkButton3.Visible = true;
                        LinkButton4.Visible = true;

                        LinkButton6.Visible = true;
                        LinkButton10.Visible = false;
                        Link_userpage.Visible = true;
                        Link_homepage.Visible = false;
                        LinkButton41.Visible = false;
                         
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
                    else if ((Session["role"].Equals("admin")))
                    {
                        LinkButton1.Visible = false;
                        LinkButton2.Visible = false;
                        LinkButton3.Visible = true;
                        //LinkButton4.Visible = true;
                         

                        LinkButton6.Visible = false;
                        LinkButton10.Visible = true;
                        Link_userpage.Visible = false;
                        Link_homepage.Visible = true;
                        LinkButton41.Visible = true;
                       

                        if (!IsPostBack)
                        {
                            imgview.ImageUrl = "img/adminuser.png";
                        }

                    }
                }
                else
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = true;
                    LinkButton3.Visible = false;
                    LinkButton4.Visible = false;

                    LinkButton6.Visible = true;
                    LinkButton10.Visible = false;
                    Link_userpage.Visible = false;
                    Link_homepage.Visible = true;
                    LinkButton41.Visible = true;

                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("adminLogin.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserManagement.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrationPage.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("homepage.aspx");

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
        protected void Link_userpagebtn(object sender, EventArgs e)
        {
            Response.Redirect("user_homepage.aspx");

        }
        protected void Link_homepagebtn(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");

        }
    }
}



