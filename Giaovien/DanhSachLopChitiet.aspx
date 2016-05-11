<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoVien/GiaoVienMaster2.master" AutoEventWireup="true" CodeFile="DanhSachLopChitiet.aspx.cs" Inherits="GiaoVien_DanhSachLopChitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3 style="margin:30px;">
        Danh sách lớp
        <asp:Label ID="lbTenLop" runat="server" Text=""></asp:Label>
    </h3>
   
        <asp:GridView ID="gridDSSinhVien" style="width: 90%; margin:auto; margin-bottom:30px;" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="2px" CellPadding="8">
            <Columns>
                <asp:BoundField DataField="MaHS" HeaderText="Mã học sinh" />
                <asp:BoundField DataField="HoTenHS" HeaderText="Họ tên học sinh" />
                <asp:BoundField DataField="NgaySinh" HeaderText="Ngày sinh" />
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

