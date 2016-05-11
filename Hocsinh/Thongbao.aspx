<%@ Page Title="" Language="C#" MasterPageFile="~/Hocsinh/Hocsinh1.master" AutoEventWireup="true" CodeFile="Thongbao.aspx.cs" Inherits="Hocsinh_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<p class="text1">Thông báo</p>
<hr />
<asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>        
        <p style="text-align: left; font-weight: bold; font-size: 20px;"><asp:Label ID="Label1" runat="server" Text='<%# Bind("TenTB") %>'></asp:Label></p>
        <p style="text-align: left; font-size:12px;">
        <span>Được đăng bởi : <asp:Label ID="Label3" runat="server" Text='<%# Bind("TaiKhoan") %>'></asp:Label></span><br />
        <span><asp:Label ID="Label2" runat="server" Text='<%# Bind("NgayTB") %>'></asp:Label></span>
        </p>
        <p style="text-align: left;"><span><asp:Label ID="Label4" runat="server" Text='<%# Bind("NoiDung") %>'></asp:Label></span></p>
    </ItemTemplate>
</asp:DataList>
</asp:Content>

