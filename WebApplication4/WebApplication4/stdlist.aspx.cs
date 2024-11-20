using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Models;

namespace WebApplication4
{
    public partial class stdlist : System.Web.UI.Page
    {
        StudenDAO _stdDAO = new StudenDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                RefreshData();
            }

        }

        private void RefreshData()
        {
            Repeater1.DataSource = _stdDAO.Read();
            Repeater1.DataBind();
        }
    }
}