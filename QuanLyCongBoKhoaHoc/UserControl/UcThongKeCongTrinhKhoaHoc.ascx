<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcThongKeCongTrinhKhoaHoc.ascx.cs" Inherits="QuanLyCongBoKhoaHoc.UserControl.UcThongKeCongTrinhKhoaHoc" %>
<h2 style="text-align:center"> THỐNG KÊ CÔNG TRÌNH KHOA HỌC</h2>
<div class="table-responsive">
        <asp:GridView ID="gvTTCongTrinhKhoaHoc" runat="server" AllowPaging="True" PageSize="15" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" OnPageIndexChanging="gvTTCongTrinhKhoaHoc_PageIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="STT">  
                     <ItemTemplate>  
                         <%# Container.DataItemIndex + 1 %>  
                     </ItemTemplate>  
                </asp:TemplateField>
                <asp:BoundField DataField="TenGiangVien" HeaderText="Tên tác giả" />
                <asp:BoundField DataField="Khoa" HeaderText="Đơn vị Công tác" />
                <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" />
            </Columns>
        </asp:GridView>
</div>