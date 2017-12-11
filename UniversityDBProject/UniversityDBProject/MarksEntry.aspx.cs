using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityDBProject
{
    public partial class MarksEntry : System.Web.UI.Page
    {
        SqlConnection con = new
SqlConnection(ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString);
        string UserName;
        string term;
        string Subject;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName = Session["UserName"].ToString();
            term = Session["Term"].ToString();
            Subject = Session["Subject"].ToString();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Select Credit from StudentSubject where UserName = '" + UserName + "'and Term = '" + term + "' and Subject='" + Subject + "'", con);
            string s = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd = new SqlCommand("Update StudentSubject set Marks = '" + TextBox1.Text +"'where UserName = '"+UserName+"'and Term= '"+term+"' and Subject = '"+Subject+"'", con);
            int i = cmd.ExecuteNonQuery();
            if (i >= 0)
                Response.Redirect("ProfessorPage.aspx");
        }

        
    }
}