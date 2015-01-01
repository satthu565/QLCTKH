<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcLietKeCongTrinhKhoaHoc.ascx.cs" Inherits="QuanLyCongBoKhoaHoc.UserControl.UcLietKeCongTrinhKhoaHoc" %>

<h2 style="text-align:center"> LIỆT KÊ CÔNG TRÌNH KHOA HỌC </h2>

    <div class="row" style="text-align:center"> 
       <b>  Đề tài cấp : </b>
        <asp:DropDownList ID="ccbCapDeTai" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ccbCapDeTai_SelectedIndexChanged">
        </asp:DropDownList> 
    </div>
<hr />
 <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
               <div class="row" style="margin-bottom:3px;">
                 <div class="col-md-11 col-md-offset-1 ">  
                        <p>   
                          <b><%# Eval("TenCongTrinh") %></b><b> Chủ nhiêm  :</b> <%# ChuoiTacGiaChuNhiem(Eval("ChuoiMaGiangVienChuNhiem").ToString() )%>,<%#Eval("TenChuNhiemNgoai") %>
                          <b>Thành viên :</b> <%# ChuoiTacGiaThanhVien(Eval("ChuoiMaThanhVienThamGia").ToString() )%>,<%#Eval("TenThanhVienNgoai") %>
                          <b>Nơi công bố :</b> <%# Eval("NoiCongBo") %> - <b> Mã số: </b>" <%#Eval("MaSo") %> <%# String.Format("{0:dd/MM/yyyy}",Eval("NamCongBo")) %>  
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
