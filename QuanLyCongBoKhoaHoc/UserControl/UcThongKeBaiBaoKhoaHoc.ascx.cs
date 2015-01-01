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
    public partial class UcThongKeBaiBaoKhoaHoc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGvBaiBaoKhoaHoc();
        }

        void LoadGvBaiBaoKhoaHoc()
        { 
            DataTable ThongKeBaiBaoKhoaHoc = new DataTable();
                DataColumn col2 = new DataColumn("TenGiangVien", typeof(string));
                DataColumn col3 = new DataColumn("Khoa", typeof(string));
                DataColumn col4 = new DataColumn("SoLuong", typeof(int));
   
                ThongKeBaiBaoKhoaHoc.Columns.Add(col2);
                ThongKeBaiBaoKhoaHoc.Columns.Add(col3);
                ThongKeBaiBaoKhoaHoc.Columns.Add(col4);


                DataTable dtGiangVien = new DataTable();
                dtGiangVien = BGiangVien.SelectAll();
                foreach (DataRow row in dtGiangVien.Rows)
                {
                    DataTable dtBaiBaoKhoaHoc = new DataTable();
                    dtBaiBaoKhoaHoc = BBaiBao.SelectCountByMaGiangVien(row["MaGiangVien"].ToString());
                    int dem =0 ;
                    dem = int.Parse(dtBaiBaoKhoaHoc.Rows[0][0].ToString());
                 
                    DataRow dr;
                    dr = ThongKeBaiBaoKhoaHoc.NewRow();
                    dr[0] = BGiangVien.SelectByID(int.Parse(row["MaGiangVien"].ToString())).TenGiangVien;
                    dr[1] = BKhoa.SelectTenKhoaByMaGiangVien(int.Parse(row["MaGiangVien"].ToString())).TenKhoa;
                    dr[2] = dem;
                   ThongKeBaiBaoKhoaHoc.Rows.Add(dr);
                }
                DataView dv = ThongKeBaiBaoKhoaHoc.DefaultView;
                dv.Sort = "SoLuong Desc";
                ThongKeBaiBaoKhoaHoc = dv.ToTable();

                gvTTBaiBaoKhoaHoc.AutoGenerateColumns = false;
                gvTTBaiBaoKhoaHoc.DataSource = ThongKeBaiBaoKhoaHoc;
                gvTTBaiBaoKhoaHoc.DataBind();
            }

        protected void gvTTBaiBaoKhoaHoc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTTBaiBaoKhoaHoc.PageIndex = e.NewPageIndex;
            LoadGvBaiBaoKhoaHoc();
        }
             
    }
}