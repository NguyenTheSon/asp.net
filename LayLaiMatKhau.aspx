<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LayLaiMatKhau.aspx.cs" Inherits="LayLaiMatKhAU" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Lấy Lại Mật Khẩu</title>
    <link rel="shortcut icon" href="Images/icon_diploma.png" type="image/x-icon" />
    <link href="Styles/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Styles/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="Styles/js/bootstrap.min.js" type="text/javascript"></script>
    <link href="Styles/css/styleDangnhap.css" rel="stylesheet" type="text/css" />
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
                         <span style="color:#666666; font-size:21px; padding-left:10px; font-family:Arial; font-weight:bold">Lấy lại mật khẩu</span>
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
                    <form class="form-horizontal" runat="server" action="">
                      <div class="form-group">
                        <label for="input" class="col-sm-4 control-label">Tài Khoản</label>
                        <div class="col-sm-8">
                          <asp:TextBox runat="server" class="form-control" id="txttaikhoan" 
                                placeholder="Tài khoản" ontextchanged="txttaikhoan_TextChanged" 
                                AutoPostBack="True"/>
                                <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txttaikhoan" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>-->
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="input" class="col-sm-4 control-label">Câu hỏi bảo mật</label>
                        <div class="col-sm-8">
                            <asp:TextBox runat="server" class="form-control" id="txtcauhoi" 
                               AutoPostBack="True"/>
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="input" class="col-sm-4 control-label">Trả lời</label>
                        <div class="col-sm-8">                          
                          <asp:TextBox id="txttraloi" class="form-control" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                          <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txttraloi" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>-->
                        </div>
                      </div>
                      <div class="form-group">
                      <div class="col-sm-offset-3 col-sm-9">
                          <asp:Button runat="server" class="btn btn-primary" ID="btnXacnhan" 
                              Text="Xác nhận" Width="111px" onclick="btnXacnhan_Click"/>
                          <asp:Button ID="btnQuaylai" runat="server" class="btn btn-danger" 
                              style="margin-left: 20px;" Text="Quay lại" 
                              Width="111px" onclick="btnQuaylai_Click"/>
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
