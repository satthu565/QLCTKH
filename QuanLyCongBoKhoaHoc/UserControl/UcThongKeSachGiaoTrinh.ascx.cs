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
    public partial class UcThongKeSachGiaoTrinh : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGvSachXuatBan();
        }

        void LoadGvSachXuatBan()
        {
            gvTKSachXuatBan.AutoGenerateColumns = false;
            gvTKSachXuatBan.DataSource = BSachXuatBan.SelectThongKeSachXuatBan_GiangVien();
            gvTKSachXuatBan.DataBind();
        }

        protected void gvTKSachXuatBan_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTKSachXuatBan.PageIndex = e.NewPageIndex;
            LoadGvSachXuatBan();
        }


    }
}