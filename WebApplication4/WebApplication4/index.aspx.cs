using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;
namespace WebApplication4
{
    public partial class index : System.Web.UI.Page
    {
        StudenDAO _stdDAO = new StudenDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                RefreshData();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("/img/") + FileUpload1.FileName);
                String _imgPath = "/img/" + FileUpload1.FileName;
                _stdDAO.Create(new Student { StudentName = TextBox1.Text, ImgPath = _imgPath});
                RefreshData();
            }
        }

        private void RefreshData() {
            GridView1.DataSource = _stdDAO.Read();
            GridView1.DataBind();
        }
    }
}