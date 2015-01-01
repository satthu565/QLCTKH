<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcHienThiTimKiemGiangVien.ascx.cs" Inherits="QuanLyCongBoKhoaHoc.UserControl.UcHienThiTimKiemGiangVien" %>

<h4 style="text-align:center" >TÌM KIẾM GIẢNG VIÊN</h4>

<form class="form-horizontal" role="form">
     <div class="form-group">
             <label for="inputEmail3" class="col-sm-4 control-label"> Nhập họ tên giảng viên : </label>
        <div class="col-sm-6">
             <input id="txtTimTenGiangVien" runat="server" type="text" class="form-control col-lg-4" placeholder="Nhập họ tên tìm kiếm">   
        </div>
        <div class="col-sm-2">
             <asp:Button ID="Button1" CssClass="btn btn-primany" runat="server" Text="Tìm kiếm" OnClick="btnTimKiemGiangVien_Click1"   />
        </div>
    </div>
</form>
<br />
<hr />
    <h4 style="text-align:center">KẾT QUẢ TÌM KIẾM</h4>
  <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
               <div class="row" style="margin-bottom:3px;">
                 <div class="col-md-7 col-md-offset-1 ">
                  <b>   Họ tên : </b> <%# Eval("TenHocVi") %>.<%# Eval("TenGiangVien") %> <br />
                  <b>   Khoa : </b> <%# Eval("TenKhoa") %> <br />
                  <b>   Số điện thoại : </b> <%# Eval("DienThoai") %> <br />
                  <b>   Email : </b> <%# Eval("Email") %> <br />
                  <a href="/CV-Giang-Vien/TTC/<%#Eval("MaGiangVien") %>">Lý lịch Khoa Học</a>
                 </div>
                 <div class="col-md-4"> 
                     <img src="/images/AnhGiangVien/<%#Eval("AnhDaiDien") %>" alt="Ảnh đại diện" width="120px" height="140px" />
                 </div>
               </div>
            </ItemTemplate>
  </asp:Repeater>

        <div style="overflow: hidden; text-align:center ; margin:5px auto" class="phantrang">
            <asp:Repeater ID="rptPages" runat="server"
                OnItemCommand="rptPages_ItemCommand1">
                <ItemTemplate>
                    <asp:LinkButton ID="btnPage"
                        Style="padding: 1px 3px; margin: 1px; background: #ccc; border: solid 1px #666;
                        font: 8pt tahoma;"
                        CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                        runat="server"><%# Container.DataItem %></asp:LinkButton>
                </ItemTemplate>
            </asp:Repeater>
        </div>