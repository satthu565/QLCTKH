<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcLietKeSachGiaoTrinh.ascx.cs" Inherits="QuanLyCongBoKhoaHoc.UserControl.UcLietKeSachGiaoTrinh" %>

<h2 style="text-align:center"> LIỆT KÊ SÁCH GIÁO TRÌNH</h2>
<hr />

  <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
               <div class="row" style="margin-bottom:3px;">
                 <div class="col-md-11 col-md-offset-1 ">  
                        <p>   
                           <b><%# Eval("TenSach") %> </b> 
                           Tác giả: <%# TenTacGia(int.Parse(Eval("MaGiangVien").ToString())) %>
                           <%# Eval("NhaXuatBan") %> 
                           <b> Năm xuất bản : </b> <%# String.Format("{0:dd/MM/yyyy}",Eval("NamHoanThanh")) %>  
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