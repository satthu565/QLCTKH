<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcTimKiemGiangVien.ascx.cs" Inherits="QuanLyCongBoKhoaHoc.UserControl.UcTimKiemGiangVien" %>
<h4 style="text-align:center">TÌM KIẾM GIẢNG VIÊN</h4>

<form class="form-horizontal" role="form">
     <div class="form-group">
             <label for="inputEmail3" class="col-sm-4 control-label"> Nhập tên bài báo cần tìm : </label>
        <div class="col-sm-6">
             <input id="txtTimTenGiangVien" runat="server" type="text" class="form-control col-lg-4" placeholder="Nhập họ tên giảng viên cần tìm kiếm">   
        </div>
        <div class="col-sm-2">
             <asp:Button ID="btnTimKiemGiangVien" CssClass="btn btn-primany" runat="server" Text="Tìm kiếm" OnClick="btnTimKiemGiangVien_Click" />
        </div>
    </div>
</form>

<br />
<hr />

<h4 style="text-align:center">KẾT QUẢ TÌM KIẾM GIẢNG VIÊN</h4>

  <asp:Literal ID="ltrGiangVien" runat="server">
    </asp:Literal>
    <div class="clear"></div>

     <div class="dv_paging">
            <asp:Literal ID="ltrpaging" runat="server"></asp:Literal>
     </div>
