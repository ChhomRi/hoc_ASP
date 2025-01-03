using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab01
{
    public partial class DonDatHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                KhoiTaoDuLieu();
            }
        }

        private void KhoiTaoDuLieu()
        {
            DDlLoaiBanh.Items.Add(new ListItem("Bánh Pía", "01"));
            DDlLoaiBanh.Items.Add(new ListItem("Bánh mì", "02"));
            DDlLoaiBanh.Items.Add(new ListItem("Bánh bao", "03"));
            DDlLoaiBanh.Items.Add(new ListItem("Bánh su", "04"));
            DDlLoaiBanh.Items.Add(new ListItem("Bánh tét", "05"));
            DDlLoaiBanh.Items.Add(new ListItem("Bánh Humburger", "06"));
        }

      

        protected void btThemBanh_Click(object sender, EventArgs e)
        {
            try
            {
                string loaibanh = DDlLoaiBanh.SelectedItem.Text;
                int soluong = int.Parse(txtSoLuong.Text);
                LBBanhDat.Items.Add(string.Format("{0} ({1})", loaibanh, soluong));

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        protected void btXoa_Click(object sender, ImageClickEventArgs e)
        {
            for(int i = LBBanhDat.Items.Count - 1; i >= 0; i--)
            {
                if (LBBanhDat.Items[i].Selected)
                {
                    LBBanhDat.Items.RemoveAt(i);
                }
            }

        }

        protected void btInDonHang_Click(object sender, EventArgs e)
        {
            string kq = "<div style = 'color: green;'>";
            kq += "<div class ='h3 text-center mt-3'>HOÁ ĐƠN ĐẶT HÀNG</div>";
            kq += "<div class='border p-2'>";
            //Thu thập thông tin hoá đơn gửi từ client 
            kq += $"<b>Khách hàng</b>: <i>{txtKH.Text}</i> <br>";
            kq += $"<b>Địa chỉ</b>: <i>{txtDC.Text}</i> <br>";
            kq += $"<b>Mã số thuế</b>: <i>{txtMST.Text}</i> <br>";
            kq += "<b>Đặt các loại bánh sau: </b> <br>";

            kq += "<table class='table table-bordered'>";
            foreach(ListItem item in LBBanhDat.Items)
            {
                string data = item.Text;
                string[] arr = data.Split(new char[] { '(', ')' });
                kq += $"<tr><td>{arr[0]}</td><td>{arr[1]} </td></tr>";
            }
            kq += "</table>";
            kq += "</div>";
            //Gửi thông tin hoá đơn về client
            lblHoaDon.Text = kq;

        }
    }
}