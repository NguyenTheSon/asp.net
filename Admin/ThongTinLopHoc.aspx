<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ThongTinLopHoc.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="toptext">
<img src="../icon/settings.png" alt="IMG" style="margin-left: 20px;"/>
    <span>
        <asp:Label ID="lbllink" runat="server" Text="Quản lý lớp học"></asp:Label>
    </span>
</div>
<div class="right-nd">    
    <div class="text1">    
        <hr />
        <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Mã lớp học</label>
                <div class="col-sm-9">
                    <asp:TextBox runat="server" class="form-control" id="txtmalop" 
                    Width="60%" Enabled="false"/>
                </div>
        </div>
        <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Tên lớp học</label>
                <div class="col-sm-9">
                    <asp:TextBox runat="server" class="form-control" id="txttenlop" 
                    Width="60%" />
                </div>
        </div>
        <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Khối lớp</label>
                <div class="col-sm-9">
                    <asp:DropDownList ID="ddlkhoi" runat="server" class="form-control" Width="60%">
                    </asp:DropDownList> 
                </div>
        </div>
        <div class="form-group">
                <asp:Button ID="btnAdd" runat="server" style="margin-left: 170px" Text="Thêm" 
                    Width="65px"  class="btn btn-primary" onclick="btnAdd_Click"/>
                <asp:Button ID="btnSave" runat="server" style="margin-left: 39px" Text="Lưu" 
                        Width="65px" class="btn btn-success" onclick="btnSave_Click"/>
                <asp:Button ID="btnEdit" runat="server"  style="margin-left: 39px" Text="Sửa" 
                        Width="65px" class="btn btn-info" onclick="btnEdit_Click"/>
                <asp:Button ID="btnHuy" runat="server" Text="Hủy bỏ" style="margin-left: 39px" 
                Width="65px" class="btn btn-danger" onclick="btnHuy_Click"/>
                
            </div>
        <h3>Danh sách lớp học</h3>
            <asp:DataGrid ID="GridView1" runat="server"
	    AutoGenerateColumns="False" Width="97%" CellPadding="2" ForeColor="#333333" 
            GridLines="Vertical" BorderColor="White" AllowCustomPaging="True" 
            CssClass="text-center" AllowPaging="True">
            <AlternatingItemStyle BackColor="White" />
            <Columns>
                <asp:BoundColumn DataField="MaLop" HeaderText="Mã lớp học" />
                <asp:BoundColumn DataField="TenLop" HeaderText="Tên lớp" />
                <asp:BoundColumn DataField="KhoiLop" HeaderText="Khối lớp" />          
                <asp:HyperLinkColumn DataNavigateUrlField="malop" DataNavigateUrlFormatString="ThongTinLopHoc.aspx?malop={0}&action=edit"
                    Text="Chọn" HeaderText="Chọn"></asp:HyperLinkColumn>
            </Columns>
            <EditItemStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataGrid>
        <br />
        <br />
    </div>
</div>
</asp:Content>

