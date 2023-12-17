using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstproject
{
    public partial class registrationPage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button19_Click(object sender, EventArgs e)
        {

            if (check_user_exist())
            {

                Response.Write("<script>alert('The user is exist with the Email ID Or Phone Number.');</script>");
            }
            else
            {
                //check_fuctionality();

                user_registration();

            }
        }

        bool check_user_exist()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from user_table2 where email='" + TextBox14.Text.Trim() + "' OR phone='" + TextBox15.Text.Trim() + "' ;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);



                if (dt.Rows.Count >= 1)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }

        }
        void check_fuctionality()
        {

        }

        void user_registration()
        {
            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                string filepath = "~/user_images/user.png";
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);


                if (filename.Length > 0)
                {
                    filepath = "~/user_images/" + filename;
                }
                Response.Write("<script>alert('" + filepath + "');</script>");
                SqlCommand cmd = new SqlCommand("INSERT INTO user_table2 (first_name,username,last_name,email,phone,password,confirm_pass,account_status,file_path) values(@first_name,@username,@last_name,@email,@phone,@password,@confirm_pass,@account_status,@file_path)", con);
                cmd.Parameters.AddWithValue("@first_name", TextBox12.Text.Trim());
                cmd.Parameters.AddWithValue("@username", TextBox16.Text.Trim());
                cmd.Parameters.AddWithValue("@last_name", TextBox13.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox14.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", TextBox15.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox17.Text.Trim());
                cmd.Parameters.AddWithValue("@confirm_pass", TextBox18.Text.Trim());
                cmd.Parameters.AddWithValue("@account_status", "active");
                cmd.Parameters.AddWithValue("@file_path", filepath);



                if (TextBox17.Text.Length > 0 && TextBox17.Text.Trim() == TextBox18.Text.Trim())
                {
                    cmd.ExecuteNonQuery();

                    if (FileUpload1.HasFile)
                    {
                        try
                        {
                            string filename1 = Path.GetFileName(FileUpload1.FileName);
                            string filepath1 = Server.MapPath("user_images/" + filename1);

                            // Save the file to the "user_image" folder
                            FileUpload1.SaveAs(filepath1);


                        }
                        catch (Exception ex)
                        {
                            // Log any exceptions to the console
                            string script = "console.error('" + ex.Message + "');";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ErrorMessage", script, true);
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('fiel not selected');</script>");
                        // Continue with file processing...
                    }

                    Session["role"] = "user";
                    Session["email"] = TextBox14.Text.Trim();
                    Session["phone"] = TextBox15.Text.Trim();
                    Session["status"] = "active";
                    Session["file"] = filepath.Trim();
                    Response.Write("<script>alert('Registration Successfull.Go to User Login');</script>");
                    Response.Redirect("user_homepage.aspx");
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