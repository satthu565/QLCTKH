using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyCongBoKhoaHoc.Business;
using QuanLyCongBoKhoaHoc.Entities;
using System.Data;

namespace QuanLyCongBoKhoaHoc.UserControl
{
    public partial class MenuDoc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
         // LoadGiangVien();
        }

        void LoadData()
        {
            rptSach.DataSource = BSachXuatBan.SachXuatBan_GiangVien();
            rptSach.DataBind();
        }

        //void LoadGiangVien()
        //{
        //    string code ="";
        //    DataTable dtGiangVien = new DataTable();
        //    dtGiangVien = BGiangVien.SelectAll();
         
        //    for (int i = 0; i < dtGiangVien.Rows.Count ; i++)
        //    {
        //        if (i==0)
        //        {
        //            code += "<div class=\"item active\">";
        //        }
        //        else
        //        {
        //            code += "<div class=\"item\">";
        //        }
        //                     code +="<div class=\"row\">";
        //                     code +="<div class=\"content-client\">";
        //                     code +="<div class=\"mid-content\">";
        //                     code += "<p> Dân tộc" + dtGiangVien.Rows[i]["DanToc"].ToString() + " Quê quán :" + dtGiangVien.Rows[i]["QueQuan"].ToString() + " Email :" + dtGiangVien.Rows[i]["Email"].ToString() + " Năm sinh:" + String.Format("{0:dd/MM/yyyy}", dtGiangVien.Rows[i]["NamSinh"].ToString()) + " </p>";
        //                      code +="</div>";
        //                      code +="<hr>";
        //                      code +="<div class=\"footer-content\">";
        //                      code +="<div class=\"client-img\">";
        //                      code +="<img src=\"../../img/client-img.png\" alt=\"client-img\">";
        //                      code +="</div>";
        //                       code +="<div class=\"client-info\">";
        //                      code +="<p class=\"name\">Nguyễn Hữu A</p>";
        //                      code +="<p class=\"excerpt\">Khoa CNTT</p>";
        //                      code +="</div>";
        //                   code +="</div>";
        //                  code +="</div>";
        //                code +="</div>";
        //          code +="</div>";
        //    }
        //    lbGiangVien.Text = code;
        //}



    }
}