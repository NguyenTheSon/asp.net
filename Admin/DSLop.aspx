<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="DSLop.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="toptext">
<img src="../icon/settings.png" alt="IMG" style="margin-left: 20px;"/>
    <span>
        <asp:Label ID="lbllink" runat="server" Text="Danh sách lớp học"></asp:Label>
    </span>
</div>
<div class="right-nd">    
    <div class="text1">
    <br />
    <div class="form-group">
        <div class="col-sm-9">
                    <asp:Button ID="btnQuaylai" runat="server" PostBackUrl="~/Admin/LopHoc.aspx" Text="Quay lại" 
                    Width="100px"  class="btn btn-primary"/>
        </div>
    </div>    
        <hr />
        <asp:DataGrid ID="GridView1" runat="server"
	AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" 
            AllowPaging="True" CssClass="text-center" BorderColor="Blue" 
            BorderWidth="1px" PageSize="20">
            <AlternatingItemStyle BackColor="White" />
        <Columns>
            <asp:BoundColumn DataField="MaHS" HeaderText="Mã Học Sinh" />
            <asp:BoundColumn DataField="HoTenHS" HeaderText="Họ Tên Học Sinh" />
            <asp:BoundColumn DataField="DiaChi" HeaderText="Địa Chỉ" />
            <asp:BoundColumn DataField="MaLop" HeaderText="Mã Lớp" />
             
        </Columns>
            <EditItemStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:DataGrid>
    <br />
    </div>        
    </div>
</asp:Content>

