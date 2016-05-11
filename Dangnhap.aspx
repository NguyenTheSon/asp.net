<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dangnhap.aspx.cs" Inherits="Dangnhap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>
    <link rel="shortcut icon" href="Images/icon_diploma.png" type="image/x-icon" />
    <link href="Styles/css/bootstrap-theme.min.css" rel="stylesheet" type="text/css" />
    <link href="Styles/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="Styles/js/thietkewebphp.net.snow.js" type="text/javascript"></script>
    <script src="Styles/js/bootstrap.min.js" type="text/javascript"></script>
    <link href="Styles/css/styleDangnhap.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">
    </script>
</head>
<body>
    <div class="wapper">
        <div class="header">
            <div class="pic"><img src="Images/logoeschool.png" alt="Logo" /></div>
            <div class="linelogo"><img src="Images/linebanner.png" alt="Line"/></div>
            <div class="text">SỔ LIÊN LẠC ĐIỆN TỬ</div>
        </div>
        <div class="content">
            <div class="pic-1"><img src="Images/IMG_3457.jpg" alt="anh" class="img-rounded"/></div>            
            <div class="form">
                    <table>
                       <tr>
                       <td>
                         <img src="Images/login.png" alt="login"/>
                       </td>
                       <td>
                       <table>
                       <tr>
                       <td>
                         <span style="color:#666666; font-size:21px; padding-left:10px; font-family:Arial; font-weight:bold">Đăng nhập </span>
                       </td>
                       </tr>
                       <tr>
                       <td>
                          <span style="color:#0096db; font-size:19px;padding-left:10px; font-family:Arial;"> SỔ LIÊN LẠC ĐIỆN TỬ</span>
                       </td>
                       </tr>
                       </table>
                       </td>
                       </tr>
                    </table>
                    <form class="form-horizontal" action="" runat="server">
                      <div class="form-group">
                        <label for="inputEmail3" class="col-sm-3 control-label">Tài Khoản</label>
                        <div class="col-sm-9">
                          <asp:TextBox runat="server" class="form-control" id="txttaikhoan" placeholder="Tài khoản" />
                          <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txttaikhoan" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>-->
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="inputPassword3" class="col-sm-3 control-label">Mật Khẩu</label>
                        <div class="col-sm-9">
                          <asp:TextBox runat="server" TextMode="Password" class="form-control" id="txtmatkhau" placeholder="*********"/>
                          <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtmatkhau" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>-->
                        </div>
                      </div>
                      <div class="form-group">
                      <div class="col-sm-8">
                      </div>
                      <div class="col-sm-4">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="LayLaiMatKhau.aspx">Bạn Quên Mật Khẩu?</asp:HyperLink>
                        </div>
                      </div>
                      <div class="form-group">
                      <div class="col-sm-offset-3 col-sm-9">
                          <asp:Button runat="server" class="btn btn-primary" ID="btnDangnhap" 
                              Text="Đăng Nhập" Width="111px" onclick="btnDangnhap_Click"/>
                          <asp:Button runat="server" class="btn btn-danger" style="margin-left: 20px;" 
                              Text="Hủy bỏ" Width="111px" onclick="Unnamed1_Click"/>
                          </div>
                      </div>
                    </form>
                </div>
            </div>
        <div class="clear"></div>
        <div class="footer">Website Sổ Liên Lạc Điện Tử Trường THPT Bình Sơn</div>
    </div>
</body>
</html>
