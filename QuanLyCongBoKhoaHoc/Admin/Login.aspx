<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QuanLyCongBoKhoaHoc.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Đăng nhập hệ thống</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="../css/bootstrap.min.css" />
    <link rel="stylesheet" href="../css/maruti-login.css" />
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div id="loginbox">
            <div class="control-group normal_text">
                <h4>Đăng nhập hệ thống</h4>
            </div>
            <div class="control-group">
                <div class="controls">
                    <div class="main_input_box">
                        <span class="add-on"><i class="glyphicon glyphicon-user"></i></span>
                        <asp:TextBox ID="txtTenDangNhap" runat="server" placeholder="Username" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="dn" runat="server"
                            ControlToValidate="txtTenDangNhap" ErrorMessage="*" ForeColor="Red" Font-Bold="true"
                            ToolTip="Bạn chưa nhập tên đăng nhập"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="control-group password">
                <div class="controls">
                    <div class="main_input_box">
                        <span class="add-on"><i class="glyphicon glyphicon-lock"></i></span>
                        <asp:TextBox ID="txtMatKhau" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="dn" runat="server"
                            ControlToValidate="txtMatKhau" ErrorMessage="*" ForeColor="Red" Font-Bold="true"
                            ToolTip="Bạn chưa nhập mật khẩu"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="remember">
                <asp:CheckBox ID="cbNhoMatKhau" runat="server" Text="Nhớ mật khẩu" />
            </div>
            <div class="control-group">
                <div class="controls">
                    <asp:Button ID="btDangNhap" runat="server" CssClass="btn btn-info" ValidationGroup="dn"
                        Text="Đăng nhập" OnClick="btDangNhap_Click" />
                    <%--<a href="laymatkhau.aspx" class="btn btn-info">Quên mật khẩu</a>--%>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
