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
    public partial class StudentPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                try
                {
                    con.Open();
                    string Name = Session["name"].ToString();
                    Label1.Text = Name;
                    SqlCommand cmd = new SqlCommand("SELECT Name,UserName,Department,Address,DOB,term FROM StudentData1 where UserName= '" + Name + "'", con);
                    SqlCommand cmd1 = new SqlCommand("SELECT Subject,Marks,CourseId,Credit FROM StudentSubject where UserName= '" + Name + "'", con);
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    GridView2.DataSource = cmd1.ExecuteReader();
                    GridView2.DataBind();
                }
                catch (Exception ex)
                {

                    Label2.ForeColor = Color.Red;
                    Label2.Text = ex.Message;
                }
            }
            else
                Response.Redirect("Welcome.aspx");

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Welcome.aspx");
        }
    }
}