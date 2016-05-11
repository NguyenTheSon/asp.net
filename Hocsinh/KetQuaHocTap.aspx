<%@ Page Title="" Language="C#" MasterPageFile="~/Hocsinh/Hocsinh1.master" AutoEventWireup="true" CodeFile="KetQuaHocTap.aspx.cs" Inherits="Hocsinh_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<p class="text1">Tra cứu điểm theo môn học</p>
<hr />
<h3 style="text-align: center;">Bảng điểm thành phần</h3>
<p style="padding-left: 30px; font-size: 15px;">
    <asp:Label ID="Label2" runat="server" Text="Môn học"></asp:Label>:
    <asp:Label ID="lblmonhoc" runat="server" style="font-weight: bold;" Text="Label"></asp:Label>
</p>
<p style="padding-left: 30px; font-size: 15px;">
    <asp:Label ID="Label1" runat="server" Text="Lớp"></asp:Label>:
    <asp:Label ID="lbllophoc" runat="server" style="font-weight: bold;" Text="Label"></asp:Label>
</p>
<br />
 <asp:GridView ID="gridBangDiem" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField DataField="MaHS" HeaderText="Mã Học Sinh" />
            <asp:BoundField DataField="HoTenHS" HeaderText="Họ Tên Học Sinh" />
            <asp:BoundField DataField="Mieng1" HeaderText="Điểm Miệng 1" />
            <asp:BoundField DataField="Mieng2" HeaderText="Điểm miệng 2" />
            <asp:BoundField DataField="Mieng3" HeaderText="Điểm miệng 3" />
            <asp:BoundField DataField="Diem15p1" HeaderText="Điểm miệng 4" />
            <asp:BoundField DataField="Diem15p2" HeaderText="Điểm KT 15p 1" />
            <asp:BoundField DataField="Diem15p3" HeaderText="Điểm KT 15p 2" />
            <asp:BoundField DataField="Diem15p4" HeaderText="Điểm KT 15p 3" />
            <asp:BoundField DataField="Diem45p1" HeaderText="Điểm KT 45p 1" />
            <asp:BoundField DataField="Diem45p2" HeaderText="Điểm KT 45p 2" />
            <asp:BoundField DataField="Diem45p3" HeaderText="Điểm KT 45p 3" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
<br />
</asp:Content>