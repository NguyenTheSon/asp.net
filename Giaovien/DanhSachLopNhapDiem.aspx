<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoVien/GiaoVienMaster2.master" AutoEventWireup="true" CodeFile="DanhSachLopNhapDiem.aspx.cs" Inherits="GiaoVien_NhapDiemThanhPhan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
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
        h3{
            text-align:center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <h3>Chọn lớp để nhập điểm</h3>
   <asp:GridView ID="gridDSHocSinh"  style="width: 90%; margin: auto; margin-top:30px; margin-bottom:30px;" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="2px" CellPadding="8">
        <Columns>
            <asp:BoundField DataField="MaLop" HeaderText="Mã lớp" />
            <asp:BoundField DataField="TenLop" HeaderText="Tên Lớp" />
            <asp:HyperLinkField DataNavigateUrlFields="MaLop" DataNavigateUrlFormatString="NhapDiemThanhPhan.aspx?malop={0}&amp;action=nhapdiem" Text="Nhập điểm" />
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

