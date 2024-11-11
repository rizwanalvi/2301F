using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppImageData.Model;
namespace WebAppImageData
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        StudenDAO _stdDb = new StudenDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                RefershGridView();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if (FileUpload1.HasFile) {
                FileUpload1.SaveAs(Server.MapPath("/img/") + FileUpload1.FileName);
                String _imgPath = "/img/" + FileUpload1.FileName;
                _stdDb.Create(new Student {StudentName = TextBox1.Text,ImgPath = _imgPath });
            }
            RefershGridView();
        }

        private void RefershGridView() {

            GridView1.DataSource = _stdDb.Read();
            GridView1.DataBind();
        }
    }
}