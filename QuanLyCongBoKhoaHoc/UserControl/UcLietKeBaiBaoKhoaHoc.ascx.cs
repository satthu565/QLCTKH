using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using QuanLyCongBoKhoaHoc.Business;

namespace QuanLyCongBoKhoaHoc.UserControl
{
    public partial class UcLietKeBaiBaoKhoaHoc : System.Web.UI.UserControl
    {
         string[] MaChuNhiem;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData(true);
            }
        }
        //trong nước = 1 . quốc tế = 0 ;
        public string ChuoiTenTacGia(string chuoi)
        {
              string TenTG = "";
              string TenTacGia = "";   
                string MaChuNhiemChuan = HamXuLyChuoi(chuoi);  // ko con day '-' o dau va cuoi
                MaChuNhiem = MaChuNhiemChuan.Split('-');
                foreach (var item in MaChuNhiem)
                {
                    TenTG = BGiangVien.SelectByID(int.Parse(item)).TenGiangVien;
                    TenTacGia += TenTG + ",";
                }
            return TenTacGia;
        }

        string HamXuLyChuoi(string ChuoiDau)
        {
            string s1 = ChuoiDau.Trim().Remove(0, 1);
            string s2 = s1.Remove(s1.Length - 1, 1);
            return s2;
        }

        protected void ccbGioiHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageNumber = 0;
            bool GioiHan = bool.Parse(ccbGioiHan.SelectedValue.ToString());
            LoadData(GioiHan);
        }


        void LoadData(bool GioiHan)
        {
            DataTable dt = new DataTable();
            dt = BBaiBao.SelectByGioiHan(GioiHan);
            PagedDataSource pgitems = new PagedDataSource();
            System.Data.DataView dv = new System.Data.DataView(dt);
            pgitems.DataSource = dv;
            pgitems.AllowPaging = true;

            pgitems.PageSize = 6;
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
            bool GioiHan = bool.Parse(ccbGioiHan.SelectedValue.ToString());
            LoadData(GioiHan);
        }

    }
}