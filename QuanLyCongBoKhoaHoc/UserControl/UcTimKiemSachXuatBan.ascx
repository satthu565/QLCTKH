﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcTimKiemSachXuatBan.ascx.cs" Inherits="QuanLyCongBoKhoaHoc.UserControl.UcTimKiemSachXuatBan" %>

<h3 style="text-align:center" >TÌM KIẾM SÁCH XUẤT BẢN</h3>

<form class="form-horizontal" role="form">
     <div class="form-group">
             <label for="inputEmail3" class="col-sm-4 control-label"> Nhập tên sách cần tìm : </label>
        <div class="col-sm-6">
             <input id="txtTenSach" runat="server" type="text" class="form-control col-lg-4" placeholder="Nhập tên sách tìm kiếm">   
        </div>
        <div class="col-sm-2">
             <asp:Button ID="btnTimKiem" CssClass="btn btn-primany" runat="server" Text="Tìm kiếm" OnClick="btnTimKiem_Click" />
        </div>
    </div>
</form>
<br />
<hr />
    <h3 style="text-align:center">KẾT QUẢ TÌM KIẾM</h3>
  <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
               <div class="row" style="margin-bottom:3px;">
                 <div class="col-md-11 col-md-offset-1 ">
                     <b><%# Eval("TenSach") %> </b> 
                           Tác giả: <%# TenTacGia(int.Parse(Eval("MaGiangVien").ToString())) %>
                           <%# Eval("NhaXuatBan") %> 
                           <b> Năm xuất bản : </b> <%# String.Format("{0:dd/MM/yyyy}",Eval("NamHoanThanh")) %>  
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