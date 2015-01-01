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
    public partial class UcThongKeCongTrinhKhoaHoc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadThongKeTheoTacGia();
        }

          void LoadThongKeTheoTacGia()
            {
                DataTable ThongKeCongTrinhKhoaHoc = new DataTable();
                DataColumn col2 = new DataColumn("TenGiangVien", typeof(string));
                DataColumn col3 = new DataColumn("Khoa", typeof(string));
                DataColumn col4 = new DataColumn("SoLuong", typeof(int));
   
                ThongKeCongTrinhKhoaHoc.Columns.Add(col2);
                ThongKeCongTrinhKhoaHoc.Columns.Add(col3);
                ThongKeCongTrinhKhoaHoc.Columns.Add(col4);


                DataTable dtGiangVien = new DataTable();
                dtGiangVien = BGiangVien.SelectAll();
                foreach (DataRow row in dtGiangVien.Rows)
                {
                    DataTable dtCongTrinhKhoaHoc = new DataTable();
                    dtCongTrinhKhoaHoc = BDanhSachCongBoKhoaHoc.SelectCountByMaGiangVien(row["MaGiangVien"].ToString());
                    int dem =0 ;
                    dem = int.Parse(dtCongTrinhKhoaHoc.Rows[0][0].ToString());
                   DataRow dr;
 
                    dr = ThongKeCongTrinhKhoaHoc.NewRow();
                    dr[0] = BGiangVien.SelectByID(int.Parse(row["MaGiangVien"].ToString())).TenGiangVien;
                    dr[1] = BKhoa.SelectTenKhoaByMaGiangVien(int.Parse(row["MaGiangVien"].ToString())).TenKhoa;
                    dr[2] = dem;
                   ThongKeCongTrinhKhoaHoc.Rows.Add(dr);
                }
                DataView dv = ThongKeCongTrinhKhoaHoc.DefaultView;
                dv.Sort = "SoLuong Desc";
                ThongKeCongTrinhKhoaHoc = dv.ToTable();

                gvTTCongTrinhKhoaHoc.AutoGenerateColumns = false;
                gvTTCongTrinhKhoaHoc.DataSource = ThongKeCongTrinhKhoaHoc;
                gvTTCongTrinhKhoaHoc.DataBind();
            }

          protected void gvTTCongTrinhKhoaHoc_PageIndexChanging(object sender, GridViewPageEventArgs e)
          {
              gvTTCongTrinhKhoaHoc.PageIndex = e.NewPageIndex;
              LoadThongKeTheoTacGia();
          }


    }
}