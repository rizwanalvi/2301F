using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Model;
namespace WebApplication3
{
    public partial class Default : System.Web.UI.Page
    {
        DAOStudent _dbStudnet = new DAOStudent();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GridView1.DataSource = _dbStudnet.Read();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            _dbStudnet.Create(new Student {StudentName = TextBox1.Text,Grade = TextBox2.Text,EmailId = TextBox3.Text });
            GridView1.DataSource = _dbStudnet.Read();
            GridView1.DataBind();
        }

        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = _dbStudnet.Read();
            GridView1.DataBind();

        }

        protected void RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label _lblId = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            TextBox _txtStdName = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox _txtGrade = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox _txtEmail = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            _dbStudnet.Update(new Student {StudentId = int.Parse(_lblId.Text), 
                StudentName = _txtStdName.Text,Grade = _txtGrade.Text,EmailId=_txtEmail.Text });
            GridView1.EditIndex =-1;
            GridView1.DataSource = _dbStudnet.Read();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = _dbStudnet.Read();
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label _lblId = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            _dbStudnet.Delete(int.Parse(_lblId.Text));
            GridView1.EditIndex = -1;
            GridView1.DataSource = _dbStudnet.Read();
            GridView1.DataBind();

        }
    }
}