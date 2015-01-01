using QuanLyCongBoKhoaHoc.Business;
using QuanLyCongBoKhoaHoc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyCongBoKhoaHoc.UserControl
{
    public partial class UcTimKiemGiangVien : System.Web.UI.UserControl
    {
        string currentpage = "1";
        string TuKhoa = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TrangHienTai"] != null )
            {
                currentpage = Session["TrangHienTai"].ToString();
            }
            BindData(currentpage, "6");
            show1(TuKhoa);
        }

        void ThongBao(string Loi)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Thông báo!", "<script>alert('" + Loi + "')</script>", false);
        } 


        void show1(string TuKhoa)
        {
            string chuoi = "";
            List<EGiangVien> listpage = new List<EGiangVien>();
            listpage = BGiangVien.GetByTop("", "TenGiangVien like '%"+TuKhoa+"%'", " MaGiangVien desc"); 
            chuoi += "<ul>";
            if (listpage.Count >6) 
            {
                if ((listpage.Count) % 6 == 0) 
                {
                    if (Int32.Parse(currentpage) == 1)
                    {
                        chuoi += "<li><a  class='li_first' href='/Tim-kiem/TKGV/1'>" + "Prev" + "</a></li>";
                    }
                    else
                    {
                        chuoi += "<li><a class='li_first' href='/Tim-kiem/TKGV/" + (Int32.Parse(currentpage) - 1).ToString() + "'>" + "Prev" + "</a></li>";
                    }
                    for (int i = 1; i <= (listpage.Count / 6); i++)
                    {
                        if (i.ToString().Equals(currentpage))
                        {
                            chuoi += "<li><a class='selected tab' href='/Tim-kiem/TKGV/" + i + "'>" + i + "</a></li>";
                        }
                        else
                        {
                            chuoi += "<li><a class='tab' href='/Tim-kiem/TKGV/" + i + "'>" + i + "</a></li>";
                        }
                    }
                    if (Int32.Parse(currentpage) == ((listpage.Count / 6) + 1))
                    {
                        chuoi += "<li><a class='li_last' href='/Tim-kiem/TKGV/" + currentpage + "'>" + "Next" + "</a></li>";
                    }
                    else
                    {
                        chuoi += "<li><a class='li_last' href='/Tim-kiem/TKGV/" + (Int32.Parse(currentpage) + 1).ToString() + "'>" + "Next" + "</a></li>";
                    }
                }
                else
                {
                    if (Int32.Parse(currentpage) == 1)
                    {
                        chuoi += "<li><a class='li_first' href='/Tim-kiem/TKGV/1'>" + "Prev" + "</a></li>";
                    }
                    else
                    {
                        chuoi += "<li><a class='li_first' href='/Tim-kiem/TKGV/" + (Int32.Parse(currentpage) - 1).ToString() + "'>" + "Prev" + "</a></li>";
                    }

                    for (int i = 1; i <= (listpage.Count / 6) + 1; i++)
                    {
                        if (i.ToString().Equals(currentpage))
                        {
                            chuoi += "<li><a class='selected tab' href='/Tim-kiem/TKGV/" + i + "'>" + i + "</a></li>";
                        }
                        else
                        {
                            chuoi += "<li><a class='tab' href='/Tim-kiem/TKGV/" + i + "'>" + i + "</a></li>";
                        }
                    }
                    if (Int32.Parse(currentpage) == ((listpage.Count / 6) + 1))
                    {
                        chuoi += "<li><a class='li_last' href='/Tim-kiem/TKGV/" + currentpage + "'>" + "Next" + "</a></li>";
                    }
                    else
                    {
                        chuoi += "<li><a class='li_last' href='/Tim-kiem/TKGV/" + (Int32.Parse(currentpage) + 1).ToString() + "'>" + "Next" + "</a></li>";
                    }
                }


            }
            else  // số trang bằng 1
            {
                if (listpage.Count > 0)
                {
                    for (int i = 0; i < listpage.Count; i++)
                    {
                        chuoi += "<div class=\"GiangVien\">";
                        chuoi += "<a href=\"/Ly-Lich/" + listpage[i].MaGiangVien + "\"><img src=\"/images/AnhGiangVien/" + listpage[i].AnhDaiDien + "\" /></a>";
                        chuoi += "<a style=\" color:black !important; font-weight:bold !important; padding-left:20px !important; \" href=\"/Ly-Lich/" + listpage[i].MaGiangVien + "\">" + listpage[i].TenGiangVien + "</a>";
                        chuoi += "<p>SĐT:<b> " + listpage[i].DienThoai + " </b></p>";
                        chuoi += "</div>";
                    }
                }
            }
            chuoi += "</ul>";
            ltrpaging.Text = chuoi;
            listpage.Clear();
            listpage = null;
        }

        void BindData(string currentpage, string pagesize)
        {

            List<EGiangVien> list = new List<EGiangVien>();
            list = BGiangVien.Paging(int.Parse(currentpage), int.Parse(pagesize), "TenGiangVien like '%"+TuKhoa+"%'", " ");
            string Chuoi = "";
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Chuoi += "<div class=\"GiangVien\">";
                    Chuoi += "<a href=\"/Ly-Lich/" + list[i].MaGiangVien + "\"><img src=\"/images/AnhGiangVien/" + list[i].AnhDaiDien + "\" /></a>";
                    Chuoi += "<a style=\" color:black !important; font-weight:bold !important; padding-left:20px !important;  \" href=\"/Ly-Lich/" + list[i].MaGiangVien + "\">" + list[i].TenGiangVien + "</a>";
                    Chuoi += "<p>SĐT:<b> " + list[i].DienThoai + " </b></p>";
                    Chuoi += "</div>";
                }
            }
            ltrGiangVien.Text = Chuoi;
            list.Clear();
            list = null;
        }

        protected void btnTimKiemGiangVien_Click(object sender, EventArgs e)
        {
            Session["TuKhoa"] = txtTimTenGiangVien.Value;
            Response.Redirect("~/HienThiTimKiem.aspx");
        }


    }
}