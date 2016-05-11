<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoVien/GiaoVienMaster2.master" AutoEventWireup="true" CodeFile="DiemThanhPhanChiTiet.aspx.cs" Inherits="GiaoVien_DiemThanhPhanChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .mahs {
            width: 100px;
            height: 30px;
            text-align: center;
        }

        .hoten {
            width: auto;
            height: 30px;
            text-align: center;
        }

        .cotdiem {
            width: 55px;
            height: 30px;
            text-align: center;
        }

        .auto-style6 {
            margin-left: 49px;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            width: 125px;
            height: 28px;
        }
        .auto-style9 {
            height: 28px;
        }
        .auto-style10 {
            width: 125px;
            height: 29px;
        }
        .auto-style11 {
            height: 29px;
        }
    </style>
    <script src="../JavaScript.js"></script>
    <link href="../Styles/css/DinhDangTable.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3 style="margin: 30px;">Nhập điểm thành phần lớp
        <asp:Label ID="lbTenLop" runat="server" Text=""></asp:Label>
    </h3>
    <table style="width: 50%; margin:auto; margin-bottom:30px;">
        <tr>
            <td class="auto-style8">Mã Học sinh</td>
            <td class="auto-style9">
                <asp:Label ID="lbMaHS" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Họ Tên</td>
            <td class="auto-style9">
                <asp:Label ID="lbHoTen" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Ngày Nhập</td>
            <td class="auto-style11">
                <asp:Label ID="lbNgay" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Điểm</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtDiem" runat="server" Width="155px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="2">
                <asp:Button ID="btnLuu" runat="server" Text="Lưu điểm" Width="71px" />
                <asp:Button ID="btnHuy" runat="server" CssClass="auto-style6" Text="Hủy bỏ" Width="74px" />
            </td>
        </tr>
    </table>
   
    <asp:GridView ID="DSHocSinh" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
        <Columns>
            <asp:BoundField DataField="MaHS" HeaderText="Mã Học Sinh" />
            <asp:BoundField DataField="HoTenHS" HeaderText="Họ Tên Học Sinh" />
            <asp:HyperLinkField DataNavigateUrlFields="MaHS" DataNavigateUrlFormatString="DiemThanhPhanChiTiet.aspx?mahs={0}&amp;action=nhapdiem1" Text="Nhập điểm" />
         </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>

</asp:Content>


