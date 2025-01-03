using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab01
{
    public partial class DangKyThongTin : System.Web.UI.Page
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
            ddlTrinhDo.Items.Add("Trung Cấp");
            ddlTrinhDo.Items.Add("Cao Đẳng");
            ddlTrinhDo.Items.Add("Đại Học");
            ddlTrinhDo.Items.Add("Sau Đại Học");

            lstNgheNghiep.Items.Add("Công nhân");
            lstNgheNghiep.Items.Add("Kỹ Sư");
            lstNgheNghiep.Items.Add("Lập Trình Viên");
            lstNgheNghiep.Items.Add("Kế Toán Viên");
            lstNgheNghiep.Items.Add("Bác Sĩ");

            cklSoThich.Items.Add("Xem Phim");
            cklSoThich.Items.Add("Mua Sắm");
            cklSoThich.Items.Add("Du Lịch");
            cklSoThich.Items.Add("Chơi Game");
            cklSoThich.Items.Add("Ăn Nhậu");
            cklSoThich.Items.Add("Đá Bóng");
            cklSoThich.Items.Add("Bóng Chuyền");
        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            //b1. Lấy thông tin từ client 
            string kq = "<ul>";
            kq += string.Format("<li> Họ tên: <b> {0} </b>", txtHoTen.Text);
            kq += string.Format("<li> Ngày sinh: <b> {0} </b>", txtNgaySinh.Text);
            kq += string.Format("<li> Giới tính: <b> {0} </b>", (rdNam.Checked? rdNam.Text: rdNu.Text));
            kq += string.Format("<li> Trình độ: <b> {0} </b>", ddlTrinhDo.SelectedItem.Text);
            kq += string.Format("<li> Nghề Nghiệp: <b> {0} </b>", lstNgheNghiep.SelectedItem.Text);
            //Xử lý upload file
            if(FHinh.HasFile)
            {
                string path = Server.MapPath("~/Uploads");//Lấy đường dẫn tuyệt đối của thư mục Upload
                string filename = FHinh.FileName;//Lấy tên file từ client gửi
                FHinh.SaveAs(path + "/" + filename); //upload
                kq += string.Format("<li> Ảnh đại diện: <img src='/uploads/{0}' width='200px' >",filename);
            }
            //LẤY THÔNG TIN SỞ THÍCH
            string sothich = "";
            foreach(ListItem item in cklSoThich.Items)
            {
                if (item.Selected)
                {
                    sothich += item.Text + ",";

                }
            }
            kq += string.Format("<li> Sở thích: <b> {0} </b>", sothich);
            kq += "</ul>";
            //b2.HỒI ĐÁP KẾT QUẢ 
            lbThongTin.Text = kq;
        }

        protected void btNhapLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            ddlTrinhDo.SelectedIndex = 0;
            lstNgheNghiep.SelectedIndex = -1;
            foreach(ListItem item in cklSoThich.Items)
            {
                item.Selected = false;

            }
            lbThongTin.Text = "";


        }
    }
}