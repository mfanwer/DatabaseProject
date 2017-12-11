using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityDBProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }
            

        protected void Button1_Click(object sender, EventArgs e)
        {
                try
                {

                    string username = TextBox1.Text;
                    string password = TextBox2.Text;
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT [Roll] FROM [dbo].[User] where UserName = '" + username + "' and Password='" + password + "'", con);
                    string i = cmd.ExecuteScalar().ToString();

                    if (i != null)
                    {
                        Session["name"] = username;
                        if (i.Equals("Admin"))
                            Response.Redirect("AdminPage.aspx");
                        else if (i.Equals("Professor"))
                            Response.Redirect("ProfessorPage.aspx");
                        else
                            Response.Redirect("StudentPage.aspx");
                    }
                    else
                    {
                        Label1.Text = "Wrong Credential";
                    }
                }
                catch (Exception ex)
                {

                    Label1.ForeColor = Color.Red;
                    Label1.Text = ex.Message;
                }
            }
        }
    }
