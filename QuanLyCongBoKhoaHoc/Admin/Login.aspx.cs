using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyCongBoKhoaHoc.Entities;
using QuanLyCongBoKhoaHoc.Business;

namespace QuanLyCongBoKhoaHoc.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userName"] != null && Request.Cookies["pass"] != null)
            {
                cbNhoMatKhau.Checked = true;
                try
                {
                    DangNhap(Request.Cookies["userName"].Value, Request.Cookies["pass"].Value);
                }
                catch
                { }
            }
        }
        
        void ThongBao(string Loi)
         {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Thông báo!", "<script>alert('" + Loi + "')</script>", false);
         }

        protected void btDangNhap_Click(object sender, EventArgs e)
        {
            // Ma hoa MD5 mat khau
              DangNhap(txtTenDangNhap.Text, Router.MaHoaMD5(txtMatKhau.Text));
        }

        void DangNhap(string TenDN,string Matkhau)
        {
            EGiangVien GiangVien = BGiangVien.DangNhap(TenDN, Matkhau);

            if (GiangVien.TenGiangVien == null)
            {

                ThongBao("Tài khoản hoặc mật khẩu sai....!");
            }
            else
            {
                if (cbNhoMatKhau.Checked == true)
                {
                    Response.Cookies["userName"].Value = TenDN;
                    Response.Cookies["pass"].Value = GiangVien.MatKhau;

                    Response.Cookies["userName"].Expires = DateTime.Now.AddDays(15);
                    Response.Cookies["pass"].Expires = DateTime.Now.AddDays(15);

                }
                else if (cbNhoMatKhau.Checked == false)
                {
                    Response.Cookies["pass"].Expires = DateTime.Now;
                    Response.Cookies["userName"].Expires = DateTime.Now;
                }

           //     Session["QuyenDN"] = GiangVien.idChucVu;
                Session["TenGiangVIen"] = GiangVien.TenGiangVien;
                Session["AnhDaiDien"] = GiangVien.AnhDaiDien;
                Session["MaGiangVien"] = GiangVien.MaGiangVien;
                Response.Redirect("~/Admin/AdHome.aspx");
            }            
        }
    }
}