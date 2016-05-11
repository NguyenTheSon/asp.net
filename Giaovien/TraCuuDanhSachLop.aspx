<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoVien/GiaoVienMaster2.master" AutoEventWireup="true" CodeFile="TraCuuDanhSachLop.aspx.cs" Inherits="GiaoVien_TraCuuDanhSachLop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            text-align: center;
        }
        .cot1 {
            height: 40px;
            width: 250px;
            text-align:right;
        }
        .cot2 {
            height: 40px;
            width: auto;
            text-align:center;
        }
        .auto-style5 {
            height: 40px;
            width: 145px;
            text-align: right;
        }
        .auto-style6 {
            height: 40px;
            width: auto;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; margin: auto;">
        <tr>
            <td class="auto-style4" colspan="2">
                <h3>Tra cứu danh sách lớp học</h3>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Chọn khối:</td>
            <td class="auto-style6">
                <asp:DropDownList ID="drKhoi" runat="server" Height="25px" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="cot2" colspan="2">
                <asp:Button ID="btnLocDSLop" runat="server" Text="Lọc danh sách" Height="25px" Width="200px" OnClick="btnLocDSLop_Click" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="gridDSHocSinh" style="width: 90%; margin-bottom:30px;" runat="server" AutoGenerateColumns="False" CellPadding="8"  BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="2px">
        <Columns>
            <asp:BoundField DataField="MaLop" HeaderText="Mã lớp" />
            <asp:BoundField DataField="TenLop" HeaderText="Tên Lớp" />
            <asp:HyperLinkField DataNavigateUrlFields="MaLop" DataNavigateUrlFormatString="DanhSachLopChitiet.aspx?malop={0}&action=hienthi" Text="Xem danh sách lớp" />
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

