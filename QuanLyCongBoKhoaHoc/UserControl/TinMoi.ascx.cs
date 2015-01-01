using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyCongBoKhoaHoc.Business;

namespace QuanLyCongBoKhoaHoc.UserControl
{
    public partial class TinMoi : System.Web.UI.UserControl
    {
        public DataTable TbCongBo;
        protected void Page_Load(object sender, EventArgs e)
        {
            TbCongBo = BDanhSachCongBoKhoaHoc.SelectAll();
        }
    }
}