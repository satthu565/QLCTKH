<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcLietKeBaiBaoKhoaHoc.ascx.cs" Inherits="QuanLyCongBoKhoaHoc.UserControl.UcLietKeBaiBaoKhoaHoc" %>

<h2 style="text-align:center"> LIỆT KÊ BÀI BÁO KHOA HỌC</h2>

<div class="row" style="text-align:center"> Tìm kiếm Bài báo 
    <asp:DropDownList ID="ccbGioiHan" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ccbGioiHan_SelectedIndexChanged">
    <asp:ListItem Value="True">Trong nước</asp:ListItem>
    <asp:ListItem Value="False">Quốc tế</asp:ListItem>
    </asp:DropDownList>
</div>
<hr />

  <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
               <div class="row" style="margin-bottom:3px;">
                 <div class="col-md-11 col-md-offset-1 ">  
                        <p>   
                           <b><%# Eval("TenBaiBao") %> </b> 
                           Tác giả: <%# ChuoiTenTacGia(Eval("ChuoiMaGiangVienTacGia").ToString() )%>,<%#Eval("TenTacGiaNgoai") %>
                           <%# Eval("NoiCongBo") %> <b> Mã số: </b> <%#Eval("MaSo") %>
                           <b> Năm: </b> <%# String.Format("{0:dd/MM/yyyy}",Eval("ThoiGianXuatBan")) %>  
                        </p>
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
