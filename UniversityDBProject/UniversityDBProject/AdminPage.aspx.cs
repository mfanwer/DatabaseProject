using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityDBProject
{
    public partial class AdminPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString);
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Session["name"].ToString();
            Label1.Text = Name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID as RollNumber,Name,Department from StudentData1", con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            ds.Clear();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,Name,Department FROM ProfData", con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            ds.Clear();
        }
    }
}