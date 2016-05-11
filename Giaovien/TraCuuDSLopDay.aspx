<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoVien/GiaoVienMaster2.master" AutoEventWireup="true" CodeFile="TraCuuDSLopDay.aspx.cs" Inherits="GiaoVien_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style5 {
            width: auto;
            text-align: left;
            height:100px;
        }
        .auto-style6 {
            width: 150px;
            text-align: center;
        }
        
        .auto-style7 {
            text-align: center;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 80%; margin:auto; margin-bottom:20px; ">
        <tr>
            <td class="auto-style1" colspan="3"><h2>Chọn khối lớp</h2></td>
        </tr>
        <tr>
            <td class="auto-style5">Khối lớp:</td>
            <td class="auto-style6">
                <asp:DropDownList ID="DrKhoiLop" runat="server" Height="25px" Width="200px">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                <asp:Button ID="btnTimLop" runat="server" Text="Tra Cứu" Width="150px" Height="25px" CssClass="auto-style7" OnClick="btnTimLop_Click" />
            </td>
        </tr>
    </table>
    <h3  style="margin:30px;">Danh sách lớp dạy <asp:Label ID="lbNamHoc" runat="server" Text=""></asp:Label></h3>
    <div class="auto-style7">
    <asp:GridView ID="GridDSLop" style="width: 90%; margin:auto; margin-bottom:30px;" runat="server" AutoGenerateColumns="False" CellPadding="8" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="MaLop" HeaderText="Mã lớp học" />
            <asp:BoundField DataField="TenLop" HeaderText="Tên lớp học" />
            <asp:BoundField DataField="TenMonHoc" HeaderText="Môn dạy" />
            <asp:BoundField DataField="Thu" HeaderText="Thứ" />
            <asp:BoundField DataField="TietHoc" HeaderText="Tiết dạy" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>
</asp:Content>

