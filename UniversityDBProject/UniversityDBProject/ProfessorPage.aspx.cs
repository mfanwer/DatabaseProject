using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityDBProject
{
    public partial class ProffesorPage : System.Web.UI.Page
    {
        SqlConnection con = new
SqlConnection(ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string Name = Session["name"].ToString();
                Label1.Text = "Welcome" + " " + Name;
                SqlDataAdapter adapter;
                SqlCommand cmd1 = null;
                DataSet ds = new DataSet();
                DataSet ds1 = new DataSet();
                SqlCommand cmd = new SqlCommand("SELECT Subject FROM ProfSubject where UserName = '" + Name + "'", con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmd1 = new SqlCommand("select StudentData1.ID as RollNumber, StudentData1.Name, StudentSubject.UserName, StudentSubject.Subject, StudentData1.term, StudentSubject.[CourseId], StudentSubject.[Credit], StudentSubject.Marks from StudentSubject INNER JOIN StudentData1 on StudentSubject.UserName = StudentData1.UserName where StudentSubject.subject = '" + dr[0] + "'", con);
                  
                    adapter = new SqlDataAdapter(cmd1);
                    adapter.Fill(ds1);
                    GridView1.DataSource = ds1;
                    GridView1.DataBind();
                }
            }
        }
        protected void GridView1_RowCommand(object sender,GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Enter Marks")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

            }
        }
        protected void myButton(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;



            Session["UserName"] = gvr.Cells[3].Text;
            Session["Subject"] = gvr.Cells[4].Text;
            Session["Term"] = gvr.Cells[5].Text;
            Response.Redirect("MarksEntry.aspx");
        }



    }
}