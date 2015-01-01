using QuanLyCongBoKhoaHoc.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyCongBoKhoaHoc.UserControl
{
    public partial class UcLietKeCongTrinhKhoaHoc : System.Web.UI.UserControl
    {
        string[] MaChuNhiem;
        string[] MaThanhVien;

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadcbbCapDeTai();
          //  LoadData();
        }

        public string ChuoiTacGiaChuNhiem(string chuoi)
        {
            string TenChuNhiem = "";
            string TenCN = "";
            string MaChuNhiemChuan = HamXuLyChuoi(chuoi);  // ko con day '-' o dau va cuoi
            MaChuNhiem = MaChuNhiemChuan.Split('-');
            foreach (var item1 in MaChuNhiem)
            {
                TenCN = BGiangVien.SelectByID(int.Parse(item1)).TenGiangVien;
                TenChuNhiem += TenCN + ",";
            }
            return TenChuNhiem;
        }


        public string ChuoiTacGiaThanhVien(string chuoi)
        {
            string TenThanhVien = "";
            string MaThanhVienChuan = HamXuLyChuoi(chuoi);  // ko con day '-' o dau va cuoi
            MaThanhVien = MaThanhVienChuan.Split('-');

            foreach (var item2 in MaThanhVien)
            {
                string TenTV = BGiangVien.SelectByID(int.Parse(item2)).TenGiangVien;
                TenThanhVien += TenTV + ",";
            }
            return TenThanhVien;
        }


        string HamXuLyChuoi(string ChuoiDau)
        {
            string s1 = ChuoiDau.Trim().Remove(0, 1);
            string s2 = s1.Remove(s1.Length - 1, 1);
            return s2;
        }

        void LoadcbbCapDeTai()
        {
            ccbCapDeTai.DataSource = BCapDeTai.SelectAll();
            ccbCapDeTai.DataTextField = "TenCapDeTai";
            ccbCapDeTai.DataValueField = "MaCapDeTai";
            ccbCapDeTai.DataBind();
            ccbCapDeTai.Items.Insert(0, "-- Chọn cấp đề tài --");
        }

        // ? xem lại chưa có ma giang vien 
        void LoadData( )
        {
            DataTable dt = new DataTable();
            int MaCapDeTai = int.Parse(ccbCapDeTai.SelectedValue.ToString());
            if (MaCapDeTai == 0)
            {
                dt = BDanhSachCongBoKhoaHoc.LietKe();
            }
            else
            {
                dt = BDanhSachCongBoKhoaHoc.LietKeByMaCapDeTai(MaCapDeTai);
            }   
            PagedDataSource pgitems = new PagedDataSource();
            System.Data.DataView dv = new System.Data.DataView(dt);
            pgitems.DataSource = dv;
            pgitems.AllowPaging = true;

            pgitems.PageSize = 10;
            pgitems.CurrentPageIndex = PageNumber;
            if (pgitems.PageCount > 1)
            {
                rptPages.Visible = true;
                System.Collections.ArrayList pages = new System.Collections.ArrayList();
                for (int i = 0; i < pgitems.PageCount; i++)
                    pages.Add((i + 1).ToString());
                rptPages.DataSource = pages;
                rptPages.DataBind();
            }
            else
                rptPages.Visible = false;
            Repeater1.DataSource = pgitems;
            Repeater1.DataBind();
        }

        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                    return Convert.ToInt32(ViewState["PageNumber"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber"] = value;
            }
        }

        protected void rptPages_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            LoadData();
        }

        protected void ccbCapDeTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }


    }
}