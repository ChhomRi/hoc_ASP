using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab01
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            //Lấy thông tin từ client
            // String hoten = Request["txtHoTen"];
            string hoten = txtHoTen.Text;
            //Gửi hồi đáp về client
            lbChao.Text = "Chào bạn Ri <b>" + hoten + "</b> đến với ASP.NET";
        }
    }
}