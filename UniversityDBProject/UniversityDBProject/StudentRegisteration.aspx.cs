using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityDBProject
{
    public partial class StudentRegisteration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString);
        List<String> credit = new List<String>();
        List<String> CourseId = new List<String>();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    //Calendar1.Visible = false;

                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT [DepartmentName] FROM [dbo].[Department]", con);
                    DropDownList1.Items.Add("Select");
                    DropDownList1.DataSource = cmd.ExecuteReader();
                    DropDownList1.DataTextField = "DepartmentName";
                    DropDownList1.DataBind();
                }
            }
            catch (Exception ex)
            {

                Label1.ForeColor = Color.Red;
                Label1.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into StudentData1 (UserName,Name,Department,Address,DOB,term) values('" + TextBox3.Text + "','" + TextBox1.Text + "','" + DropDownList1.SelectedItem + "','" + TextArea1.InnerText + "','" + TextBox2.Text + "','" + DropDownList2.SelectedItem + "')", con);
                SqlCommand cmd1 = new SqlCommand("Insert into  [dbo].[User] (UserName,Password,Roll) values('" + TextBox3.Text + "','" + TextBox4.Text + "','" + "Student" + "')", con);
                List<string> checks = new List<string>();
                for (int j = 0; j < CheckBoxList1.Items.Count; j++)
                {
                    if (CheckBoxList1.Items[j].Selected)
                    {
                        checks.Add(CheckBoxList1.Items[j].Value);
                    }
                }
                credit = (List<string>)Session["key"];
                CourseId = (List<string>)Session["id"];

                int i = cmd.ExecuteNonQuery();
                int i1 = cmd1.ExecuteNonQuery();
                for (int j = 0; j < checks.Count; j++)
                {
                    SqlCommand cmd2 = new SqlCommand("Insert into  [dbo].[StudentSubject] (UserName,Subject,Credit,CourseId,Term) values('" + TextBox3.Text + "','" + checks[j] + "','" + credit[j].ToString() + "','" + CourseId[j] + "','" + DropDownList2.SelectedItem + "')", con);
                    cmd2.ExecuteNonQuery();
                }
                if (i > 0 && i1 > 0)
                {
                    Response.Redirect("Result.aspx");
                }
            }
            catch (Exception ex)
            {

                Label1.ForeColor = Color.Red;
                Label1.Text = ex.Message;
            }
            con.Close();
        }

        
       

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string choice = DropDownList1.SelectedItem.Value;
                string choice1 = DropDownList2.SelectedItem.Value;
                Label2.Visible = true;
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select * from Subjects where Department = '" + choice + "'and term= '" + choice1 + "'", con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                CheckBoxList1.DataSource = ds;
                CheckBoxList1.DataTextField = "Subject";
                CheckBoxList1.DataBind();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    credit.Add(dr["Credit"].ToString());
                    CourseId.Add(dr["CourseId"].ToString());
                }
                Session["key"] = credit;
                Session["id"] = CourseId;
            }
            catch (Exception ex)
            {

                Label1.ForeColor = Color.Red;
                Label1.Text = ex.Message;
            }
        }
    }
}