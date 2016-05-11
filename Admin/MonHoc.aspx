﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="MonHoc.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="toptext">
<img src="../icon/settings.png" alt="IMG" style="margin-left: 20px;"/>
    <span>
        <asp:Label ID="lbllink" runat="server" Text="Danh sách môn học"></asp:Label>
    </span>
</div>
<div class="right-nd">    
    <div class="text1">    
        <hr />
        <div style="margin: 60px;">
        <asp:DataGrid ID="GridView1" runat="server"
	AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" 
            AllowPaging="True" CssClass="text-center" BorderColor="Blue" 
            BorderWidth="1px" PageSize="20">
            <AlternatingItemStyle BackColor="White" />
        <Columns>
            <asp:BoundColumn DataField="MaMonHoc" HeaderText="Mã môn học" />
            <asp:BoundColumn DataField="TenMonHoc" HeaderText="Tên môn học" />
             
        </Columns>
            <EditItemStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:DataGrid>
    </div>
    <br />
    </div>        
    </div>
</asp:Content>

